using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToeicOnline.Migrations
{
    public partial class AddDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "birthday", "password", "phonenumber", "username" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1974), "123456", 338915243, "tranthanhtung" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
