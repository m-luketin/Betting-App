using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class SmallSeedFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 152,
                column: "MatchId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 153,
                column: "MatchId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 154,
                column: "MatchId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 155,
                column: "MatchId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 156,
                column: "MatchId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 157,
                column: "MatchId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 158,
                column: "MatchId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 159,
                column: "MatchId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 160,
                column: "MatchId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 161,
                column: "MatchId",
                value: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 152,
                column: "MatchId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 153,
                column: "MatchId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 154,
                column: "MatchId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 155,
                column: "MatchId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 156,
                column: "MatchId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 157,
                column: "MatchId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 158,
                column: "MatchId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 159,
                column: "MatchId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 160,
                column: "MatchId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 161,
                column: "MatchId",
                value: 9);
        }
    }
}
