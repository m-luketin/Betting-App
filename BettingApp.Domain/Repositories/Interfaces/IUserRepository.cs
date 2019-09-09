using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        double GetUserBalance();
        double EditUserBalance(double newBalance);
    }
}
