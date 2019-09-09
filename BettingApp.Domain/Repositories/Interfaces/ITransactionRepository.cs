using BettingApp.Data.Entities.Models;
using BettingApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Domain.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        bool CreateTransaction(double balanceChange, TransactionType transactionType);
        List<Transaction> GetUserTransactions(int userId);
    }
}
