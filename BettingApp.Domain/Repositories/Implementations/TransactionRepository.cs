using BettingApp.Data.Entities;
using BettingApp.Data.Entities.Models;
using BettingApp.Data.Enums;
using BettingApp.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BettingApp.Domain.Repositories.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {
        public TransactionRepository(BettingAppContext context)
        {
            _context = context;
        }
        private readonly BettingAppContext _context;

        public bool CreateTransaction(double balanceChange, TransactionType transactionType)
        {
            var createdTransaction = _context.Transactions.Add(
                new Transaction
                {
                    UserId = 1,
                    BalanceChange = balanceChange,
                    TransactionType = transactionType
                });

            if(createdTransaction == null)
                return false;

            return true;
        }

        public List<Transaction> GetUserTransactions(int userId)
        {
            return _context.Transactions.Where(t => t.UserId == userId).ToList();
        }
    }
}
