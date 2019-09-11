using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndedAt { get; set; }
        public int SportId { get; set; }
        public Sport Sport{ get; set; }
        public ICollection<Pair> Pairs { get; set; }
        public ICollection<TeamMatch> TeamMatches { get; set; }
        public bool IsTopOffer { get; set; }
    }
}

