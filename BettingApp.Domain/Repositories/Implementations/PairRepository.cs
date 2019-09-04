using BettingApp.Data.Entities;
using BettingApp.Data.Entities.Models;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BettingApp.Domain.Repositories.Implementations
{
    public class PairRepository : IPairRepository
    {
        public PairRepository(BettingAppContext context)
        {
            _context = context;
        }
        private readonly BettingAppContext _context;

        public List<Pair> GetFuturePairs()
        {
            var pairsToGet = _context.Pairs.Where(p =>
                p.Match.StartsAt - DateTime.Now > new TimeSpan(0, 0, 0)).ToList();

            foreach(var pair in pairsToGet)
            {
                pair.Match.Pairs = null;
                pair.TicketPairs = null;
                pair.BetType.Pairs  = null;
            }

            return pairsToGet;
        }

        public List<Pair> GetPairsByDate(string date)
        {
            var parsedDate = date.Split('-');
            var day = int.Parse(parsedDate[2]);
            var month = int.Parse(parsedDate[1]);
            var year = int.Parse(parsedDate[0]);

            var pairsToGet = _context.Pairs.Where(p => 
                p.Match.StartsAt.Day == day && p.Match.StartsAt.Month == month && p.Match.StartsAt.Year == year)
                .Include(p => p.Match).ThenInclude(m => m.TeamMatches).ThenInclude(tm => tm.Team).ToList();
            
            return pairsToGet;
        }
    }
}
