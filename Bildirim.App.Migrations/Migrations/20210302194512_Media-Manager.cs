using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bildirim.App.Migrations.Migrations
{
    public partial class MediaManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_CONTACT");

            migrationBuilder.CreateTable(
                name: "FileType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_MEDIA",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FILE_PATH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FILE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SIZE = table.Column<long>(type: "bigint", nullable: false),
                    FILE_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_MEDIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_MEDIA_FileType_FILE_TYPE_ID",
                        column: x => x.FILE_TYPE_ID,
                        principalTable: "FileType",
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
                columns: new[] { "ADI", "CREATED_DATE" },
                values: new object[] { "Pasif", new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

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
                name: "IX_T_MEDIA_FILE_TYPE_ID",
                table: "T_MEDIA",
                column: "FILE_TYPE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_MEDIA");

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.CreateTable(
                name: "T_CONTACT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MESSAGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAME_SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true),
                    USER_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONTACT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_CONTACT_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_CAMPAIGN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_COUNTRY",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_LOGIN",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "ADI", "CREATED_DATE" },
                values: new object[] { "Silinmiş", new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_NOTIFICATION_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TT_USER_STATUS",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 317, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "T_USER_ROLE",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CREATED_DATE",
                value: new DateTime(2021, 2, 18, 0, 24, 23, 318, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.CreateIndex(
                name: "IX_T_CONTACT_USER_ID",
                table: "T_CONTACT",
                column: "USER_ID");
        }
    }
}
