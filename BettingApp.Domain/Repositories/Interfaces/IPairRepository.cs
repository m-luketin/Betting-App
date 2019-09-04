using BettingApp.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface IPairRepository
    {
        List<Pair> GetPairsByDate(string date);
        List<Pair> GetFuturePairs();
    }
}
