using BettingApp.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        bool AddTicket(double moneyBet, double totalQuota, List<int> pairIds);
    }
}
