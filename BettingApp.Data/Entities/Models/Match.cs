using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public int SportId { get; set; }
        public Sport Sport{ get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int HomeScore { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int AwayScore { get; set; }
        public ICollection<BetOffer> BetOffers { get; set; }
        public bool IsTopOffer { get; set; }
    }
}

