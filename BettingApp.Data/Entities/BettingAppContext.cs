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
        public DbSet<BetOffer> BetOffers { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketBetOffer> TicketBetOffers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketBetOffer>()
                .HasKey(tp => new { tp.TicketId, tp.BetOfferId });
            modelBuilder.Entity<TicketBetOffer>()
                .HasOne(tp => tp.Ticket)
                .WithMany(t => t.TicketBetOffers)
                .HasForeignKey(tp => tp.TicketId);
            modelBuilder.Entity<TicketBetOffer>()
                .HasOne(tp => tp.BetOffer)
                .WithMany(t => t.TicketBetOffers)
                .HasForeignKey(tp => tp.BetOfferId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.HomeTeam)
                .WithMany(ht => ht.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Match>()
                .HasOne(m => m.AwayTeam)
                .WithMany(at => at.AwayMatches)
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BetOffer>()
                .Property(p => p.Status)
                .HasConversion(
                    p => p.ToString(),
                    p => (BetOfferStatus)Enum.Parse(typeof(BetOfferStatus), p)
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
                new Match() { Id = 1,  HomeTeamId = 1,  HomeScore = 0, AwayTeamId = 2,  AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 3,  HomeTeamId = 3,  HomeScore = 0, AwayTeamId = 4,  AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 2,  HomeTeamId = 5,  HomeScore = 0, AwayTeamId = 6,  AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 4,  HomeTeamId = 7,  HomeScore = 0, AwayTeamId = 8,  AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 5,  HomeTeamId = 3,  HomeScore = 0, AwayTeamId = 6,  AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 6,  HomeTeamId = 2,  HomeScore = 0, AwayTeamId = 6,  AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 7,  HomeTeamId = 1,  HomeScore = 0, AwayTeamId = 8,  AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 1, IsTopOffer = false },
                new Match() { Id = 8,  HomeTeamId = 11, HomeScore = 0, AwayTeamId = 12, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 9,  HomeTeamId = 14, HomeScore = 0, AwayTeamId = 12, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 10, HomeTeamId = 17, HomeScore = 0, AwayTeamId = 18, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 11, HomeTeamId = 11, HomeScore = 0, AwayTeamId = 12, AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 12, HomeTeamId = 15, HomeScore = 0, AwayTeamId = 12, AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 13, HomeTeamId = 17, HomeScore = 0, AwayTeamId = 18, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 2, IsTopOffer = false },
                new Match() { Id = 14, HomeTeamId = 41, HomeScore = 0, AwayTeamId = 42, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 15, HomeTeamId = 43, HomeScore = 0, AwayTeamId = 44, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 16, HomeTeamId = 45, HomeScore = 0, AwayTeamId = 46, AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 17, HomeTeamId = 47, HomeScore = 0, AwayTeamId = 48, AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 18, HomeTeamId = 49, HomeScore = 0, AwayTeamId = 50, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 3, IsTopOffer = false },
                new Match() { Id = 19, HomeTeamId = 21, HomeScore = 0, AwayTeamId = 22, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 20, HomeTeamId = 23, HomeScore = 0, AwayTeamId = 24, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 21, HomeTeamId = 25, HomeScore = 0, AwayTeamId = 26, AwayScore = 0, StartsAt = DateTime.Now.AddDays(1), EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 22, HomeTeamId = 27, HomeScore = 0, AwayTeamId = 28, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 4, IsTopOffer = false },
                new Match() { Id = 23, HomeTeamId = 31, HomeScore = 0, AwayTeamId = 32, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 5, IsTopOffer = false },
                new Match() { Id = 24, HomeTeamId = 33, HomeScore = 0, AwayTeamId = 34, AwayScore = 0, StartsAt = DateTime.Now, EndedAt = null, SportId = 5, IsTopOffer = false },
                new Match() { Id = 25, HomeTeamId = 35, HomeScore = 0, AwayTeamId = 36, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 5, IsTopOffer = false },
                new Match() { Id = 26, HomeTeamId = 1,  HomeScore = 0, AwayTeamId = 2,  AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 1, IsTopOffer = true },
                new Match() { Id = 27, HomeTeamId = 3,  HomeScore = 0, AwayTeamId = 4,  AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 1, IsTopOffer = true },
                new Match() { Id = 28, HomeTeamId = 5,  HomeScore = 0, AwayTeamId = 6,  AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 1, IsTopOffer = true },
                new Match() { Id = 29, HomeTeamId = 44, HomeScore = 0, AwayTeamId = 41, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 2, IsTopOffer = true },
                new Match() { Id = 30, HomeTeamId = 42, HomeScore = 0, AwayTeamId = 43, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 2, IsTopOffer = true },
                new Match() { Id = 31, HomeTeamId = 20, HomeScore = 0, AwayTeamId = 21, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 3, IsTopOffer = true },
                new Match() { Id = 32, HomeTeamId = 30, HomeScore = 0, AwayTeamId = 31, AwayScore = 0, StartsAt = DateTime.Now.AddDays(2), EndedAt = null, SportId = 4, IsTopOffer = true },
                new Match() { Id = 33, HomeTeamId = 1,  HomeScore = 0, AwayTeamId = 2,  AwayScore = 0, StartsAt = new DateTime(2019, 9, 10, 20, 0, 0), EndedAt = new DateTime(2019, 9, 10, 22, 0, 0), SportId = 1, IsTopOffer = false },
                new Match() { Id = 34, HomeTeamId = 3,  HomeScore = 0, AwayTeamId = 4,  AwayScore = 0, StartsAt = new DateTime(2019, 9, 10, 20, 0, 0), EndedAt = new DateTime(2019, 9, 10, 22, 0, 0), SportId = 1, IsTopOffer = false }
            );

            modelBuilder.Entity<BetOffer>().HasData(
                new BetOffer { Id = 1,   MatchId = 1,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 2,   MatchId = 1,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 3,   MatchId = 1,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 4,   MatchId = 1,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 1.54},
                new BetOffer { Id = 5,   MatchId = 1,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42},
                new BetOffer { Id = 6,   MatchId = 1,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 7,   MatchId = 2,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 8,   MatchId = 2,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 9,   MatchId = 2,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 10,  MatchId = 2,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 11,  MatchId = 2,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42},
                new BetOffer { Id = 12,  MatchId = 2,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 13,  MatchId = 3,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 14,  MatchId = 3,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 15,  MatchId = 3,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 16,  MatchId = 3,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 17,  MatchId = 3,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42},
                new BetOffer { Id = 18,  MatchId = 3,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 19,  MatchId = 4,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 20,  MatchId = 4,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 21,  MatchId = 4,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 22,  MatchId = 4,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 23,  MatchId = 4,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 24,  MatchId = 4,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 25,  MatchId = 5,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 26,  MatchId = 5,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 27,  MatchId = 5,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 28,  MatchId = 5,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 29,  MatchId = 5,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 30,  MatchId = 5,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 31,  MatchId = 6,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 32,  MatchId = 6,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 33,  MatchId = 6,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 34,  MatchId = 6,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 35,  MatchId = 6,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 36,  MatchId = 6,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 37,  MatchId = 7,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 38,  MatchId = 7,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 39,  MatchId = 7,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 40,  MatchId = 7,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 41,  MatchId = 7,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 42,  MatchId = 7,  BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 43,  MatchId = 8,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 44,  MatchId = 8,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 45,  MatchId = 8,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 46,  MatchId = 8,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 47,  MatchId = 8,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 48,  MatchId = 9,  BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 49,  MatchId = 9,  BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 50,  MatchId = 9,  BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 51,  MatchId = 9,  BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 52,  MatchId = 9,  BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 53,  MatchId = 10, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 54,  MatchId = 10, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 55,  MatchId = 10, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 56,  MatchId = 10, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 57,  MatchId = 10, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 58,  MatchId = 11, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 59,  MatchId = 11, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 60,  MatchId = 11, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 61,  MatchId = 11, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 62,  MatchId = 11, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 63,  MatchId = 12, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 64,  MatchId = 12, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 65,  MatchId = 12, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 66,  MatchId = 12, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 67,  MatchId = 12, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 68,  MatchId = 13, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 69,  MatchId = 13, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 70,  MatchId = 13, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 71,  MatchId = 13, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 72,  MatchId = 13, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 74,  MatchId = 14, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 75,  MatchId = 14, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 76,  MatchId = 14, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 77,  MatchId = 14, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 79,  MatchId = 14, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 80,  MatchId = 15, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 81,  MatchId = 15, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 82,  MatchId = 15, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 83,  MatchId = 15, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 85,  MatchId = 15, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 86,  MatchId = 16, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 87,  MatchId = 16, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 88,  MatchId = 16, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 89,  MatchId = 16, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 91,  MatchId = 16, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 92,  MatchId = 17, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 93,  MatchId = 17, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 94,  MatchId = 17, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 95,  MatchId = 17, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 97,  MatchId = 17, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 98,  MatchId = 18, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 99,  MatchId = 18, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 100, MatchId = 18, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 101, MatchId = 18, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 103, MatchId = 18, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 104, MatchId = 19, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 105, MatchId = 19, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 106, MatchId = 19, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 107, MatchId = 19, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 108, MatchId = 19, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 109, MatchId = 19, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 110, MatchId = 20, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 111, MatchId = 20, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 112, MatchId = 20, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 113, MatchId = 20, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 114, MatchId = 20, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 115, MatchId = 20, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 116, MatchId = 21, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 117, MatchId = 21, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 118, MatchId = 21, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 119, MatchId = 21, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 120, MatchId = 21, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 121, MatchId = 21, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 122, MatchId = 22, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 123, MatchId = 22, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 124, MatchId = 22, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34},
                new BetOffer { Id = 125, MatchId = 22, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 2.14},
                new BetOffer { Id = 126, MatchId = 22, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 127, MatchId = 22, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.24},
                new BetOffer { Id = 128, MatchId = 23, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 129, MatchId = 23, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 130, MatchId = 24, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 131, MatchId = 24, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 132, MatchId = 25, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74},
                new BetOffer { Id = 133, MatchId = 25, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77},
                new BetOffer { Id = 134, MatchId = 26, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 135, MatchId = 26, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 136, MatchId = 26, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 137, MatchId = 26, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 138, MatchId = 26, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 139, MatchId = 26, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.54 },
                new BetOffer { Id = 140, MatchId = 27, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 141, MatchId = 27, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 142, MatchId = 27, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 143, MatchId = 27, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 144, MatchId = 27, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 145, MatchId = 27, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.54 },
                new BetOffer { Id = 146, MatchId = 28, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 147, MatchId = 28, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 148, MatchId = 28, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 149, MatchId = 28, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 150, MatchId = 28, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 151, MatchId = 28, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.54 },
                new BetOffer { Id = 152, MatchId = 29, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 153, MatchId = 29, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 154, MatchId = 29, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 155, MatchId = 29, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 156, MatchId = 29, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 157, MatchId = 30, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 158, MatchId = 30, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 159, MatchId = 30, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 160, MatchId = 30, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 161, MatchId = 30, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 162, MatchId = 31, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 163, MatchId = 31, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 164, MatchId = 31, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 165, MatchId = 31, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 166, MatchId = 31, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.54 },
                new BetOffer { Id = 167, MatchId = 32, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 4.5 },
                new BetOffer { Id = 168, MatchId = 32, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 2.21 },
                new BetOffer { Id = 169, MatchId = 32, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.88 },
                new BetOffer { Id = 170, MatchId = 32, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 171, MatchId = 32, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 172, MatchId = 32, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.42 },
                new BetOffer { Id = 173, MatchId = 33, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74 },
                new BetOffer { Id = 174, MatchId = 33, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77 },
                new BetOffer { Id = 175, MatchId = 33, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34 },
                new BetOffer { Id = 176, MatchId = 33, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 177, MatchId = 33, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 178, MatchId = 33, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.54 },
                new BetOffer { Id = 179, MatchId = 34, BetTypeId = 1, Status = BetOfferStatus.InProgress, Quota = 3.74 },
                new BetOffer { Id = 180, MatchId = 34, BetTypeId = 2, Status = BetOfferStatus.InProgress, Quota = 1.77 },
                new BetOffer { Id = 181, MatchId = 34, BetTypeId = 3, Status = BetOfferStatus.InProgress, Quota = 2.34 },
                new BetOffer { Id = 182, MatchId = 34, BetTypeId = 4, Status = BetOfferStatus.InProgress, Quota = 3.02 },
                new BetOffer { Id = 183, MatchId = 34, BetTypeId = 5, Status = BetOfferStatus.InProgress, Quota = 1.75 },
                new BetOffer { Id = 184, MatchId = 34, BetTypeId = 6, Status = BetOfferStatus.InProgress, Quota = 1.54 }
            );
        }
    }
}
