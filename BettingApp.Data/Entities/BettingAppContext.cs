using BettingApp.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities
{
    public class BettingAppContext : DbContext
    {
        public BettingAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BetType> BetTypes { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Pair> Pairs { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<SportBetType> SportBetTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMatch> TeamMatches { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketPair> TicketPairs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketPair>()
                .HasKey(tp => new { tp.TicketId, tp.PairId });
            modelBuilder.Entity<TicketPair>()
                .HasOne(tp => tp.Ticket)
                .WithMany(t => t.TicketPairs)
                .HasForeignKey(tp => tp.TicketId);
            modelBuilder.Entity<TicketPair>()
                .HasOne(tp => tp.Pair)
                .WithMany(t => t.TicketPairs)
                .HasForeignKey(tp => tp.PairId);

            modelBuilder.Entity<SportBetType>()
                .HasKey(sbt => new { sbt.SportId, sbt.BetTypeId });
            modelBuilder.Entity<SportBetType>()
                .HasOne(sbt => sbt.Sport)
                .WithMany(t => t.SportBetTypes)
                .HasForeignKey(sbt => sbt.SportId);
            modelBuilder.Entity<SportBetType>()
                .HasOne(sbt => sbt.BetType)
                .WithMany(t => t.SportBetTypes)
                .HasForeignKey(sbt => sbt.BetTypeId);

            modelBuilder.Entity<TeamMatch>()
                .HasKey(tm => new { tm.TeamId, tm.MatchId });
            modelBuilder.Entity<TeamMatch>()
                .HasOne(tm => tm.Match)
                .WithMany(m => m.TeamMatches)
                .HasForeignKey(tm => tm.MatchId);
            modelBuilder.Entity<TeamMatch>()
                .HasOne(tm => tm.Team)
                .WithMany(m => m.TeamMatches)
                .HasForeignKey(tm => tm.TeamId);
        }
    }
}
