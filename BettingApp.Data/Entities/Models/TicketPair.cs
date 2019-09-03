using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class TicketPair
    {
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public int PairId { get; set; }
        public Pair Pair { get; set; }
    }
}
