using BettingApp.Data.Entities.Models;
using BettingApp.Data.Enums;
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
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMatch> TeamMatches { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketPair> TicketPairs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

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

            modelBuilder.Entity<Pair>()
                .Property(p => p.Status)
                .HasConversion(
                    p => p.ToString(),
                    p => (PairStatus)Enum.Parse(typeof(PairStatus), p)
                );
            modelBuilder.Entity<Ticket>()
                .Property(t => t.Status)
                .HasConversion(
                    t => t.ToString(),
                    t => (TicketStatus)Enum.Parse(typeof(TicketStatus), t)
                );

            // data seed
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "MainUser", CurrentFunds = 0 }
            );

            modelBuilder.Entity<Sport>().HasData(
                new Sport() { Id = 1, Name = "Football" },
                new Sport() { Id = 2, Name = "Basketball" },
                new Sport() { Id = 3, Name = "Handball" },
                new Sport() { Id = 4, Name = "Baseball" },
                new Sport() { Id = 5, Name = "UFC" },
                new Sport() { Id = 6, Name = "Cricket" }
            );

            modelBuilder.Entity<BetType>().HasData(
                new BetType { Id = 1, Type = "1",  Description = "Home win" },
                new BetType { Id = 2, Type = "2",  Description = "Away win" },
                new BetType { Id = 3, Type = "1X", Description = "Home win/Tie" },
                new BetType { Id = 4, Type = "2X", Description = "Away win/Tie" },
                new BetType { Id = 5, Type = "X",  Description = "Tie" },
                new BetType { Id = 6, Type = "12", Description = "Home win/Away win" }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team() { Id = 1,  Name = "Real Madrid" },
                new Team() { Id = 2,  Name = "Barcelona" },
                new Team() { Id = 3,  Name = "Bayern Munich" },
                new Team() { Id = 4,  Name = "Borussia Dortmund" },
                new Team() { Id = 5,  Name = "Chelsea" },
                new Team() { Id = 6,  Name = "Liverpool" },
                new Team() { Id = 7,  Name = "Leicester" },
                new Team() { Id = 8,  Name = "Manchester City" },
                new Team() { Id = 9,  Name = "Juventus" },
                new Team() { Id = 10, Name = "Paris Saint-Germain" },
                new Team() { Id = 11, Name = "Houston Rockets" },
                new Team() { Id = 12, Name = "Golden State Warriors" },
                new Team() { Id = 13, Name = "Portland Trail Blazers" },
                new Team() { Id = 14, Name = "San Antonio Spurs" },
                new Team() { Id = 15, Name = "LA Clippers" },
                new Team() { Id = 16, Name = "Denver Nuggets" },
                new Team() { Id = 17, Name = "Utah Jazz" },
                new Team() { Id = 18, Name = "Los Angeles Lakers" },
                new Team() { Id = 19, Name = "Sacramento Kings" },
                new Team() { Id = 20, Name = "New Orleans Pelicans" },
                new Team() { Id = 21, Name = "Los Angeles Dodgers" },
                new Team() { Id = 22, Name = "Pittsburgh Pirates" },
                new Team() { Id = 23, Name = "New York Yankees" },
                new Team() { Id = 24, Name = "San Antonio Spurs" },
                new Team() { Id = 25, Name = "San Francisco Giants" },
                new Team() { Id = 26, Name = "Boston Red Sox" },
                new Team() { Id = 27, Name = "Chicago Cubs" },
                new Team() { Id = 28, Name = "Cincinnati Reds" },
                new Team() { Id = 29, Name = "St. Louis Cardinals" },
                new Team() { Id = 30, Name = "Oakland A's" },
                new Team() { Id = 31, Name = "Jon Jones" },
                new Team() { Id = 32, Name = "Khabib Nurmagedov" },
                new Team() { Id = 33, Name = "Henry Cejudo" },
                new Team() { Id = 34, Name = "Stipe Miocic" },
                new Team() { Id = 35, Name = "Max Holloway" },
                new Team() { Id = 36, Name = "Daniel Cormier" },
                new Team() { Id = 37, Name = "Dustin Poirier" },
                new Team() { Id = 38, Name = "Kumaru Usman" },
                new Team() { Id = 39, Name = "Tony Ferguson" },
                new Team() { Id = 40, Name = "Robert Whittaker" },
                new Team() { Id = 41, Name = "Croatia" },
                new Team() { Id = 42, Name = "England" },
                new Team() { Id = 43, Name = "USA" },
                new Team() { Id = 44, Name = "France" },
                new Team() { Id = 45, Name = "Germany" },
                new Team() { Id = 46, Name = "Brazil" },
                new Team() { Id = 47, Name = "Spain" },
                new Team() { Id = 48, Name = "Portugal" },
                new Team() { Id = 49, Name = "Canada" },
                new Team() { Id = 50, Name = "Ireland" }
            );

            modelBuilder.Entity<Match>().HasData(
                new Match() { Id = 1,  StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 3,  StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 2,  StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 4,  StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 5,  StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 6,  StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 7,  StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 8,  StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 9,  StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 10, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 11, StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 12, StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 13, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 14, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 15, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 16, StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 17, StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 18, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 19, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 20, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 21, StartsAt = new DateTime(2019, 9, 17, 20, 0, 0), EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 22, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 23, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 5, IsTopOffer = false },
                new Match() { Id = 24, StartsAt = new DateTime(2019, 9, 16, 20, 0, 0), EndedAt = null, SportId = 5, IsTopOffer = false },
                new Match() { Id = 25, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 5, IsTopOffer = false },
                new Match() { Id = 26, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = true },
                new Match() { Id = 27, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = true },
                new Match() { Id = 28, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = true },
                new Match() { Id = 29, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = true },
                new Match() { Id = 30, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 2, IsTopOffer = true },
                new Match() { Id = 31, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 3, IsTopOffer = true },
                new Match() { Id = 32, StartsAt = new DateTime(2019, 9, 18, 20, 0, 0), EndedAt = null, SportId = 4, IsTopOffer = true },
                new Match() { Id = 33, StartsAt = new DateTime(2019, 9, 10, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 34, StartsAt = new DateTime(2019, 9, 10, 20, 0, 0), EndedAt = null, SportId = 1, IsTopOffer = false }
            );

            modelBuilder.Entity<TeamMatch>().HasData(
                new TeamMatch { MatchId = 1,  TeamId = 1,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 1,  TeamId = 2,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 2,  TeamId = 3,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 2,  TeamId = 4,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 3,  TeamId = 5,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 3,  TeamId = 6,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 4,  TeamId = 7,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 4,  TeamId = 8,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 5,  TeamId = 3,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 5,  TeamId = 7,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 6,  TeamId = 2,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 6,  TeamId = 6,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 7,  TeamId = 1,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 7,  TeamId = 8,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 8,  TeamId = 11, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 8,  TeamId = 12, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 9,  TeamId = 14, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 9,  TeamId = 12, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 10, TeamId = 17, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 10, TeamId = 18, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 11, TeamId = 11, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 11, TeamId = 12, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 12, TeamId = 15, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 12, TeamId = 12, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 13, TeamId = 17, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 13, TeamId = 18, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 14, TeamId = 41, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 14, TeamId = 42, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 15, TeamId = 43, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 15, TeamId = 44, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 16, TeamId = 45, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 16, TeamId = 46, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 17, TeamId = 47, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 17, TeamId = 48, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 18, TeamId = 49, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 18, TeamId = 50, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 19, TeamId = 21, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 19, TeamId = 22, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 20, TeamId = 23, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 20, TeamId = 24, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 21, TeamId = 25, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 21, TeamId = 26, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 22, TeamId = 27, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 22, TeamId = 28, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 23, TeamId = 31, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 23, TeamId = 32, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 24, TeamId = 33, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 24, TeamId = 34, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 25, TeamId = 35, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 25, TeamId = 36, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 26, TeamId = 1,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 26, TeamId = 2,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 27, TeamId = 3,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 27, TeamId = 4,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 28, TeamId = 5,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 28, TeamId = 6,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 29, TeamId = 44, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 29, TeamId = 41, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 30, TeamId = 42, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 30, TeamId = 43, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 31, TeamId = 20, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 31, TeamId = 21, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 32, TeamId = 30, IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 32, TeamId = 31, IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 33, TeamId = 1,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 33, TeamId = 2,  IsHome = false, Score = 0 },
                new TeamMatch { MatchId = 34, TeamId = 3,  IsHome = true,  Score = 0 },
                new TeamMatch { MatchId = 34, TeamId = 4,  IsHome = false, Score = 0 }
            );

            modelBuilder.Entity<Pair>().HasData(
                new Pair { Id = 1,   MatchId = 1,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 2,   MatchId = 1,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 3,   MatchId = 1,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 4,   MatchId = 1,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 5,   MatchId = 1,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 6,   MatchId = 1,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 7,   MatchId = 2,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 8,   MatchId = 2,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 9,   MatchId = 2,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 10,  MatchId = 2,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 11,  MatchId = 2,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 12,  MatchId = 2,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 13,  MatchId = 3,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 14,  MatchId = 3,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 15,  MatchId = 3,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 16,  MatchId = 3,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 17,  MatchId = 3,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 18,  MatchId = 3,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 19,  MatchId = 4,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 20,  MatchId = 4,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 21,  MatchId = 4,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 22,  MatchId = 4,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 23,  MatchId = 4,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 24,  MatchId = 4,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 25,  MatchId = 5,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 26,  MatchId = 5,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 27,  MatchId = 5,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 28,  MatchId = 5,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 29,  MatchId = 5,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 30,  MatchId = 5,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 31,  MatchId = 6,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 32,  MatchId = 6,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 33,  MatchId = 6,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 34,  MatchId = 6,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 35,  MatchId = 6,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 36,  MatchId = 6,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 37,  MatchId = 7,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 38,  MatchId = 7,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 39,  MatchId = 7,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 40,  MatchId = 7,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 41,  MatchId = 7,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 42,  MatchId = 7,  BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 43,  MatchId = 8,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 44,  MatchId = 8,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 45,  MatchId = 8,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 46,  MatchId = 8,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 47,  MatchId = 8,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 48,  MatchId = 9,  BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 49,  MatchId = 9,  BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 50,  MatchId = 9,  BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 51,  MatchId = 9,  BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 52,  MatchId = 9,  BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 53,  MatchId = 10, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 54,  MatchId = 10, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 55,  MatchId = 10, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 56,  MatchId = 10, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 57,  MatchId = 10, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 58,  MatchId = 11, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 59,  MatchId = 11, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 60,  MatchId = 11, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 61,  MatchId = 11, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 62,  MatchId = 11, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 63,  MatchId = 12, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 64,  MatchId = 12, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 65,  MatchId = 12, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 66,  MatchId = 12, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 67,  MatchId = 12, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 68,  MatchId = 13, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 69,  MatchId = 13, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 70,  MatchId = 13, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 71,  MatchId = 13, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 72,  MatchId = 13, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 74,  MatchId = 14, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 75,  MatchId = 14, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 76,  MatchId = 14, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 77,  MatchId = 14, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 79,  MatchId = 14, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 80,  MatchId = 15, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 81,  MatchId = 15, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 82,  MatchId = 15, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 83,  MatchId = 15, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 85,  MatchId = 15, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 86,  MatchId = 16, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 87,  MatchId = 16, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 88,  MatchId = 16, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 89,  MatchId = 16, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 91,  MatchId = 16, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 92,  MatchId = 17, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 93,  MatchId = 17, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 94,  MatchId = 17, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 95,  MatchId = 17, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 97,  MatchId = 17, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 98,  MatchId = 18, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 99,  MatchId = 18, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 100, MatchId = 18, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 101, MatchId = 18, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 103, MatchId = 18, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 104, MatchId = 19, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 105, MatchId = 19, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 106, MatchId = 19, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 107, MatchId = 19, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 108, MatchId = 19, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 109, MatchId = 19, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 110, MatchId = 20, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 111, MatchId = 20, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 112, MatchId = 20, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 113, MatchId = 20, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 114, MatchId = 20, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 115, MatchId = 20, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 116, MatchId = 21, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 117, MatchId = 21, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 118, MatchId = 21, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 119, MatchId = 21, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 120, MatchId = 21, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 121, MatchId = 21, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 122, MatchId = 22, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 123, MatchId = 22, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 124, MatchId = 22, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34},
                new Pair { Id = 125, MatchId = 22, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 2.14},
                new Pair { Id = 126, MatchId = 22, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.54},
                new Pair { Id = 127, MatchId = 22, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.24},
                new Pair { Id = 128, MatchId = 23, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 129, MatchId = 23, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 130, MatchId = 24, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 131, MatchId = 24, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 132, MatchId = 25, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74},
                new Pair { Id = 133, MatchId = 25, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77},
                new Pair { Id = 134, MatchId = 26, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 135, MatchId = 26, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 136, MatchId = 26, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 137, MatchId = 26, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 138, MatchId = 26, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 139, MatchId = 26, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 },
                new Pair { Id = 140, MatchId = 27, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 141, MatchId = 27, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 142, MatchId = 27, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 143, MatchId = 27, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 144, MatchId = 27, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 145, MatchId = 27, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 },
                new Pair { Id = 146, MatchId = 28, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 147, MatchId = 28, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 148, MatchId = 28, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 149, MatchId = 28, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 150, MatchId = 28, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 151, MatchId = 28, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 },
                new Pair { Id = 152, MatchId = 29, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 153, MatchId = 29, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 154, MatchId = 29, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 155, MatchId = 29, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 156, MatchId = 29, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 157, MatchId = 30, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 158, MatchId = 30, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 159, MatchId = 30, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 160, MatchId = 30, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 161, MatchId = 30, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 162, MatchId = 31, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 163, MatchId = 31, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 164, MatchId = 31, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 165, MatchId = 31, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 166, MatchId = 31, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 },
                new Pair { Id = 167, MatchId = 32, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 4.5 },
                new Pair { Id = 168, MatchId = 32, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 2.21 },
                new Pair { Id = 169, MatchId = 32, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.88 },
                new Pair { Id = 170, MatchId = 32, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 171, MatchId = 32, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 172, MatchId = 32, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 },
                new Pair { Id = 173, MatchId = 33, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74 },
                new Pair { Id = 174, MatchId = 33, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77 },
                new Pair { Id = 175, MatchId = 33, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34 },
                new Pair { Id = 176, MatchId = 33, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 177, MatchId = 33, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 178, MatchId = 33, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 },
                new Pair { Id = 179, MatchId = 34, BetTypeId = 1, Status = PairStatus.InProgress, Quota = 3.74 },
                new Pair { Id = 180, MatchId = 34, BetTypeId = 2, Status = PairStatus.InProgress, Quota = 1.77 },
                new Pair { Id = 181, MatchId = 34, BetTypeId = 3, Status = PairStatus.InProgress, Quota = 2.34 },
                new Pair { Id = 182, MatchId = 34, BetTypeId = 4, Status = PairStatus.InProgress, Quota = 3.02 },
                new Pair { Id = 183, MatchId = 34, BetTypeId = 5, Status = PairStatus.InProgress, Quota = 1.75 },
                new Pair { Id = 184, MatchId = 34, BetTypeId = 6, Status = PairStatus.InProgress, Quota = 1.54 }
            );
        }
    }
}
