using BettingApp.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface IMatchRepository
    {
        List<Match> GetMatchesBySportAndDate(string sport, string date);
        List<Match> GetFutureMatches();
        List<Match> GetTopOfferBySport(string sport);
}
}
