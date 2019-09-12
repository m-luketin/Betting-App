using BettingApp.Data.Entities;
using BettingApp.Data.Entities.Models;
using BettingApp.Data.Enums;
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

            var transactionToAdd = new Transaction
            {
                UserId = 1,
                BalanceChange = balanceToAdd,
                Time = DateTime.Now,
                TransactionType = TransactionType.BalancePayment
            };

            _context.Transactions.Add(transactionToAdd);

            _context.SaveChanges();

            return user.CurrentFunds;
        }

        public double GetUserBalance(int userId)
        {
            return _context.Users.Find(userId).CurrentFunds;
        }
    }
}
