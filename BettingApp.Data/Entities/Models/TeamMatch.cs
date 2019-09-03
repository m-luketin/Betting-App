using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class TeamMatch
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }
        public bool IsHome { get; set; }
        public int Score { get; set; }
    }
}
