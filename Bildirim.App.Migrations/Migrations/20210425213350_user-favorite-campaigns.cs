using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bildirim.App.Migrations.Migrations
{
    public partial class userfavoritecampaigns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_USER_FAVORITE_NOTIFICATIONS");

            migrationBuilder.CreateTable(
                name: "T_USER_FAVORITE_CATEGORIES",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    SECTOR_ID = table.Column<long>(type: "bigint", nullable: false),
                    BRAND_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_FAVORITE_CATEGORIES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_USER_FAVORITE_CATEGORIES_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_USER_FAVORITE_CATEGORIES_TT_BRAND_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "TT_BRAND",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_USER_FAVORITE_CATEGORIES_TT_SECTOR_SECTOR_ID",
                        column: x => x.SECTOR_ID,
                        principalTable: "TT_SECTOR",
                        principalColumn: "ID");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_CATEGORIES_BRAND_ID",
                table: "T_USER_FAVORITE_CATEGORIES",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_CATEGORIES_SECTOR_ID",
                table: "T_USER_FAVORITE_CATEGORIES",
                column: "SECTOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_CATEGORIES_USER_ID",
                table: "T_USER_FAVORITE_CATEGORIES",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_USER_FAVORITE_CATEGORIES");

            migrationBuilder.CreateTable(
                name: "T_USER_FAVORITE_NOTIFICATIONS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    NOTIFICATION_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_FAVORITE_NOTIFICATIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_USER_FAVORITE_NOTIFICATIONS_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_USER_FAVORITE_NOTIFICATIONS_TT_NOTIFICATION_NOTIFICATION_TYPE_ID",
                        column: x => x.NOTIFICATION_TYPE_ID,
                        principalTable: "TT_NOTIFICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 361, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 3, 2, 22, 45, 10, 362, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_NOTIFICATIONS_NOTIFICATION_TYPE_ID",
                table: "T_USER_FAVORITE_NOTIFICATIONS",
                column: "NOTIFICATION_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_NOTIFICATIONS_USER_ID",
                table: "T_USER_FAVORITE_NOTIFICATIONS",
                column: "USER_ID");
        }
    }
}
