using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bildirim.App.Migrations.Migrations
{
    public partial class FileTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_MEDIA_FileType_FILE_TYPE_ID",
                table: "T_MEDIA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileType",
                table: "FileType");

            migrationBuilder.RenameTable(
                name: "FileType",
                newName: "TT_FILE");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "TT_FILE",
                newName: "ADI");

            migrationBuilder.AlterColumn<string>(
                name: "ADI",
                table: "TT_FILE",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TT_FILE",
                table: "TT_FILE",
                column: "ID");

            migrationBuilder.InsertData(
                table: "TT_FILE",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Resim", new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 2L, "Video", new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_T_MEDIA_TT_FILE_FILE_TYPE_ID",
                table: "T_MEDIA",
                column: "FILE_TYPE_ID",
                principalTable: "TT_FILE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_MEDIA_TT_FILE_FILE_TYPE_ID",
                table: "T_MEDIA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TT_FILE",
                table: "TT_FILE");

            migrationBuilder.DeleteData(
                table: "TT_FILE",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "TT_FILE",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.RenameTable(
                name: "TT_FILE",
                newName: "FileType");

            migrationBuilder.RenameColumn(
                name: "ADI",
                table: "FileType",
                newName: "Adi");

            migrationBuilder.AlterColumn<string>(
                name: "Adi",
                table: "FileType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileType",
                table: "FileType",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_T_MEDIA_FileType_FILE_TYPE_ID",
                table: "T_MEDIA",
                column: "FILE_TYPE_ID",
                principalTable: "FileType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
