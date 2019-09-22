using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class TicketBetOffer
    {
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int BetOfferId { get; set; }
        public BetOffer BetOffer { get; set; }
        public double Quota { get; set; }
    }
}
