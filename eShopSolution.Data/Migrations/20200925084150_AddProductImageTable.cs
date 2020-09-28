using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 21, 15, 58, 8, 560, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 21, 15, 58, 8, 560, DateTimeKind.Local).AddTicks(2877),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc"),
                column: "ConcurrencyStamp",
                value: "13312888-3b7d-43b6-b1fd-2bd765ba6a5c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e953781a-de39-459c-a246-9fd5035478e5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2fe9b1f-f243-4a36-9d73-f9d0dde9f829", "AQAAAAEAACcQAAAAEAs/z72XVRomWzJ4ArhFpu8KsBJQmVkwaUGvYXN4WejgzijF+GqeafLR3SIWHnbX/Q==" });

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
                value: new DateTime(2020, 9, 21, 15, 58, 8, 578, DateTimeKind.Local).AddTicks(4536));
        }
    }
}
