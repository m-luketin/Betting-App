using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Match> AwayMatches { get; set; }
        public ICollection<Match> HomeMatches { get; set; }
    }
}
