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
                .Include(m => m.Pairs)
                .ThenInclude(p => p.TicketPairs)
                .ThenInclude(tp => tp.Ticket)
                .Include(m => m.TeamMatches)
                .ThenInclude(tm => tm.Team)
                .Include(m => m.Pairs)
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

                    foreach(var teamMatch in match.TeamMatches)
                    {
                        Random rnd = new Random();
                        teamMatch.Score = rnd.Next(0, maxScore);

                        if(teamMatch.IsHome)
                            homeScore = teamMatch.Score;
                        else
                            awayScore = teamMatch.Score;
                    }
                }
                else
                {
                        Random rnd = new Random();
                        var whoWon = rnd.Next(1, 2);

                    if(whoWon == 1)
                    {
                        homeScore = 1;
                        awayScore = 0;
                    }
                    else if(whoWon == 2)
                    {
                        homeScore = 0;
                        awayScore = 1;
                    }

                    foreach(var teamMatch in match.TeamMatches)
                    {
                        if(whoWon == 1 && teamMatch.IsHome)
                        {
                            teamMatch.Score = 1;
                        }
                    }
                }

                // editing associated winning/losing pairs
                var winningPairs = new List<string>();

                if(homeScore > awayScore)
                    winningPairs.AddRange(new string[]{ "1", "1X", "12"});
                else if(homeScore < awayScore)
                    winningPairs.AddRange(new string[] { "2", "2X", "12" });
                else
                    winningPairs.AddRange(new string[] { "1X", "2X", "X" });

                foreach(var pair in match.Pairs)
                {
                    if(winningPairs.Contains(pair.BetType.Type))
                        pair.Status = PairStatus.IsCorrect;
                    else
                        pair.Status = PairStatus.IsFalse;
                }
            }

            // editing winning/losing tickets
            var ticketsToEdit = _context.Tickets
                .Where(t => t.Status == TicketStatus.InProgress)
                .Include(t => t.TicketPairs)
                .ThenInclude(tp => tp.Pair);

            foreach(var ticket in ticketsToEdit)
            {
                var ticketPairs = _context.TicketPairs.Where(tp => tp.TicketId == ticket.Id);
                var status = "win";

                foreach(var ticketPair in ticketPairs)
                {
                    if(ticketPair.Pair.Status == PairStatus.InProgress)
                    {
                        status = "inProgress";
                    }
                    else if(ticketPair.Pair.Status == PairStatus.IsFalse)
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

            _context.SaveChanges();
            return true;
        }
    }
}
