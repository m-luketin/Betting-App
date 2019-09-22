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

        public List<Match> GetMatchesBySportAndDate(string sport, string date)
        {
            var matchesToGet = new List<Match>();

            if(date == "all" && sport == "All")
            {
                matchesToGet = _context.Matches.Where(m => m.EndedAt == null && !m.IsTopOffer)
                    .Include(m => m.BetOffers)
                    .ThenInclude(p => p.BetType)
                    .Include(m => m.HomeTeam)
                    .Include(m => m.AwayTeam)
                    .Include(m => m.Sport)
                    .OrderBy(m => m.StartsAt)
                    .ToList();
            }
            else if(date == "all")
            {
                matchesToGet = _context.Matches.Where(m => m.EndedAt == null && !m.IsTopOffer 
                    && string.Equals(m.Sport.Name, sport, StringComparison.CurrentCultureIgnoreCase))
                    .Include(m => m.BetOffers)
                    .ThenInclude(p => p.BetType)
                    .Include(m => m.HomeTeam)
                    .Include(m => m.AwayTeam)
                    .Include(m => m.Sport)
                    .OrderBy(m => m.StartsAt)
                    .ToList();
            }
            else
            {
                var parsedDate = date.Split('-');
                var day = int.Parse(parsedDate[2]);
                var month = int.Parse(parsedDate[1]);
                var year = int.Parse(parsedDate[0]);

                if(sport == "All")
                {
                    matchesToGet = _context.Matches.Where(m => m.EndedAt == null && m.StartsAt.Day == day 
                        && m.StartsAt.Month == month && m.StartsAt.Year == year && !m.IsTopOffer)
                        .Include(m => m.BetOffers)
                        .ThenInclude(p => p.BetType)
                        .Include(m => m.HomeTeam)
                        .Include(m => m.AwayTeam)
                        .Include(m => m.Sport)
                        .OrderBy(m => m.StartsAt)
                        .ToList();
                }
                else
                {
                    matchesToGet = _context.Matches.Where(m => m.EndedAt == null && m.StartsAt.Day == day 
                        && m.StartsAt.Month == month && m.StartsAt.Year == year && !m.IsTopOffer
                        && string.Equals(m.Sport.Name, sport, StringComparison.CurrentCultureIgnoreCase))
                        .Include(m => m.BetOffers)
                        .ThenInclude(p => p.BetType)
                        .Include(m => m.HomeTeam)
                        .Include(m => m.AwayTeam)
                        .Include(m => m.Sport)
                        .OrderBy(m => m.StartsAt)
                        .ToList();
                }
            }

            foreach(var match in matchesToGet)
            {
                match.Sport.Matches = null;
                match.HomeTeam.HomeMatches = null;
                match.HomeTeam.AwayMatches = null;
                match.AwayTeam.HomeMatches = null;
                match.AwayTeam.AwayMatches = null;

                foreach(var BetOffer in match.BetOffers)
                {
                    BetOffer.Match = null;
                    BetOffer.BetType.BetOffers = null;
                }
            }
            return matchesToGet;
        }

        public List<Match> GetTopOfferBySport(string sport)
        {
            var matchesToGet = new List<Match>();

            if(sport != "All")
            {
                matchesToGet = _context.Matches.Where(m =>
                string.Equals(m.Sport.Name, sport, StringComparison.CurrentCultureIgnoreCase) && m.EndedAt == null && m.IsTopOffer)
                    .Include(m => m.BetOffers)
                    .ThenInclude(p => p.BetType)
                    .Include(m => m.HomeTeam)
                    .Include(m => m.AwayTeam)
                    .Include(m => m.Sport)
                    .OrderBy(m => m.StartsAt)
                    .ToList();
            }
            else
            {
                matchesToGet = _context.Matches.Where(m => m.EndedAt == null && m.IsTopOffer)
                    .Include(m => m.BetOffers)
                    .ThenInclude(p => p.BetType)
                    .Include(m => m.HomeTeam)
                    .Include(m => m.AwayTeam)
                    .Include(m => m.Sport)
                    .OrderBy(m => m.StartsAt)
                    .ToList();

            }

            foreach(var match in matchesToGet)
            {
                match.HomeTeam.HomeMatches = null;
                match.HomeTeam.AwayMatches = null;
                match.AwayTeam.HomeMatches = null;
                match.AwayTeam.AwayMatches = null;
                match.Sport.Matches = null;

                foreach(var BetOffer in match.BetOffers)
                {
                    BetOffer.Match = null;
                    BetOffer.BetType.BetOffers = null;
                }
            }
            return matchesToGet;
        }
    }
}
