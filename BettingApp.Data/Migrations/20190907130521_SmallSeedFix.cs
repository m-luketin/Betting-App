using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class SmallSeedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[] { 11, 8, true, 3 });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[] { 12, 8, false, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[] { 3, 8, true, 3 });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[] { 1, 8, false, 1 });
        }
    }
}
