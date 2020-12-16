using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc"),
                column: "ConcurrencyStamp",
                value: "f8785ddc-14b6-4d25-ac70-1219fa5316d2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e953781a-de39-459c-a246-9fd5035478e5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b2bbfdd-ec96-4232-9c81-8d67b6268ace", "AQAAAAEAACcQAAAAEE+z+36us3od4lSFISAWBmkR2O2p7+C6xdUYG8T+PKhDI+TSqKpEMSfQeht9qzSxgQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 28, 17, 13, 25, 252, DateTimeKind.Local).AddTicks(8842));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc"),
                column: "ConcurrencyStamp",
                value: "e137f3e1-824f-4296-8a4f-8c1ea176fe52");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e953781a-de39-459c-a246-9fd5035478e5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "110f5987-df46-4672-92fd-fc32f58d2313", "AQAAAAEAACcQAAAAEBhfuIBlp5UpygidcPxnJTqLvgj11j5J0uLQ8jEZkdAysnsslcHF+QwBdW1NDjRZHg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 25, 15, 41, 49, 5, DateTimeKind.Local).AddTicks(5650));
        }
    }
}
