﻿using BettingApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class Pair
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }
        public int BetTypeId { get; set; }
        public BetType BetType { get; set; }
        public PairStatus Status { get; set; }
        public double Quota { get; set; }
        public ICollection<TicketPair> TicketPairs { get; set; }
    }
}
