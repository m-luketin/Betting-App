using BettingApp.Data.Entities;
using BettingApp.Data.Enums;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BettingApp.Domain.Repositories.Implementations
{
    public class MockResultsRepository : IMockResultsRepository
    {
        public MockResultsRepository(BettingAppContext context)
        {
            _context = context;
        }
        private readonly BettingAppContext _context;

        public bool UpdateResults()
        {
            // selecting matches that have ended and need a score
            var matchesToUpdate = _context.Matches
                .Where(m => DateTime.Now - m.StartsAt > new TimeSpan(2, 0, 0) && m.EndedAt == null)
                .Include(m => m.Sport)
                .Include(m => m.BetOffers)
                .ThenInclude(p => p.TicketBetOffers)
                .ThenInclude(tp => tp.Ticket)
                .Include(m => m.HomeTeam)
                .Include(m => m.AwayTeam)
                .Include(m => m.BetOffers)
                .ThenInclude(p => p.BetType);

            foreach(var match in matchesToUpdate)
            {
                match.EndedAt = match.StartsAt.AddHours(2);

                var maxScore = 1;
                var homeScore = 0;
                var awayScore = 0;

                if(match.Sport.Name != "UFC")
                {
                    switch(match.Sport.Name) // max score differentiation between sports
                    {
                        case "Football":
                            maxScore = 5;
                            break;
                        case "Baseball":
                            maxScore = 10;
                            break;
                        case "BasketBall":
                            maxScore = 40;
                            break;
                        case "Cricket":
                            maxScore = 20;
                            break;
                        case "Handball":
                            maxScore = 35;
                            break;
                        default:
                            break;
                    }
                    Random rnd = new Random();
                    match.HomeScore = rnd.Next(0, maxScore);
                    match.AwayScore = rnd.Next(0, maxScore);
                }
                else
                {
                    Random rnd = new Random();
                    var whoWon = rnd.Next(0, 1);

                    match.HomeScore = whoWon;
                    match.AwayScore = (whoWon + 1) % 2;

                    // editing associated winning/losing BetOffers
                    var winningBetOffers = new List<string>();

                    if(homeScore > awayScore)
                        winningBetOffers.AddRange(new string[] { "1", "1X", "12" });
                    else if(homeScore < awayScore)
                        winningBetOffers.AddRange(new string[] { "2", "2X", "12" });
                    else
                        winningBetOffers.AddRange(new string[] { "1X", "2X", "X" });

                    foreach(var BetOffer in match.BetOffers)
                    {
                        if(winningBetOffers.Contains(BetOffer.BetType.Type))
                            BetOffer.Status = BetOfferStatus.IsCorrect;
                        else
                            BetOffer.Status = BetOfferStatus.IsFalse;
                    }
                }

                // editing winning/losing tickets
                var ticketsToEdit = _context.Tickets
                    .Where(t => t.Status == TicketStatus.InProgress)
                    .Include(t => t.TicketBetOffers)
                    .ThenInclude(tp => tp.BetOffer);

                foreach(var ticket in ticketsToEdit)
                {
                    var ticketBetOffers = _context.TicketBetOffers.Where(tp => tp.TicketId == ticket.Id);
                    var status = "win";

                    foreach(var ticketBetOffer in ticketBetOffers)
                    {
                        if(ticketBetOffer.BetOffer.Status == BetOfferStatus.InProgress)
                        {
                            status = "inProgress";
                        }
                        else if(ticketBetOffer.BetOffer.Status == BetOfferStatus.IsFalse)
                        {
                            status = "lose";
                            break;
                        }
                    }

                    if(status == "win")
                    {
                        ticket.Status = TicketStatus.Won;
                        ticket.User.CurrentFunds += 0.95 * ticket.MoneyBet * ticket.TotalQuota;
                    }
                    else if(status == "lose")
                        ticket.Status = TicketStatus.Lost;
                }
            }
            _context.SaveChanges();
            return true;
        }
    }
}

