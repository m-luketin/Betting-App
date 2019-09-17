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

        public bool AddTicket(double moneyBet, double totalQuota, List<int> pairIds)
        {
            if(!(moneyBet > 0 && moneyBet <= 1000) || pairIds.Count < 3)
                return false;

            var user = _context.Users.Find(1);
            if(user.CurrentFunds < moneyBet)
                return false;

            var ticketToAdd = new Ticket
            {
                UserId = 1,
                IssuedAt = DateTime.Now,
                Status = TicketStatus.InProgress,
                MoneyBet = moneyBet,
                TotalQuota = totalQuota
            };

            var wasSucessful = _context.Tickets.Add(ticketToAdd);
            if(wasSucessful == null)
                return false;

            foreach(var pairId in pairIds)
            {
                _context.TicketPairs.Add(new TicketPair { TicketId = ticketToAdd.Id, PairId = pairId });
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
                .Include(t => t.TicketPairs)
                .ThenInclude(tp => tp.Pair)
                .ThenInclude(p => p.BetType)
                .Include(t => t.TicketPairs)
                .ThenInclude(tp => tp.Pair)
                .ThenInclude(p => p.Match)
                .ThenInclude(m => m.TeamMatches)
                .ThenInclude(tm => tm.Team)
                .OrderByDescending(t => t.IssuedAt)
                .ToList();

            // nulling circular references
            foreach(var ticket in ticketsToGet)
            {
                foreach(var ticketPair in ticket.TicketPairs)
                {
                    ticketPair.Ticket = null;
                    ticketPair.Pair.TicketPairs = null;
                    ticketPair.Pair.BetType.Pairs = null;
                    ticketPair.Pair.Match.Pairs = null;

                    foreach(var teamMatch in ticketPair.Pair.Match.TeamMatches)
                    {
                        teamMatch.Match = null;
                        teamMatch.Team.TeamMatches = null;
                    }
                }
            }

            return ticketsToGet;
        }
    }
}
