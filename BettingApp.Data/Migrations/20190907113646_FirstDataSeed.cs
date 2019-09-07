using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class FirstDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BetTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 1, "Home win", "1" },
                    { 2, "Away win", "2" },
                    { 3, "Home win/Tie", "1X" },
                    { 4, "Away win/Tie", "2X" },
                    { 5, "Tie", "X" },
                    { 6, "Home win/Away win", "12" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "UFC" },
                    { 4, "Baseball" },
                    { 6, "Cricket" },
                    { 2, "Basketball" },
                    { 1, "Football" },
                    { 3, "Handball" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 37, "Dustin Poirier" },
                    { 28, "Cincinnati Reds" },
                    { 29, "St. Louis Cardinals" },
                    { 30, "Oakland A's" },
                    { 31, "Jon Jones" },
                    { 32, "Khabib Nurmagedov" },
                    { 33, "Henry Cejudo" },
                    { 34, "Stipe Miocic" },
                    { 35, "Max Holloway" },
                    { 36, "Daniel Cormier" },
                    { 38, "Kumaru Usman" },
                    { 44, "France" },
                    { 40, "Robert Whittaker" },
                    { 41, "Croatia" },
                    { 42, "England" },
                    { 43, "USA" },
                    { 27, "Chicago Cubs" },
                    { 45, "Germany" },
                    { 46, "Brazil" },
                    { 47, "Spain" },
                    { 48, "Portugal" },
                    { 49, "Canada" },
                    { 39, "Tony Ferguson" },
                    { 26, "Boston Red Sox" },
                    { 20, "New Orleans Pelicans" },
                    { 24, "San Antonio Spurs" },
                    { 1, "Real Madrid" },
                    { 2, "Barcelona" },
                    { 3, "Bayern Munich" },
                    { 4, "Borussia Dortmund" },
                    { 5, "Chelsea" },
                    { 6, "Liverpool" },
                    { 7, "Leicester" },
                    { 8, "Manchester City" },
                    { 9, "Juventus" },
                    { 10, "Paris Saint-Germain" },
                    { 11, "Houston Rockets" },
                    { 12, "Golden State Warriors" },
                    { 13, "Portland Trail Blazers" },
                    { 14, "San Antonio Spurs" },
                    { 15, "LA Clippers" },
                    { 16, "Denver Nuggets" },
                    { 17, "Utah Jazz" },
                    { 18, "Los Angeles Lakers" },
                    { 19, "Sacramento Kings" },
                    { 50, "Ireland" },
                    { 21, "Los Angeles Dodgers" },
                    { 22, "Pittsburgh Pirates" },
                    { 23, "New York Yankees" },
                    { 25, "San Francisco Giants" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CurrentFunds", "Username" },
                values: new object[] { 1, 0.0, "MainUser" });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "EndedAt", "SportId", "StartsAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2019, 9, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2019, 9, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 9, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 9, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 8, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 9, 9, 20, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SportBetTypes",
                columns: new[] { "SportId", "BetTypeId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 4, 6 },
                    { 4, 5 },
                    { 4, 4 },
                    { 4, 3 },
                    { 4, 2 },
                    { 4, 1 },
                    { 6, 4 },
                    { 5, 2 },
                    { 1, 1 },
                    { 3, 5 },
                    { 1, 6 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 6, 5 },
                    { 1, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 6 },
                    { 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[,]
                {
                    { 1, 1, true, 0 },
                    { 46, 8, false, 35 },
                    { 35, 9, true, 32 },
                    { 33, 9, false, 24 },
                    { 1, 18, true, 0 },
                    { 2, 18, false, 1 },
                    { 1, 19, true, 0 },
                    { 2, 19, false, 1 },
                    { 1, 21, true, 0 },
                    { 2, 21, false, 1 },
                    { 47, 10, true, 6 },
                    { 48, 10, false, 3 },
                    { 1, 11, true, 7 },
                    { 2, 11, false, 4 },
                    { 1, 20, true, 0 },
                    { 2, 20, false, 1 },
                    { 1, 22, true, 0 },
                    { 2, 22, false, 1 },
                    { 1, 12, true, 1 },
                    { 2, 12, false, 0 },
                    { 1, 13, true, 0 },
                    { 2, 13, false, 1 },
                    { 44, 8, true, 40 },
                    { 2, 25, false, 1 },
                    { 1, 25, true, 0 },
                    { 2, 17, false, 1 },
                    { 2, 1, false, 1 },
                    { 3, 2, true, 3 },
                    { 4, 2, false, 1 },
                    { 5, 3, true, 2 },
                    { 6, 3, false, 0 },
                    { 7, 4, true, 1 },
                    { 8, 4, false, 1 },
                    { 1, 14, true, 3 },
                    { 2, 14, false, 1 },
                    { 1, 15, true, 0 },
                    { 1, 23, true, 0 },
                    { 2, 15, false, 2 },
                    { 2, 24, false, 1 },
                    { 11, 5, true, 27 },
                    { 12, 5, false, 31 },
                    { 13, 6, true, 32 },
                    { 14, 6, false, 27 },
                    { 15, 7, true, 22 },
                    { 16, 7, false, 30 },
                    { 1, 16, true, 0 },
                    { 2, 16, false, 1 },
                    { 1, 17, true, 0 },
                    { 1, 24, true, 0 },
                    { 2, 23, false, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "SportBetTypes",
                keyColumns: new[] { "SportId", "BetTypeId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 35, 9 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 44, 8 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 46, 8 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 47, 10 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 48, 10 });

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BetTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
