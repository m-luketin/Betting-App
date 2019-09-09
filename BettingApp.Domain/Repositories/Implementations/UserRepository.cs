using BettingApp.Data.Entities;
using BettingApp.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(BettingAppContext context)
        {
            _context = context;
        }
        private readonly BettingAppContext _context;

        public double EditUserBalance(double newBalance)
        {
            var user = _context.Users.Find(1);

            user.CurrentFunds = newBalance;
            _context.SaveChanges();

            return newBalance;
        }

        public double GetUserBalance()
        {
            return _context.Users.Find(1).CurrentFunds;
        }
    }
}
