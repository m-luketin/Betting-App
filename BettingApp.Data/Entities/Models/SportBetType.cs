using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class SportBetType
    {
        public int SportId { get; set; }
        public Sport Sport { get; set; }
        public int BetTypeId { get; set; }
        public BetType BetType { get; set; }
    }
}
