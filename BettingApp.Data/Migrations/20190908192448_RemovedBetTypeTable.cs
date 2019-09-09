using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class RemovedBetTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SportBetTypes");

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 102);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SportBetTypes",
                columns: table => new
                {
                    SportId = table.Column<int>(nullable: false),
                    BetTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportBetTypes", x => new { x.SportId, x.BetTypeId });
                    table.ForeignKey(
                        name: "FK_SportBetTypes_BetTypes_BetTypeId",
                        column: x => x.BetTypeId,
                        principalTable: "BetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportBetTypes_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pairs",
                columns: new[] { "Id", "BetTypeId", "IsTopOffer", "MatchId", "Quota", "Status" },
                values: new object[,]
                {
                    { 73, 6, false, 13, 1.24, "IsCorrect" },
                    { 78, 5, false, 14, 1.54, "IsFalse" },
                    { 84, 5, false, 15, 1.54, "IsFalse" },
                    { 90, 5, false, 16, 1.54, "IsFalse" },
                    { 96, 5, false, 17, 1.54, "IsFalse" },
                    { 102, 5, false, 18, 1.54, "IsFalse" }
                });

            migrationBuilder.InsertData(
                table: "SportBetTypes",
                columns: new[] { "SportId", "BetTypeId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 6, 1 },
                    { 5, 2 },
                    { 3, 6 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 5, 1 },
                    { 3, 5 },
                    { 3, 2 },
                    { 3, 3 },
                    { 6, 5 },
                    { 3, 1 },
                    { 2, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 1, 1 },
                    { 3, 4 },
                    { 6, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SportBetTypes_BetTypeId",
                table: "SportBetTypes",
                column: "BetTypeId");
        }
    }
}
