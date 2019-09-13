using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingApp.Data.Migrations
{
    public partial class ThirdDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndedAt",
                table: "Matches",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { null, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "EndedAt", "IsTopOffer", "SportId", "StartsAt" },
                values: new object[,]
                {
                    { 34, null, false, 1, new DateTime(2019, 9, 10, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, null, false, 1, new DateTime(2019, 9, 10, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, null, true, 4, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, null, true, 3, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, null, true, 2, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, null, true, 1, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, null, true, 1, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, null, true, 1, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, null, true, 2, new DateTime(2019, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Pairs",
                columns: new[] { "Id", "BetTypeId", "MatchId", "Quota", "Status" },
                values: new object[,]
                {
                    { 158, 2, 9, 2.21, "IsFalse" },
                    { 160, 4, 9, 3.02, "IsFalse" },
                    { 159, 3, 9, 2.8799999999999999, "IsCorrect" },
                    { 157, 1, 9, 4.5, "IsCorrect" },
                    { 161, 5, 9, 1.75, "IsFalse" },
                    { 155, 4, 8, 3.02, "IsFalse" },
                    { 154, 3, 8, 2.8799999999999999, "IsCorrect" },
                    { 153, 2, 8, 2.21, "IsFalse" },
                    { 152, 1, 8, 4.5, "IsCorrect" },
                    { 156, 5, 8, 1.75, "IsFalse" }
                });

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 7 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 1 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 6 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 2 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 5 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 4, 2 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 5, 3 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 7, 4 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 7, 5 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 8, 4 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 8, 7 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 11, 8 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 11, 11 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 8 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 9 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 11 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 12 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 14, 9 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 15, 12 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 17, 10 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 17, 13 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 18, 10 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 18, 13 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 21, 19 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 22, 19 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 23, 20 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 24, 20 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 26, 21 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 27, 22 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 28, 22 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 32, 23 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 34, 24 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 36, 25 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 41, 14 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 42, 14 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 43, 15 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 44, 15 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 45, 16 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 46, 16 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 47, 17 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 48, 17 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 49, 18 },
                column: "Score",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 50, 18 },
                column: "Score",
                value: 0);

            migrationBuilder.InsertData(
                table: "Pairs",
                columns: new[] { "Id", "BetTypeId", "MatchId", "Quota", "Status" },
                values: new object[,]
                {
                    { 134, 1, 26, 4.5, "IsCorrect" },
                    { 165, 4, 31, 3.02, "IsFalse" },
                    { 166, 6, 31, 1.54, "IsCorrect" },
                    { 167, 1, 32, 4.5, "IsFalse" },
                    { 168, 2, 32, 2.21, "IsCorrect" },
                    { 169, 3, 32, 2.8799999999999999, "IsFalse" },
                    { 170, 4, 32, 3.02, "IsCorrect" },
                    { 171, 5, 32, 1.75, "IsFalse" },
                    { 172, 6, 32, 1.54, "IsCorrect" },
                    { 173, 1, 33, 3.7400000000000002, "InProgress" },
                    { 164, 3, 31, 2.8799999999999999, "IsCorrect" },
                    { 174, 2, 33, 1.77, "InProgress" },
                    { 176, 4, 33, 3.02, "InProgress" },
                    { 177, 5, 33, 1.75, "InProgress" },
                    { 178, 6, 33, 1.54, "InProgress" },
                    { 179, 1, 34, 3.7400000000000002, "InProgress" },
                    { 180, 2, 34, 1.77, "InProgress" },
                    { 181, 3, 34, 2.3399999999999999, "InProgress" },
                    { 182, 4, 34, 3.02, "InProgress" },
                    { 183, 5, 34, 1.75, "InProgress" },
                    { 184, 6, 34, 1.54, "InProgress" },
                    { 175, 3, 33, 2.3399999999999999, "InProgress" },
                    { 162, 1, 31, 4.5, "IsCorrect" },
                    { 163, 2, 31, 2.21, "IsFalse" },
                    { 142, 3, 27, 2.8799999999999999, "IsCorrect" },
                    { 141, 2, 27, 2.21, "IsFalse" },
                    { 146, 1, 28, 4.5, "IsCorrect" },
                    { 147, 2, 28, 2.21, "IsFalse" },
                    { 148, 3, 28, 2.8799999999999999, "IsCorrect" },
                    { 143, 4, 27, 3.02, "IsFalse" },
                    { 144, 5, 27, 1.75, "IsFalse" },
                    { 140, 1, 27, 4.5, "IsCorrect" },
                    { 149, 4, 28, 3.02, "IsFalse" },
                    { 151, 6, 28, 1.54, "IsCorrect" },
                    { 139, 6, 26, 1.54, "IsCorrect" },
                    { 138, 5, 26, 1.75, "IsFalse" },
                    { 137, 4, 26, 3.02, "IsFalse" },
                    { 136, 3, 26, 2.8799999999999999, "IsCorrect" },
                    { 135, 2, 26, 2.21, "IsFalse" },
                    { 150, 5, 28, 1.75, "IsFalse" },
                    { 145, 6, 27, 1.54, "IsCorrect" }
                });

            migrationBuilder.InsertData(
                table: "TeamMatches",
                columns: new[] { "TeamId", "MatchId", "IsHome", "Score" },
                values: new object[,]
                {
                    { 2, 33, false, 0 },
                    { 1, 33, true, 0 },
                    { 1, 26, true, 0 },
                    { 2, 26, false, 0 },
                    { 40, 29, true, 0 },
                    { 30, 32, true, 0 },
                    { 6, 28, false, 0 },
                    { 3, 27, true, 0 },
                    { 4, 27, false, 0 },
                    { 21, 31, false, 0 },
                    { 20, 31, true, 0 },
                    { 3, 34, true, 0 },
                    { 5, 28, true, 0 },
                    { 43, 30, false, 0 },
                    { 42, 30, true, 0 },
                    { 41, 29, false, 0 },
                    { 31, 32, false, 0 },
                    { 4, 34, false, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Pairs",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 26 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 33 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 6, 28 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 20, 31 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 21, 31 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 30, 32 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 31, 32 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 40, 29 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 41, 29 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 42, 30 });

            migrationBuilder.DeleteData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 43, 30 });

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndedAt",
                table: "Matches",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 11, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndedAt", "StartsAt" },
                values: new object[] { new DateTime(2019, 9, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 13, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 1, 7 },
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 1 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 2, 6 },
                column: "Score",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 2 },
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 3, 5 },
                column: "Score",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 4, 2 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 5, 3 },
                column: "Score",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 7, 4 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 7, 5 },
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 8, 4 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 8, 7 },
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 11, 8 },
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 11, 11 },
                column: "Score",
                value: 27);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 8 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 9 },
                column: "Score",
                value: 24);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 11 },
                column: "Score",
                value: 24);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 12, 12 },
                column: "Score",
                value: 22);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 14, 9 },
                column: "Score",
                value: 20);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 15, 12 },
                column: "Score",
                value: 18);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 17, 10 },
                column: "Score",
                value: 26);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 17, 13 },
                column: "Score",
                value: 25);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 18, 10 },
                column: "Score",
                value: 33);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 18, 13 },
                column: "Score",
                value: 17);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 21, 19 },
                column: "Score",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 22, 19 },
                column: "Score",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 23, 20 },
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 24, 20 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 26, 21 },
                column: "Score",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 27, 22 },
                column: "Score",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 28, 22 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 32, 23 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 34, 24 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 36, 25 },
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 41, 14 },
                column: "Score",
                value: 37);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 42, 14 },
                column: "Score",
                value: 31);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 43, 15 },
                column: "Score",
                value: 27);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 44, 15 },
                column: "Score",
                value: 32);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 45, 16 },
                column: "Score",
                value: 45);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 46, 16 },
                column: "Score",
                value: 35);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 47, 17 },
                column: "Score",
                value: 32);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 48, 17 },
                column: "Score",
                value: 33);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 49, 18 },
                column: "Score",
                value: 26);

            migrationBuilder.UpdateData(
                table: "TeamMatches",
                keyColumns: new[] { "TeamId", "MatchId" },
                keyValues: new object[] { 50, 18 },
                column: "Score",
                value: 35);
        }
    }
}
