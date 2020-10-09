using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToeicOnline.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(nullable: false),
                    birthday = table.Column<DateTime>(nullable: false),
                    phonenumber = table.Column<int>(nullable: false),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "birthday", "password", "phonenumber", "username" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1974), "123456", 338915243, "tung" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id", "birthday", "password", "phonenumber", "username" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1974), "123456", 338915243, "anhtung" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
