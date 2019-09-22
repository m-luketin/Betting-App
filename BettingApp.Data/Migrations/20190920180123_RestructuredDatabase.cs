using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class RestructuredDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMatches");

            migrationBuilder.DropTable(
                name: "TicketPairs");

            migrationBuilder.DropTable(
                name: "Pairs");

            migrationBuilder.AddColumn<int>(
                name: "AwayScore",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AwayTeamId",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeScore",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeTeamId",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BetOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchId = table.Column<int>(nullable: false),
                    BetTypeId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Quota = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BetOffers_BetTypes_BetTypeId",
                        column: x => x.BetTypeId,
                        principalTable: "BetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BetOffers_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketBetOffers",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false),
                    BetOfferId = table.Column<int>(nullable: false),
                    Quota = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketBetOffers", x => new { x.TicketId, x.BetOfferId });
                    table.ForeignKey(
                        name: "FK_TicketBetOffers_BetOffers_BetOfferId",
                        column: x => x.BetOfferId,
                        principalTable: "BetOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketBetOffers_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BetOffers",
                columns: new[] { "Id", "BetTypeId", "MatchId", "Quota", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, 3.7400000000000002, "InProgress" },
                    { 122, 1, 22, 3.7400000000000002, "InProgress" },
                    { 123, 2, 22, 1.77, "InProgress" },
                    { 124, 3, 22, 2.3399999999999999, "InProgress" },
                    { 125, 4, 22, 2.1400000000000001, "InProgress" },
                    { 126, 5, 22, 1.4199999999999999, "InProgress" },
                    { 127, 6, 22, 1.24, "InProgress" },
                    { 128, 1, 23, 3.7400000000000002, "InProgress" },
                    { 129, 2, 23, 1.77, "InProgress" },
                    { 121, 6, 21, 1.24, "InProgress" },
                    { 130, 1, 24, 3.7400000000000002, "InProgress" },
                    { 132, 1, 25, 3.7400000000000002, "InProgress" },
                    { 133, 2, 25, 1.77, "InProgress" },
                    { 134, 1, 26, 4.5, "InProgress" },
                    { 135, 2, 26, 2.21, "InProgress" },
                    { 136, 3, 26, 2.8799999999999999, "InProgress" },
                    { 137, 4, 26, 3.02, "InProgress" },
                    { 138, 5, 26, 1.75, "InProgress" },
                    { 139, 6, 26, 1.54, "InProgress" },
                    { 131, 2, 24, 1.77, "InProgress" },
                    { 120, 5, 21, 1.4199999999999999, "InProgress" },
                    { 119, 4, 21, 2.1400000000000001, "InProgress" },
                    { 118, 3, 21, 2.3399999999999999, "InProgress" },
                    { 97, 6, 17, 1.24, "InProgress" },
                    { 98, 1, 18, 3.7400000000000002, "InProgress" },
                    { 99, 2, 18, 1.77, "InProgress" },
                    { 100, 3, 18, 2.3399999999999999, "InProgress" },
                    { 101, 4, 18, 2.1400000000000001, "InProgress" },
                    { 103, 6, 18, 1.24, "InProgress" },
                    { 104, 1, 19, 3.7400000000000002, "InProgress" },
                    { 105, 2, 19, 1.77, "InProgress" },
                    { 106, 3, 19, 2.3399999999999999, "InProgress" },
                    { 107, 4, 19, 2.1400000000000001, "InProgress" },
                    { 108, 5, 19, 1.4199999999999999, "InProgress" },
                    { 109, 6, 19, 1.24, "InProgress" },
                    { 110, 1, 20, 3.7400000000000002, "InProgress" },
                    { 111, 2, 20, 1.77, "InProgress" },
                    { 113, 4, 20, 2.1400000000000001, "InProgress" },
                    { 114, 5, 20, 1.4199999999999999, "InProgress" },
                    { 115, 6, 20, 1.24, "InProgress" },
                    { 116, 1, 21, 3.7400000000000002, "InProgress" },
                    { 117, 2, 21, 1.77, "InProgress" },
                    { 140, 1, 27, 4.5, "InProgress" },
                    { 95, 4, 17, 2.1400000000000001, "InProgress" },
                    { 141, 2, 27, 2.21, "InProgress" },
                    { 143, 4, 27, 3.02, "InProgress" },
                    { 167, 1, 32, 4.5, "InProgress" },
                    { 168, 2, 32, 2.21, "InProgress" },
                    { 169, 3, 32, 2.8799999999999999, "InProgress" },
                    { 170, 4, 32, 3.02, "InProgress" },
                    { 171, 5, 32, 1.75, "InProgress" },
                    { 172, 6, 32, 1.4199999999999999, "InProgress" },
                    { 173, 1, 33, 3.7400000000000002, "InProgress" },
                    { 174, 2, 33, 1.77, "InProgress" },
                    { 166, 6, 31, 1.54, "InProgress" },
                    { 175, 3, 33, 2.3399999999999999, "InProgress" },
                    { 177, 5, 33, 1.75, "InProgress" },
                    { 178, 6, 33, 1.54, "InProgress" },
                    { 179, 1, 34, 3.7400000000000002, "InProgress" },
                    { 180, 2, 34, 1.77, "InProgress" },
                    { 181, 3, 34, 2.3399999999999999, "InProgress" },
                    { 182, 4, 34, 3.02, "InProgress" },
                    { 183, 5, 34, 1.75, "InProgress" },
                    { 184, 6, 34, 1.54, "InProgress" },
                    { 176, 4, 33, 3.02, "InProgress" },
                    { 165, 4, 31, 3.02, "InProgress" },
                    { 164, 3, 31, 2.8799999999999999, "InProgress" },
                    { 163, 2, 31, 2.21, "InProgress" },
                    { 144, 5, 27, 1.75, "InProgress" },
                    { 145, 6, 27, 1.54, "InProgress" },
                    { 146, 1, 28, 4.5, "InProgress" },
                    { 147, 2, 28, 2.21, "InProgress" },
                    { 148, 3, 28, 2.8799999999999999, "InProgress" },
                    { 149, 4, 28, 3.02, "InProgress" },
                    { 150, 5, 28, 1.75, "InProgress" },
                    { 151, 6, 28, 1.54, "InProgress" },
                    { 152, 1, 29, 4.5, "InProgress" },
                    { 153, 2, 29, 2.21, "InProgress" },
                    { 154, 3, 29, 2.8799999999999999, "InProgress" },
                    { 155, 4, 29, 3.02, "InProgress" },
                    { 156, 5, 29, 1.75, "InProgress" },
                    { 157, 1, 30, 4.5, "InProgress" },
                    { 158, 2, 30, 2.21, "InProgress" },
                    { 159, 3, 30, 2.8799999999999999, "InProgress" },
                    { 160, 4, 30, 3.02, "InProgress" },
                    { 161, 5, 30, 1.75, "InProgress" },
                    { 162, 1, 31, 4.5, "InProgress" },
                    { 142, 3, 27, 2.8799999999999999, "InProgress" },
                    { 94, 3, 17, 2.3399999999999999, "InProgress" },
                    { 112, 3, 20, 2.3399999999999999, "InProgress" },
                    { 92, 1, 17, 3.7400000000000002, "InProgress" },
                    { 25, 1, 5, 3.7400000000000002, "InProgress" },
                    { 26, 2, 5, 1.77, "InProgress" },
                    { 27, 3, 5, 2.3399999999999999, "InProgress" },
                    { 28, 4, 5, 2.1400000000000001, "InProgress" },
                    { 93, 2, 17, 1.77, "InProgress" },
                    { 30, 6, 5, 1.24, "InProgress" },
                    { 31, 1, 6, 3.7400000000000002, "InProgress" },
                    { 32, 2, 6, 1.77, "InProgress" },
                    { 24, 6, 4, 1.24, "InProgress" },
                    { 33, 3, 6, 2.3399999999999999, "InProgress" },
                    { 35, 5, 6, 1.4199999999999999, "InProgress" },
                    { 36, 6, 6, 1.24, "InProgress" },
                    { 37, 1, 7, 3.7400000000000002, "InProgress" },
                    { 38, 2, 7, 1.77, "InProgress" },
                    { 39, 3, 7, 2.3399999999999999, "InProgress" },
                    { 40, 4, 7, 2.1400000000000001, "InProgress" },
                    { 41, 5, 7, 1.4199999999999999, "InProgress" },
                    { 42, 6, 7, 1.24, "InProgress" },
                    { 34, 4, 6, 2.1400000000000001, "InProgress" },
                    { 23, 5, 4, 1.4199999999999999, "InProgress" },
                    { 22, 4, 4, 2.1400000000000001, "InProgress" },
                    { 21, 3, 4, 2.3399999999999999, "InProgress" },
                    { 2, 2, 1, 1.77, "InProgress" },
                    { 3, 3, 1, 2.3399999999999999, "InProgress" },
                    { 4, 4, 1, 1.54, "InProgress" },
                    { 5, 5, 1, 1.4199999999999999, "InProgress" },
                    { 6, 6, 1, 1.24, "InProgress" },
                    { 7, 1, 2, 3.7400000000000002, "InProgress" },
                    { 8, 2, 2, 1.77, "InProgress" },
                    { 9, 3, 2, 2.3399999999999999, "InProgress" },
                    { 10, 4, 2, 2.1400000000000001, "InProgress" },
                    { 11, 5, 2, 1.4199999999999999, "InProgress" },
                    { 12, 6, 2, 1.24, "InProgress" },
                    { 13, 1, 3, 3.7400000000000002, "InProgress" },
                    { 14, 2, 3, 1.77, "InProgress" },
                    { 15, 3, 3, 2.3399999999999999, "InProgress" },
                    { 16, 4, 3, 2.1400000000000001, "InProgress" },
                    { 17, 5, 3, 1.4199999999999999, "InProgress" },
                    { 18, 6, 3, 1.24, "InProgress" },
                    { 19, 1, 4, 3.7400000000000002, "InProgress" },
                    { 20, 2, 4, 1.77, "InProgress" },
                    { 43, 1, 8, 3.7400000000000002, "InProgress" },
                    { 44, 2, 8, 1.77, "InProgress" },
                    { 29, 5, 5, 1.4199999999999999, "InProgress" },
                    { 46, 4, 8, 2.1400000000000001, "InProgress" },
                    { 70, 3, 13, 2.3399999999999999, "InProgress" },
                    { 71, 4, 13, 2.1400000000000001, "InProgress" },
                    { 72, 5, 13, 1.4199999999999999, "InProgress" },
                    { 74, 1, 14, 3.7400000000000002, "InProgress" },
                    { 75, 2, 14, 1.77, "InProgress" },
                    { 76, 3, 14, 2.3399999999999999, "InProgress" },
                    { 77, 4, 14, 2.1400000000000001, "InProgress" },
                    { 79, 6, 14, 1.24, "InProgress" },
                    { 69, 2, 13, 1.77, "InProgress" },
                    { 80, 1, 15, 3.7400000000000002, "InProgress" },
                    { 82, 3, 15, 2.3399999999999999, "InProgress" },
                    { 83, 4, 15, 2.1400000000000001, "InProgress" },
                    { 85, 6, 15, 1.24, "InProgress" },
                    { 45, 3, 8, 2.3399999999999999, "InProgress" },
                    { 87, 2, 16, 1.77, "InProgress" },
                    { 88, 3, 16, 2.3399999999999999, "InProgress" },
                    { 89, 4, 16, 2.1400000000000001, "InProgress" },
                    { 91, 6, 16, 1.24, "InProgress" },
                    { 81, 2, 15, 1.77, "InProgress" },
                    { 68, 1, 13, 3.7400000000000002, "InProgress" },
                    { 86, 1, 16, 3.7400000000000002, "InProgress" },
                    { 66, 4, 12, 2.1400000000000001, "InProgress" },
                    { 47, 5, 8, 1.4199999999999999, "InProgress" },
                    { 48, 1, 9, 3.7400000000000002, "InProgress" },
                    { 49, 2, 9, 1.77, "InProgress" },
                    { 50, 3, 9, 2.3399999999999999, "InProgress" },
                    { 51, 4, 9, 2.1400000000000001, "InProgress" },
                    { 52, 5, 9, 1.4199999999999999, "InProgress" },
                    { 53, 1, 10, 3.7400000000000002, "InProgress" },
                    { 55, 3, 10, 2.3399999999999999, "InProgress" },
                    { 56, 4, 10, 2.1400000000000001, "InProgress" },
                    { 54, 2, 10, 1.77, "InProgress" },
                    { 58, 1, 11, 3.7400000000000002, "InProgress" },
                    { 59, 2, 11, 1.77, "InProgress" },
                    { 60, 3, 11, 2.3399999999999999, "InProgress" },
                    { 67, 5, 12, 1.4199999999999999, "InProgress" },
                    { 61, 4, 11, 2.1400000000000001, "InProgress" },
                    { 62, 5, 11, 1.4199999999999999, "InProgress" },
                    { 63, 1, 12, 3.7400000000000002, "InProgress" },
                    { 64, 2, 12, 1.77, "InProgress" },
                    { 65, 3, 12, 2.3399999999999999, "InProgress" },
                    { 57, 5, 10, 1.4199999999999999, "InProgress" }
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 8, 7 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 6, 3 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 6, 2 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 12, 14 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 18, 17 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 12, 15 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 18, 17 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 42, 41 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 44, 43 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 46, 45 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 48, 47 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 50, 49 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 22, 21 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 24, 23 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 26, 25 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 28, 27 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 32, 31 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 34, 33 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 36, 35 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 41, 44 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 43, 42 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 21, 20 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 31, 30 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AwayTeamId", "HomeTeamId" },
                values: new object[] { 4, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_BetOffers_BetTypeId",
                table: "BetOffers",
                column: "BetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BetOffers_MatchId",
                table: "BetOffers",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketBetOffers_BetOfferId",
                table: "TicketBetOffers",
                column: "BetOfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Teams_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_AwayTeamId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Teams_HomeTeamId",
                table: "Matches");

            migrationBuilder.DropTable(
                name: "TicketBetOffers");

            migrationBuilder.DropTable(
                name: "BetOffers");

            migrationBuilder.DropIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "AwayScore",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "AwayTeamId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HomeScore",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "HomeTeamId",
                table: "Matches");

            migrationBuilder.CreateTable(
                name: "Pairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BetTypeId = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: false),
                    Quota = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pairs_BetTypes_BetTypeId",
                        column: x => x.BetTypeId,
                        principalTable: "BetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pairs_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMatches",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: false),
                    IsHome = table.Column<bool>(nullable: false),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMatches", x => new { x.TeamId, x.MatchId });
                    table.ForeignKey(
                        name: "FK_TeamMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMatches_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketPairs",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false),
                    PairId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketPairs", x => new { x.TicketId, x.PairId });
                    table.ForeignKey(
                        name: "FK_TicketPairs_Pairs_PairId",
                        column: x => x.PairId,
                        principalTable: "Pairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketPairs_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pairs",
                columns: new[] { "Id", "BetTypeId", "MatchId", "Quota", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, 3.7400000000000002, "InProgress" },
                    { 121, 6, 21, 1.24, "InProgress" },
                    { 122, 1, 22, 3.7400000000000002, "InProgress" },
                    { 123, 2, 22, 1.77, "InProgress" },
                    { 124, 3, 22, 2.3399999999999999, "InProgress" },
                    { 125, 4, 22, 2.1400000000000001, "InProgress" },
                    { 126, 5, 22, 1.4199999999999999, "InProgress" },
                    { 127, 6, 22, 1.24, "InProgress" },
                    { 128, 1, 23, 3.7400000000000002, "InProgress" },
                    { 120, 5, 21, 1.4199999999999999, "InProgress" },
                    { 130, 1, 24, 3.7400000000000002, "InProgress" },
                    { 132, 1, 25, 3.7400000000000002, "InProgress" },
                    { 133, 2, 25, 1.77, "InProgress" },
                    { 134, 1, 26, 4.5, "InProgress" },
                    { 135, 2, 26, 2.21, "InProgress" },
                    { 136, 3, 26, 2.8799999999999999, "InProgress" },
                    { 137, 4, 26, 3.02, "InProgress" },
                    { 138, 5, 26, 1.75, "InProgress" },
                    { 139, 6, 26, 1.54, "InProgress" },
                    { 131, 2, 24, 1.77, "InProgress" },
                    { 119, 4, 21, 2.1400000000000001, "InProgress" },
                    { 118, 3, 21, 2.3399999999999999, "InProgress" },
                    { 117, 2, 21, 1.77, "InProgress" },
                    { 97, 6, 17, 1.24, "InProgress" },
                    { 98, 1, 18, 3.7400000000000002, "InProgress" },
                    { 99, 2, 18, 1.77, "InProgress" },
                    { 100, 3, 18, 2.3399999999999999, "InProgress" },
                    { 101, 4, 18, 2.1400000000000001, "InProgress" },
                    { 103, 6, 18, 1.24, "InProgress" },
                    { 104, 1, 19, 3.7400000000000002, "InProgress" },
                    { 105, 2, 19, 1.77, "InProgress" },
                    { 106, 3, 19, 2.3399999999999999, "InProgress" },
                    { 107, 4, 19, 2.1400000000000001, "InProgress" },
                    { 108, 5, 19, 1.4199999999999999, "InProgress" },
                    { 109, 6, 19, 1.24, "InProgress" },
                    { 110, 1, 20, 3.7400000000000002, "InProgress" },
                    { 111, 2, 20, 1.77, "InProgress" },
                    { 112, 3, 20, 2.3399999999999999, "InProgress" },
                    { 113, 4, 20, 2.1400000000000001, "InProgress" },
                    { 114, 5, 20, 1.4199999999999999, "InProgress" },
                    { 115, 6, 20, 1.24, "InProgress" },
                    { 116, 1, 21, 3.7400000000000002, "InProgress" },
                    { 140, 1, 27, 4.5, "InProgress" },
                    { 95, 4, 17, 2.1400000000000001, "InProgress" },
                    { 141, 2, 27, 2.21, "InProgress" },
                    { 143, 4, 27, 3.02, "InProgress" },
                    { 167, 1, 32, 4.5, "InProgress" },
                    { 168, 2, 32, 2.21, "InProgress" },
                    { 169, 3, 32, 2.8799999999999999, "InProgress" },
                    { 170, 4, 32, 3.02, "InProgress" },
                    { 171, 5, 32, 1.75, "InProgress" },
                    { 172, 6, 32, 1.4199999999999999, "InProgress" },
                    { 173, 1, 33, 3.7400000000000002, "InProgress" },
                    { 174, 2, 33, 1.77, "InProgress" },
                    { 166, 6, 31, 1.54, "InProgress" },
                    { 175, 3, 33, 2.3399999999999999, "InProgress" },
                    { 177, 5, 33, 1.75, "InProgress" },
                    { 178, 6, 33, 1.54, "InProgress" },
                    { 179, 1, 34, 3.7400000000000002, "InProgress" },
                    { 180, 2, 34, 1.77, "InProgress" },
                    { 181, 3, 34, 2.3399999999999999, "InProgress" },
                    { 182, 4, 34, 3.02, "InProgress" },
                    { 183, 5, 34, 1.75, "InProgress" },
                    { 184, 6, 34, 1.54, "InProgress" },
                    { 176, 4, 33, 3.02, "InProgress" },
                    { 165, 4, 31, 3.02, "InProgress" },
                    { 164, 3, 31, 2.8799999999999999, "InProgress" },
                    { 163, 2, 31, 2.21, "InProgress" },
                    { 144, 5, 27, 1.75, "InProgress" },
                    { 145, 6, 27, 1.54, "InProgress" },
                    { 146, 1, 28, 4.5, "InProgress" },
                    { 147, 2, 28, 2.21, "InProgress" },
                    { 148, 3, 28, 2.8799999999999999, "InProgress" },
                    { 149, 4, 28, 3.02, "InProgress" },
                    { 150, 5, 28, 1.75, "InProgress" },
                    { 151, 6, 28, 1.54, "InProgress" },
                    { 152, 1, 29, 4.5, "InProgress" },
                    { 153, 2, 29, 2.21, "InProgress" },
                    { 154, 3, 29, 2.8799999999999999, "InProgress" },
                    { 155, 4, 29, 3.02, "InProgress" },
                    { 156, 5, 29, 1.75, "InProgress" },
                    { 157, 1, 30, 4.5, "InProgress" },
                    { 158, 2, 30, 2.21, "InProgress" },
                    { 159, 3, 30, 2.8799999999999999, "InProgress" },
                    { 160, 4, 30, 3.02, "InProgress" },
                    { 161, 5, 30, 1.75, "InProgress" },
                    { 162, 1, 31, 4.5, "InProgress" },
                    { 142, 3, 27, 2.8799999999999999, "InProgress" },
                    { 94, 3, 17, 2.3399999999999999, "InProgress" },
                    { 129, 2, 23, 1.77, "InProgress" },
                    { 92, 1, 17, 3.7400000000000002, "InProgress" },
                    { 25, 1, 5, 3.7400000000000002, "InProgress" },
                    { 26, 2, 5, 1.77, "InProgress" },
                    { 27, 3, 5, 2.3399999999999999, "InProgress" },
                    { 28, 4, 5, 2.1400000000000001, "InProgress" },
                    { 29, 5, 5, 1.4199999999999999, "InProgress" },
                    { 30, 6, 5, 1.24, "InProgress" },
                    { 31, 1, 6, 3.7400000000000002, "InProgress" },
                    { 32, 2, 6, 1.77, "InProgress" },
                    { 24, 6, 4, 1.24, "InProgress" },
                    { 33, 3, 6, 2.3399999999999999, "InProgress" },
                    { 35, 5, 6, 1.4199999999999999, "InProgress" },
                    { 36, 6, 6, 1.24, "InProgress" },
                    { 37, 1, 7, 3.7400000000000002, "InProgress" },
                    { 38, 2, 7, 1.77, "InProgress" },
                    { 39, 3, 7, 2.3399999999999999, "InProgress" },
                    { 40, 4, 7, 2.1400000000000001, "InProgress" },
                    { 41, 5, 7, 1.4199999999999999, "InProgress" },
                    { 42, 6, 7, 1.24, "InProgress" },
                    { 34, 4, 6, 2.1400000000000001, "InProgress" },
                    { 23, 5, 4, 1.4199999999999999, "InProgress" },
                    { 22, 4, 4, 2.1400000000000001, "InProgress" },
                    { 21, 3, 4, 2.3399999999999999, "InProgress" },
                    { 2, 2, 1, 1.77, "InProgress" },
                    { 3, 3, 1, 2.3399999999999999, "InProgress" },
                    { 4, 4, 1, 1.54, "InProgress" },
                    { 5, 5, 1, 1.4199999999999999, "InProgress" },
                    { 6, 6, 1, 1.24, "InProgress" },
                    { 7, 1, 2, 3.7400000000000002, "InProgress" },
                    { 8, 2, 2, 1.77, "InProgress" },
                    { 9, 3, 2, 2.3399999999999999, "InProgress" },
                    { 10, 4, 2, 2.1400000000000001, "InProgress" },
                    { 11, 5, 2, 1.4199999999999999, "InProgress" },
                    { 93, 2, 17, 1.77, "InProgress" },
                    { 13, 1, 3, 3.7400000000000002, "InProgress" },
                    { 14, 2, 3, 1.77, "InProgress" },
                    { 15, 3, 3, 2.3399999999999999, "InProgress" },
                    { 16, 4, 3, 2.1400000000000001, "InProgress" },
                    { 17, 5, 3, 1.4199999999999999, "InProgress" },
                    { 18, 6, 3, 1.24, "InProgress" },
                    { 19, 1, 4, 3.7400000000000002, "InProgress" },
                    { 20, 2, 4, 1.77, "InProgress" },
                    { 43, 1, 8, 3.7400000000000002, "InProgress" },
                    { 44, 2, 8, 1.77, "InProgress" },
                    { 12, 6, 2, 1.24, "InProgress" },
                    { 46, 4, 8, 2.1400000000000001, "InProgress" },
                    { 69, 2, 13, 1.77, "InProgress" },
                    { 70, 3, 13, 2.3399999999999999, "InProgress" },
                    { 71, 4, 13, 2.1400000000000001, "InProgress" },
                    { 72, 5, 13, 1.4199999999999999, "InProgress" },
                    { 74, 1, 14, 3.7400000000000002, "InProgress" },
                    { 75, 2, 14, 1.77, "InProgress" },
                    { 76, 3, 14, 2.3399999999999999, "InProgress" },
                    { 77, 4, 14, 2.1400000000000001, "InProgress" },
                    { 79, 6, 14, 1.24, "InProgress" },
                    { 80, 1, 15, 3.7400000000000002, "InProgress" },
                    { 81, 2, 15, 1.77, "InProgress" },
                    { 82, 3, 15, 2.3399999999999999, "InProgress" },
                    { 83, 4, 15, 2.1400000000000001, "InProgress" },
                    { 86, 1, 16, 3.7400000000000002, "InProgress" },
                    { 87, 2, 16, 1.77, "InProgress" },
                    { 88, 3, 16, 2.3399999999999999, "InProgress" },
                    { 89, 4, 16, 2.1400000000000001, "InProgress" },
                    { 91, 6, 16, 1.24, "InProgress" },
                    { 45, 3, 8, 2.3399999999999999, "InProgress" },
                    { 68, 1, 13, 3.7400000000000002, "InProgress" },
                    { 67, 5, 12, 1.4199999999999999, "InProgress" },
                    { 85, 6, 15, 1.24, "InProgress" },
                    { 65, 3, 12, 2.3399999999999999, "InProgress" },
                    { 47, 5, 8, 1.4199999999999999, "InProgress" },
                    { 66, 4, 12, 2.1400000000000001, "InProgress" },
                    { 48, 1, 9, 3.7400000000000002, "InProgress" },
                    { 49, 2, 9, 1.77, "InProgress" },
                    { 51, 4, 9, 2.1400000000000001, "InProgress" },
                    { 52, 5, 9, 1.4199999999999999, "InProgress" },
                    { 53, 1, 10, 3.7400000000000002, "InProgress" },
                    { 54, 2, 10, 1.77, "InProgress" },
                    { 55, 3, 10, 2.3399999999999999, "InProgress" },
                    { 50, 3, 9, 2.3399999999999999, "InProgress" },
                    { 57, 5, 10, 1.4199999999999999, "InProgress" },
                    { 58, 1, 11, 3.7400000000000002, "InProgress" },
                    { 64, 2, 12, 1.77, "InProgress" },
                    { 59, 2, 11, 1.77, "InProgress" },
                    { 60, 3, 11, 2.3399999999999999, "InProgress" },
                    { 61, 4, 11, 2.1400000000000001, "InProgress" },
                    { 62, 5, 11, 1.4199999999999999, "InProgress" },
                    { 56, 4, 10, 2.1400000000000001, "InProgress" },
                    { 63, 1, 12, 3.7400000000000002, "InProgress" }
                });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[,]
                {
                    { 50, 18, false, 0 },
                    { 34, 24, false, 0 },
                    { 33, 24, true, 0 },
                    { 32, 23, false, 0 },
                    { 31, 23, true, 0 },
                    { 28, 22, false, 0 },
                    { 24, 20, false, 0 },
                    { 26, 21, false, 0 },
                    { 25, 21, true, 0 },
                    { 23, 20, true, 0 },
                    { 22, 19, false, 0 },
                    { 35, 25, true, 0 },
                    { 21, 19, true, 0 },
                    { 27, 22, true, 0 },
                    { 36, 25, false, 0 },
                    { 42, 30, true, 0 },
                    { 2, 26, false, 0 },
                    { 2, 33, false, 0 },
                    { 49, 18, true, 0 },
                    { 1, 33, true, 0 },
                    { 31, 32, false, 0 },
                    { 30, 32, true, 0 },
                    { 21, 31, false, 0 },
                    { 1, 26, true, 0 },
                    { 20, 31, true, 0 },
                    { 41, 29, false, 0 },
                    { 44, 29, true, 0 },
                    { 6, 28, false, 0 },
                    { 5, 28, true, 0 },
                    { 4, 27, false, 0 },
                    { 3, 27, true, 0 },
                    { 43, 30, false, 0 },
                    { 48, 17, false, 0 },
                    { 1, 7, true, 0 },
                    { 46, 16, false, 0 },
                    { 3, 34, true, 0 },
                    { 1, 1, true, 0 },
                    { 2, 1, false, 0 },
                    { 3, 2, true, 0 },
                    { 4, 2, false, 0 },
                    { 5, 3, true, 0 },
                    { 6, 3, false, 0 },
                    { 7, 4, true, 0 },
                    { 8, 4, false, 0 },
                    { 3, 5, true, 0 },
                    { 7, 5, false, 0 },
                    { 2, 6, true, 0 },
                    { 6, 6, false, 0 },
                    { 8, 7, false, 0 },
                    { 11, 8, true, 0 },
                    { 12, 8, false, 0 },
                    { 14, 9, true, 0 },
                    { 45, 16, true, 0 },
                    { 44, 15, false, 0 },
                    { 43, 15, true, 0 },
                    { 42, 14, false, 0 },
                    { 41, 14, true, 0 },
                    { 18, 13, false, 0 },
                    { 47, 17, true, 0 },
                    { 17, 13, true, 0 },
                    { 15, 12, true, 0 },
                    { 12, 11, false, 0 },
                    { 11, 11, true, 0 },
                    { 18, 10, false, 0 },
                    { 17, 10, true, 0 },
                    { 12, 9, false, 0 },
                    { 12, 12, false, 0 },
                    { 4, 34, false, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pairs_BetTypeId",
                table: "Pairs",
                column: "BetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pairs_MatchId",
                table: "Pairs",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMatches_MatchId",
                table: "TeamMatches",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPairs_PairId",
                table: "TicketPairs",
                column: "PairId");
        }
    }
}
