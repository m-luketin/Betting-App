using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class SmallSeedFix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 40, 29 });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[] { 44, 29, true, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 44, 29 });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[] { 40, 29, true, 0 });
        }
    }
}
