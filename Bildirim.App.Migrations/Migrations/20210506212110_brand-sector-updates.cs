using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bildirim.App.Migrations.Migrations
{
    public partial class brandsectorupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IMAGE",
                table: "TT_SECTOR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KISA_ADI",
                table: "TT_SECTOR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMAGE",
                table: "TT_BRAND",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KISA_ADI",
                table: "TT_BRAND",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 76, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 5, 7, 0, 21, 9, 77, DateTimeKind.Local).AddTicks(133));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMAGE",
                table: "TT_SECTOR");

            migrationBuilder.DropColumn(
                name: "KISA_ADI",
                table: "TT_SECTOR");

            migrationBuilder.DropColumn(
                name: "IMAGE",
                table: "TT_BRAND");

            migrationBuilder.DropColumn(
                name: "KISA_ADI",
                table: "TT_BRAND");

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 4, 26, 0, 33, 48, 911, DateTimeKind.Local).AddTicks(6842));
        }
    }
}
