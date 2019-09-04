using BettingApp.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface IMatchRepository
    {
        List<Match> GetMatchesByDate(string date);
        List<Match> GetFutureMatches();
    }
}
