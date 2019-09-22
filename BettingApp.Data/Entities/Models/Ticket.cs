using BettingApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime IssuedAt { get; set; }
        public double MoneyBet { get; set; }
        public TicketStatus Status{ get; set; }
        public double TotalQuota { get; set; }
        public ICollection<TicketBetOffer> TicketBetOffers { get; set; }
    }
}
