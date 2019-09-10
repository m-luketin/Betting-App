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

        public double AddUserBalance(double balanceToAdd)
        {
            var user = _context.Users.Find(1);

            user.CurrentFunds += balanceToAdd;
            _context.SaveChanges();

            return user.CurrentFunds;
        }

        public double GetUserBalance()
        {
            return _context.Users.Find(1).CurrentFunds;
        }
    }
}
