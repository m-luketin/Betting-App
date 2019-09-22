using BettingApp.Data.Entities;
using BettingApp.Data.Entities.Models;
using BettingApp.Data.Enums;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BettingApp.Domain.Repositories.Implementations
{
    public class TicketRepository : ITicketRepository
    {
        public TicketRepository(BettingAppContext context)
        {
            _context = context;
        }
        private readonly BettingAppContext _context;

        public bool AddTicket(double moneyBet, List<int> BetOfferIds)
        {
            if(!(moneyBet > 0 && moneyBet <= 1000) || BetOfferIds.Count < 3)
                return false;

            var user = _context.Users.Find(1);
            if(user.CurrentFunds < moneyBet)
                return false;

            var betOffersOnTicket = _context.BetOffers.Where(bo => BetOfferIds.Contains(bo.Id)).ToList();
            var totalQuota = 1.0;

            foreach(var betOffer in betOffersOnTicket)
            {
                totalQuota *= betOffer.Quota;
            }

            var ticketToAdd = new Ticket
            {
                UserId = 1,
                IssuedAt = DateTime.Now,
                Status = TicketStatus.InProgress,
                MoneyBet = moneyBet,
                TotalQuota = totalQuota
            };

            var wasSuccessful = _context.Tickets.Add(ticketToAdd);
            if(wasSuccessful == null)
                return false;

            foreach(var BetOfferId in BetOfferIds)
            {
                _context.TicketBetOffers.Add(new TicketBetOffer { TicketId = ticketToAdd.Id, BetOfferId = BetOfferId });
            }

            user.CurrentFunds -= moneyBet;

            var transactionToAdd = new Transaction
            {
                UserId = 1,
                BalanceChange = moneyBet * (-1),
                Time = DateTime.Now,
                TransactionType = TransactionType.TicketBet
            };

            _context.Transactions.Add(transactionToAdd);

            _context.SaveChanges();
            return true;
        }

        public List<Ticket> GetUserTickets(int userId)
        {
            var ticketsToGet = _context.Tickets.Where(t => t.UserId == userId)
                .Include(t => t.TicketBetOffers)
                .ThenInclude(tp => tp.BetOffer)
                .ThenInclude(p => p.BetType)
                .Include(t => t.TicketBetOffers)
                .ThenInclude(tbo => tbo.BetOffer)
                .ThenInclude(p => p.Match)
                .ThenInclude(m => m.HomeTeam)
                .Include(t => t.TicketBetOffers)
                .ThenInclude(tbo => tbo.BetOffer)
                .ThenInclude(p => p.Match)
                .ThenInclude(m => m.AwayTeam)
                .Include(t => t.TicketBetOffers)
                .ThenInclude(tbo => tbo.BetOffer)
                .ThenInclude(p => p.Match)
                .ThenInclude(m => m.Sport)
                .OrderByDescending(t => t.IssuedAt)
                .ToList();

            // nulling circular references
            foreach(var ticket in ticketsToGet)
            {
                foreach(var ticketBetOffer in ticket.TicketBetOffers)
                {
                    ticketBetOffer.Ticket = null;
                    ticketBetOffer.BetOffer.TicketBetOffers = null;
                    ticketBetOffer.BetOffer.BetType.BetOffers = null;
                    ticketBetOffer.BetOffer.Match.BetOffers = null;
                    ticketBetOffer.BetOffer.Match.HomeTeam.HomeMatches = null;
                    ticketBetOffer.BetOffer.Match.HomeTeam.AwayMatches = null;
                    ticketBetOffer.BetOffer.Match.AwayTeam.HomeMatches = null;
                    ticketBetOffer.BetOffer.Match.AwayTeam.AwayMatches = null;
                    ticketBetOffer.BetOffer.Match.Sport.Matches = null;
                }
            }

            return ticketsToGet;
        }
    }
}
