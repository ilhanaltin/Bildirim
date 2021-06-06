using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bildirim.App.Migrations.Migrations
{
    public partial class notificationcolumnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NOTIFY",
                table: "T_USER",
                type: "bit",
                nullable: false,
                defaultValueSql: "1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NOTIFY",
                table: "T_USER");
        }
    }
}
