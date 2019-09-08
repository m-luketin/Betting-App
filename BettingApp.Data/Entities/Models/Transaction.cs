using BettingApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public double BalanceChange { get; set; }
        public DateTime Time { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
