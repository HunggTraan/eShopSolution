using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 21, 15, 58, 8, 560, DateTimeKind.Local).AddTicks(2877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 21, 15, 41, 53, 860, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc"), "13312888-3b7d-43b6-b1fd-2bd765ba6a5c", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("e953781a-de39-459c-a246-9fd5035478e5"), new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e953781a-de39-459c-a246-9fd5035478e5"), 0, "f2fe9b1f-f243-4a36-9d73-f9d0dde9f829", new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanhung30121998@gmail.com", true, "Hung", "Tran", false, null, "tuanhung30121998@gmail.com", "admin", "AQAAAAEAACcQAAAAEAs/z72XVRomWzJ4ArhFpu8KsBJQmVkwaUGvYXN4WejgzijF+GqeafLR3SIWHnbX/Q==", null, false, "", false, "admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("e953781a-de39-459c-a246-9fd5035478e5"), new Guid("36e2e33f-7136-4652-b5b6-9873ca6310cc") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e953781a-de39-459c-a246-9fd5035478e5"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 21, 15, 41, 53, 860, DateTimeKind.Local).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 21, 15, 58, 8, 560, DateTimeKind.Local).AddTicks(2877));

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
                value: new DateTime(2020, 9, 21, 15, 41, 53, 878, DateTimeKind.Local).AddTicks(638));
        }
    }
}
