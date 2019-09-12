using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        double GetUserBalance(int userId);
        double AddUserBalance(double balanceToAdd);
    }
}
