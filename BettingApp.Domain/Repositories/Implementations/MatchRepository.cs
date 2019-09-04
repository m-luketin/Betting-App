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
    public class MatchRepository : IMatchRepository
    {
        public MatchRepository(BettingAppContext context)
        {
            _context = context;
        }
        private readonly BettingAppContext _context;

        public List<Match> GetFutureMatches()
        {
            var matchesToGet = _context.Matches.Where(m =>
                m.StartsAt - DateTime.Now > new TimeSpan(0, 0, 0)).ToList();

            return matchesToGet;
        }

        public List<Match> GetMatchesByDate(string date)
        {
            var parsedDate = date.Split('-');
            var day = int.Parse(parsedDate[2]);
            var month = int.Parse(parsedDate[1]);
            var year = int.Parse(parsedDate[0]);

            var matchesToGet = _context.Matches.Where(m =>
                m.StartsAt.Day == day && m.StartsAt.Month == month && m.StartsAt.Year == year)
                .Include(m => m.Pairs).Include(m => m.TeamMatches).ThenInclude(tm => tm.Team)
                .Include(m => m.Sport).ThenInclude(s => s.SportBetTypes).ThenInclude(sbt => sbt.BetType)
                .ToList();

            return matchesToGet;
        }
    }
}
