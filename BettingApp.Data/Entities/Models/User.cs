using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public double CurrentFunds { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
