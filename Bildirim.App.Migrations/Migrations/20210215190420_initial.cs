using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bildirim.App.Migrations.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_USER_VERIFICATION",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    TOKEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACTIVE = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_VERIFICATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_CAMPAIGN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_CAMPAIGN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_COUNTRY",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_COUNTRY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_LOGIN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_LOGIN", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_NOTIFICATION",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_NOTIFICATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_NOTIFICATION_STATUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_NOTIFICATION_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_ROLE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_USER_STATUS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_USER_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TT_BRAND",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COUNTRY_ID = table.Column<long>(type: "bigint", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_BRAND", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TT_BRAND_TT_COUNTRY_COUNTRY_ID",
                        column: x => x.COUNTRY_ID,
                        principalTable: "TT_COUNTRY",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TT_CITY",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COUNTRY_ID = table.Column<long>(type: "bigint", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_CITY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TT_CITY_TT_COUNTRY_COUNTRY_ID",
                        column: x => x.COUNTRY_ID,
                        principalTable: "TT_COUNTRY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TT_SECTOR",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COUNTRY_ID = table.Column<long>(type: "bigint", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_SECTOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TT_SECTOR_TT_COUNTRY_COUNTRY_ID",
                        column: x => x.COUNTRY_ID,
                        principalTable: "TT_COUNTRY",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "T_USER",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NICKNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USER_LOGIN_TYPE_ID = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    SOCIAL_MEDIA_USER_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_STATUS_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    IS_BLOCKED = table.Column<bool>(type: "bit", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_USER_TT_LOGIN_USER_LOGIN_TYPE_ID",
                        column: x => x.USER_LOGIN_TYPE_ID,
                        principalTable: "TT_LOGIN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_USER_TT_USER_STATUS_USER_STATUS_TYPE_ID",
                        column: x => x.USER_STATUS_TYPE_ID,
                        principalTable: "TT_USER_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TT_COUNTY",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CITY_ID = table.Column<long>(type: "bigint", nullable: false),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_COUNTY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TT_COUNTY_TT_CITY_CITY_ID",
                        column: x => x.CITY_ID,
                        principalTable: "TT_CITY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_CONTACT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: true),
                    NAME_SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MESSAGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "T_LOGIN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    SESSION_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LOGGED_IN = table.Column<bool>(type: "bit", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_LOGIN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_LOGIN_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_FAVORITE_NOTIFICATIONS",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    NOTIFICATION_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "T_USER_ROLE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    ROLE_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_ROLE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_USER_ROLE_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_USER_ROLE_TT_ROLE_ROLE_TYPE_ID",
                        column: x => x.ROLE_TYPE_ID,
                        principalTable: "TT_ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_NOTIFICATION",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOTIFICATION_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    NOTIFICATION_STATUS_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    READ_COUNT = table.Column<int>(type: "int", nullable: false),
                    COUNTRY_ID = table.Column<long>(type: "bigint", nullable: false),
                    CITY_ID = table.Column<long>(type: "bigint", nullable: true),
                    COUNTY_ID = table.Column<long>(type: "bigint", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_NOTIFICATION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_TT_CITY_CITY_ID",
                        column: x => x.CITY_ID,
                        principalTable: "TT_CITY",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_TT_COUNTRY_COUNTRY_ID",
                        column: x => x.COUNTRY_ID,
                        principalTable: "TT_COUNTRY",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_TT_COUNTY_COUNTY_ID",
                        column: x => x.COUNTY_ID,
                        principalTable: "TT_COUNTY",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_TT_NOTIFICATION_NOTIFICATION_TYPE_ID",
                        column: x => x.NOTIFICATION_TYPE_ID,
                        principalTable: "TT_NOTIFICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_TT_NOTIFICATION_STATUS_NOTIFICATION_STATUS_TYPE_ID",
                        column: x => x.NOTIFICATION_STATUS_TYPE_ID,
                        principalTable: "TT_NOTIFICATION_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_CAMPAIGN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOTIFICATION_ID = table.Column<long>(type: "bigint", nullable: false),
                    CAMPAIGN_TYPE_ID = table.Column<long>(type: "bigint", nullable: false),
                    DETAIL_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAIN_IMAGE_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOGO_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICON_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    START_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    END_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BONUS_VALIDITY_START_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BONUS_VALIDITY_END_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DETAIL_TEXT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OWNER_BRAND_ID = table.Column<long>(type: "bigint", nullable: false),
                    BRAND_ID = table.Column<long>(type: "bigint", nullable: true),
                    SECTOR_ID = table.Column<long>(type: "bigint", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CAMPAIGN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_CAMPAIGN_T_NOTIFICATION_NOTIFICATION_ID",
                        column: x => x.NOTIFICATION_ID,
                        principalTable: "T_NOTIFICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_CAMPAIGN_TT_BRAND_BRAND_ID",
                        column: x => x.BRAND_ID,
                        principalTable: "TT_BRAND",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_CAMPAIGN_TT_BRAND_OWNER_BRAND_ID",
                        column: x => x.OWNER_BRAND_ID,
                        principalTable: "TT_BRAND",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_CAMPAIGN_TT_CAMPAIGN_CAMPAIGN_TYPE_ID",
                        column: x => x.CAMPAIGN_TYPE_ID,
                        principalTable: "TT_CAMPAIGN",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_T_CAMPAIGN_TT_SECTOR_SECTOR_ID",
                        column: x => x.SECTOR_ID,
                        principalTable: "TT_SECTOR",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "T_NOTIFICATION_VOTE",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    NOTIFICATION_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_USER = table.Column<long>(type: "bigint", nullable: false),
                    UPDATED_USER = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_NOTIFICATION_VOTE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_VOTE_T_NOTIFICATION_NOTIFICATION_ID",
                        column: x => x.NOTIFICATION_ID,
                        principalTable: "T_NOTIFICATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_NOTIFICATION_VOTE_T_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "T_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TT_CAMPAIGN",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Bireysel", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 2L, "Ticari", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTRY",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Türkiye", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 2L, "Amerika", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 3L, "Almanya", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_LOGIN",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 3L, "Facebook", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 2L, "Google", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 1L, "Normal", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_NOTIFICATION",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[] { 1L, "Kampanya", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null });

            migrationBuilder.InsertData(
                table: "TT_NOTIFICATION_STATUS",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "ParentId", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 3L, "Onaylandı", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, 0, null, null },
                    { 2L, "Onay Bekliyor", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, 0, null, null },
                    { 1L, "Silinmiş", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_ROLE",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Yönetici", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 2L, "Üye", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_USER_STATUS",
                columns: new[] { "ID", "ADI", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Aktif", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 2L, "Silinmiş", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 3L, "Kara Listede", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null },
                    { 4L, "Aktivasyon Bekliyor", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 1L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_CITY",
                columns: new[] { "ID", "ADI", "COUNTRY_ID", "CREATED_DATE", "CREATED_USER", "Kod", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Adana", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 1, null, null },
                    { 60L, "Tokat", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 60, null, null },
                    { 59L, "Tekirdağ", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 59, null, null },
                    { 58L, "Sivas", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 58, null, null },
                    { 57L, "Sinop", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 57, null, null },
                    { 56L, "Siirt", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 56, null, null },
                    { 55L, "Samsun", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 55, null, null },
                    { 54L, "Sakarya", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 54, null, null },
                    { 61L, "Trabzon", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 61, null, null },
                    { 53L, "Rize", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 53, null, null },
                    { 51L, "Niğde", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 51, null, null },
                    { 50L, "Nevşehir", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 50, null, null },
                    { 49L, "Muş", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 49, null, null },
                    { 48L, "Muğla", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 48, null, null },
                    { 47L, "Mardin", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 47, null, null },
                    { 45L, "Manisa", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 45, null, null },
                    { 44L, "Malatya", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 44, null, null },
                    { 52L, "Ordu", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 52, null, null },
                    { 62L, "Tunceli", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 62, null, null },
                    { 63L, "Şanlıurfa", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 63, null, null },
                    { 64L, "Uşak", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 64, null, null },
                    { 81L, "Düzce", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 81, null, null },
                    { 80L, "Osmaniye", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 80, null, null },
                    { 79L, "Kilis", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 79, null, null },
                    { 78L, "Karabük", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 78, null, null },
                    { 77L, "Yalova", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 77, null, null },
                    { 76L, "Iğdır", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 76, null, null },
                    { 75L, "Ardahan", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 75, null, null },
                    { 74L, "Bartın", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 74, null, null },
                    { 73L, "Şırnak", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 73, null, null },
                    { 72L, "Batman", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 72, null, null },
                    { 71L, "Kırıkkale", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 71, null, null },
                    { 70L, "Karaman", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 70, null, null },
                    { 69L, "Bayburt", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 69, null, null },
                    { 68L, "Aksaray", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 68, null, null },
                    { 67L, "Zonguldak", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 67, null, null },
                    { 66L, "Yozgat", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 66, null, null },
                    { 65L, "Van", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 65, null, null },
                    { 43L, "Kütahya", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 43, null, null },
                    { 42L, "Konya", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 42, null, null },
                    { 46L, "Kahramanmaraş", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 46, null, null },
                    { 40L, "Kırşehir", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 40, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_CITY",
                columns: new[] { "ID", "ADI", "COUNTRY_ID", "CREATED_DATE", "CREATED_USER", "Kod", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 18L, "Çankırı", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 18, null, null },
                    { 41L, "Kocaeli", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 41, null, null },
                    { 16L, "Bursa", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 16, null, null },
                    { 15L, "Burdur", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 15, null, null },
                    { 14L, "Bolu", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 14, null, null },
                    { 13L, "Bitlis", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 13, null, null },
                    { 12L, "Bingöl", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 12, null, null },
                    { 11L, "Bilecik", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 11, null, null },
                    { 10L, "Balıkesir", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 10, null, null },
                    { 9L, "Aydın", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 9, null, null },
                    { 8L, "Artvin", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 8, null, null },
                    { 7L, "Antalya", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 7, null, null },
                    { 6L, "Ankara", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 6, null, null },
                    { 5L, "Amasya", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 5, null, null },
                    { 4L, "Ağrı", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 4, null, null },
                    { 3L, "Afyon", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 3, null, null },
                    { 2L, "Adıyaman", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 2, null, null },
                    { 19L, "Çorum", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 19, null, null },
                    { 20L, "Denizli", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 20, null, null },
                    { 17L, "Çanakkale", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 17, null, null },
                    { 22L, "Edirne", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 22, null, null },
                    { 39L, "Kırklareli", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 39, null, null },
                    { 38L, "Kayseri", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 38, null, null },
                    { 37L, "Kastamonu", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 37, null, null },
                    { 21L, "Diyarbakır", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 21, null, null },
                    { 35L, "İzmir", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 35, null, null },
                    { 34L, "İstanbul", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 34, null, null },
                    { 33L, "İçel", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 33, null, null },
                    { 32L, "Isparta", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 32, null, null },
                    { 36L, "Kars", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 36, null, null },
                    { 30L, "Hakkari", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 30, null, null },
                    { 29L, "Gümüşhane", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 29, null, null },
                    { 28L, "Giresun", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 28, null, null },
                    { 27L, "Gaziantep", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 27, null, null },
                    { 26L, "Eskişehir", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 26, null, null },
                    { 25L, "Erzurum", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 25, null, null },
                    { 24L, "Erzincan", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 24, null, null },
                    { 23L, "Elazığ", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 23, null, null },
                    { 31L, "Hatay", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, 31, null, null }
                });

            migrationBuilder.InsertData(
                table: "T_USER",
                columns: new[] { "ID", "CREATED_DATE", "CREATED_USER", "EMAIL", "IS_BLOCKED", "LASTNAME", "NAME", "NICKNAME", "PASSWORD", "SOCIAL_MEDIA_USER_ID", "UPDATED_DATE", "UPDATED_USER", "USER_LOGIN_TYPE_ID", "USER_STATUS_TYPE_ID" },
                values: new object[,]
                {
                    { 8L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8513), 1L, "mermeresican@gmail.com", false, "MERMER", "Ömer", "mermeromer", "6d071901727aec1ba6d8e2497ef5b709", null, null, null, 1L, 1L },
                    { 7L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8508), 1L, "hasduruyi@outlook.com.tr", false, "DURUYI", "HAS", "HASDURUYI", "6c6e2722c24fd0c5d5153732c0776830", null, null, null, 1L, 1L },
                    { 6L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8449), 1L, "metinolyavrum@gmail.com", false, "OLYAVRUM", "METIN", "SenBen", "9456066bcb14f5c1fa388fda6310f38f", null, null, null, 1L, 1L }
                });

            migrationBuilder.InsertData(
                table: "T_USER",
                columns: new[] { "ID", "CREATED_DATE", "CREATED_USER", "EMAIL", "IS_BLOCKED", "LASTNAME", "NAME", "NICKNAME", "PASSWORD", "SOCIAL_MEDIA_USER_ID", "UPDATED_DATE", "UPDATED_USER", "USER_LOGIN_TYPE_ID", "USER_STATUS_TYPE_ID" },
                values: new object[,]
                {
                    { 5L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8445), 1L, "katanasapi@gmail.com", false, "SAPI", "KATANA", "katanasapi", "ad9187d4c31d650f97bbfecb52189053", null, null, null, 1L, 1L },
                    { 1L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(6474), 1L, "ilhanaltin@gmail.com", false, "ALTIN", "İlhan", "ilhanaltin", "e44f5f0bf7a453a731217f288641ab16", null, null, null, 1L, 1L },
                    { 3L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8437), 1L, "alivelikonya@gmail.com", false, "KONYA", "Ali Veli", "alivelikonya", "e44f5f0bf7a453a731217f288641ab16", null, null, null, 1L, 1L },
                    { 2L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8427), 1L, "yya@gmail.com", false, "ALTIN", "Yiğityürek", "yigit", "e44f5f0bf7a453a731217f288641ab16", null, null, null, 1L, 1L },
                    { 9L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8517), 1L, "hacilarageldik@gmail.com", false, "BABATEKKESI", "HACI", "ozontabakasi", "ad9187d4c31d650f97bbfecb52189053", "111423556560295556670", null, null, 2L, 1L },
                    { 4L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8440), 1L, "kocahmet@msn.com", false, "KOÇ", "Ahmet", "kocero", "e44f5f0bf7a453a731217f288641ab16", null, null, null, 1L, 1L },
                    { 10L, new DateTime(2021, 2, 15, 22, 4, 18, 814, DateTimeKind.Local).AddTicks(8521), 1L, "yellenenfiravun@gmail.com", false, "YELLENIR", "Firavun", "yellos", "64fead8f0a346037b7d1f3247fffa33d", null, null, null, 1L, 1L }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 1L, "Aladağ", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 646L, "Türkoğlu", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 647L, "Çağlayancerit", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 648L, "Ekinözü", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 649L, "Nurhak", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 650L, "Dulkadiroğlu", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 651L, "Onikişubat", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 652L, "Derik", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 653L, "Kızıltepe", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 654L, "Mazıdağı", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 655L, "Midyat", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 656L, "Nusaybin", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 657L, "Ömerli", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 645L, "Pazarcık", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 658L, "Savur", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 660L, "Yeşilli", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 661L, "Artuklu", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 662L, "Bodrum", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 663L, "Datça", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 664L, "Fethiye", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 665L, "Köyceğiz", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 666L, "Marmaris", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 667L, "Milas", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 668L, "Ula", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 669L, "Yatağan", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 670L, "Dalaman", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 671L, "Ortaca", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 659L, "Dargeçit", 47L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 672L, "Kavaklıdere", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 644L, "Göksun", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 642L, "Andırın", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 616L, "Hekimhan", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 617L, "Pütürge", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 618L, "Yeşilyurt", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 619L, "Battalgazi", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 620L, "Doğanyol", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 621L, "Kale", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 622L, "Kuluncak", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 623L, "Yazıhan", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 624L, "Akhisar", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 625L, "Alaşehir", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 626L, "Demirci", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 627L, "Gördes", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 643L, "Elbistan", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 628L, "Kırkağaç", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 630L, "Salihli", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 631L, "Sarıgöl", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 632L, "Saruhanlı", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 633L, "Selendi", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 634L, "Soma", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 635L, "Turgutlu", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 636L, "Ahmetli", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 637L, "Gölmarmara", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 638L, "Köprübaşı", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 639L, "Şehzadeler", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 640L, "Yunusemre", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 641L, "Afşin", 46L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 629L, "Kula", 45L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 673L, "Menteşe", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 674L, "Seydikemer", 48L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 675L, "Bulanık", 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 707L, "Çamaş", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 708L, "Çatalpınar", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 709L, "Çaybaşı", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 710L, "İkizce", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 711L, "Kabadüz", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 712L, "Kabataş", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 713L, "Altınordu", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 714L, "Ardeşen", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 715L, "Çamlıhemşin", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 716L, "Çayeli", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 717L, "Fındıklı", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 718L, "İkizdere", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 706L, "Gürgentepe", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 719L, "Kalkandere", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 721L, "Merkez", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 722L, "Güneysu", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 723L, "Derepazarı", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 724L, "Hemşin", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 725L, "İyidere", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 726L, "Akyazı", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 727L, "Geyve", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 728L, "Hendek", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 729L, "Karasu", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 730L, "Kaynarca", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 731L, "Sapanca", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 732L, "Kocaali", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 720L, "Pazar", 53L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 705L, "Gülyalı", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 704L, "Ünye", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 703L, "Ulubey", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 676L, "Malazgirt", 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 677L, "Merkez", 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 678L, "Varto", 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 679L, "Hasköy", 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 680L, "Korkut", 49L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 681L, "Avanos", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 682L, "Derinkuyu", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 683L, "Gülşehir", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 684L, "Hacıbektaş", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 685L, "Kozaklı", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 686L, "Merkez", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 687L, "Ürgüp", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 688L, "Acıgöl", 50L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 689L, "Bor", 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 690L, "Çamardı", 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 691L, "Merkez", 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 692L, "Ulukışla", 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 693L, "Altunhisar", 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 694L, "Çiftlik", 51L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 695L, "Akkuş", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 696L, "Aybastı", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 697L, "Fatsa", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 698L, "Gölköy", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 699L, "Korgan", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 700L, "Kumru", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 701L, "Mesudiye", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 702L, "Perşembe", 52L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 615L, "Doğanşehir", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 733L, "Pamukova", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 614L, "Darende", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 612L, "Arapgir", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 525L, "Develi", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 526L, "Felahiye", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 527L, "İncesu", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 528L, "Pınarbaşı", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 529L, "Sarıoğlan", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 530L, "Sarız", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 531L, "Tomarza", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 532L, "Yahyalı", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 533L, "Yeşilhisar", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 534L, "Akkışla", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 535L, "Talas", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 536L, "Kocasinan", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 524L, "Bünyan", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 537L, "Melikgazi", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 539L, "Özvatan", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 540L, "Babaeski", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 541L, "Demirköy", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 542L, "Merkez", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 543L, "Kofçaz", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 544L, "Lüleburgaz", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 545L, "Pehlivanköy", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 546L, "Pınarhisar", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 547L, "Vize", 39L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 548L, "Çiçekdağı", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 549L, "Kaman", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 550L, "Merkez", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 538L, "Hacılar", 38L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 551L, "Mucur", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 523L, "Seydiler", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 521L, "Doğanyurt", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 494L, "Bayraklı", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 495L, "Karabağlar", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 497L, "Digor", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 498L, "Kağızman", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 499L, "Merkez", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 500L, "Sarıkamış", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 501L, "Selim", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 502L, "Susuz", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 503L, "Akyaka", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 504L, "Abana", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 505L, "Araç", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 506L, "Azdavay", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 522L, "Hanönü", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 507L, "Bozkurt", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 509L, "Çatalzeytin", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 510L, "Daday", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 511L, "Devrekani", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 512L, "İnebolu", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 513L, "Merkez", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 514L, "Küre", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 515L, "Taşköprü", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 516L, "Tosya", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 517L, "İhsangazi", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 518L, "Pınarbaşı", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 519L, "Şenpazar", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 520L, "Ağlı", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 508L, "Cide", 37L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 552L, "Akpınar", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 553L, "Akçakent", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 554L, "Boztepe", 40L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 586L, "Karatay", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 587L, "Meram", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 588L, "Selçuklu", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 589L, "Taşkent", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 590L, "Ahırlı", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 591L, "Çeltik", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 592L, "Derbent", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 593L, "Emirgazi", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 594L, "Güneysınır", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 595L, "Halkapınar", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 596L, "Tuzlukçu", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 597L, "Yalıhüyük", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 585L, "Hüyük", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 598L, "Altıntaş", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 600L, "Emet", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 601L, "Gediz", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 602L, "Merkez", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 603L, "Simav", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 604L, "Tavşanlı", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 605L, "Aslanapa", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 606L, "Dumlupınar", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 607L, "Hisarcık", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 608L, "Şaphane", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 609L, "Çavdarhisar", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 610L, "Pazarlar", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 611L, "Akçadağ", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 599L, "Domaniç", 43L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 584L, "Derebucak", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 583L, "Altınekin", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 582L, "Akören", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 555L, "Gebze", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 556L, "Gölcük", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 557L, "Kandıra", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 558L, "Karamürsel", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 559L, "Körfez", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 560L, "Derince", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 561L, "Başiskele", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 562L, "Çayırova", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 563L, "Darıca", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 564L, "Dilovası", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 565L, "İzmit", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 566L, "Kartepe", 41L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 567L, "Akşehir", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 568L, "Beyşehir", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 569L, "Bozkır", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 570L, "Cihanbeyli", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 571L, "Çumra", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 572L, "Doğanhisar", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 573L, "Ereğli", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 574L, "Hadim", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 575L, "Ilgın", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 576L, "Kadınhanı", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 577L, "Karapınar", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 578L, "Kulu", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 579L, "Sarayönü", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 580L, "Seydişehir", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 581L, "Yunak", 42L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 613L, "Arguvan", 44L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 493L, "Güzelbahçe", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 734L, "Taraklı", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 736L, "Karapürçek", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 888L, "Ereğli", 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 889L, "Merkez", 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 890L, "Alaplı", 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 891L, "Gökçebey", 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 51L, "Ağaçören", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 52L, "Merkez", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 53L, "Eskil", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 54L, "Gülağaç", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 55L, "Güzelyurt", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 56L, "Ortaköy", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 57L, "Sarıyahşi", 68L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 892L, "Merkez", 69L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 887L, "Devrek", 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 893L, "Aydıntepe", 69L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 895L, "Ermenek", 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 896L, "Merkez", 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 897L, "Ayrancı", 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 898L, "Kazımkarabekir", 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 899L, "Başyayla", 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 900L, "Sarıveliler", 70L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 901L, "Delice", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 902L, "Keskin", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 903L, "Merkez", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 904L, "Sulakyurt", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 905L, "Bahşili", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 906L, "Balışeyh", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 894L, "Demirözü", 69L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 907L, "Çelebi", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 886L, "Çaycuma", 67L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 884L, "Saraykent", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 858L, "Merkez", 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 859L, "Başkale", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 860L, "Çatak", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 861L, "Erciş", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 862L, "Gevaş", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 863L, "Gürpınar", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 864L, "Muradiye", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 865L, "Özalp", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 866L, "Bahçesaray", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 867L, "Çaldıran", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 868L, "Edremit", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 869L, "Saray", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 885L, "Yenifakılı", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 870L, "İpekyolu", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 872L, "Akdağmadeni", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 873L, "Boğazlıyan", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 874L, "Çayıralan", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 875L, "Çekerek", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 876L, "Sarıkaya", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 877L, "Sorgun", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 878L, "Şefaatli", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 879L, "Yerköy", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 880L, "Merkez", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 881L, "Aydıncık", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 882L, "Çandır", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 883L, "Kadışehri", 66L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 871L, "Tuşba", 65L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 908L, "Karakeçili", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 909L, "Yahşihan", 71L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 910L, "Merkez", 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 942L, "Termal", 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 943L, "Eflani", 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 944L, "Eskipazar", 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 945L, "Merkez", 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 946L, "Ovacık", 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 947L, "Safranbolu", 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 948L, "Yenice", 78L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 949L, "Merkez", 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 950L, "Elbeyli", 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 951L, "Musabeyli", 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 952L, "Polateli", 79L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 953L, "Bahçe", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 941L, "Çiftlikköy", 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 954L, "Kadirli", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 956L, "Düziçi", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 957L, "Hasanbeyli", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 958L, "Sumbas", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 959L, "Toprakkale", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 960L, "Akçakoca", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 961L, "Merkez", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 962L, "Yığılca", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 963L, "Cumayeri", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 964L, "Gölyaka", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 965L, "Çilimli", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 966L, "Gümüşova", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 967L, "Kaynaşlı", 81L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 955L, "Merkez", 80L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 940L, "Çınarcık", 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 939L, "Armutlu", 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 938L, "Altınova", 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 911L, "Beşiri", 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 912L, "Gercüş", 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 913L, "Kozluk", 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 914L, "Sason", 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 915L, "Hasankeyf", 72L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 916L, "Beytüşşebap", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 917L, "Cizre", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 918L, "İdil", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 919L, "Silopi", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 920L, "Merkez", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 921L, "Uludere", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 922L, "Güçlükonak", 73L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 923L, "Merkez", 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 924L, "Kurucaşile", 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 925L, "Ulus", 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 926L, "Amasra", 74L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 927L, "Merkez", 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 928L, "Çıldır", 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 929L, "Göle", 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 930L, "Hanak", 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 931L, "Posof", 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 932L, "Damal", 75L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 933L, "Aralık", 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 934L, "Merkez", 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 935L, "Tuzluca", 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 936L, "Karakoyunlu", 76L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 937L, "Merkez", 77L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 857L, "Ulubey", 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 735L, "Ferizli", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 856L, "Sivaslı", 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 854L, "Eşme", 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 767L, "Boyabat", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 768L, "Durağan", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 769L, "Erfelek", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 770L, "Gerze", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 771L, "Merkez", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 772L, "Türkeli", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 773L, "Dikmen", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 774L, "Saraydüzü", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 775L, "Divriği", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 776L, "Gemerek", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 777L, "Gürün", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 778L, "Hafik", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 766L, "Ayancık", 57L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 779L, "İmranlı", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 781L, "Koyulhisar", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 782L, "Merkez", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 783L, "Suşehri", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 784L, "Şarkışla", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 785L, "Yıldızeli", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 786L, "Zara", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 787L, "Akıncılar", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 788L, "Altınyayla", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 789L, "Doğanşar", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 790L, "Gölova", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 791L, "Ulaş", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 792L, "Çerkezköy", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 780L, "Kangal", 58L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 793L, "Çorlu", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 765L, "Tillo", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 763L, "Merkez", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 737L, "Söğütlü", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 738L, "Adapazarı", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 739L, "Arifiye", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 740L, "Erenler", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 741L, "Serdivan", 54L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 742L, "Alaçam", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 743L, "Bafra", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 744L, "Çarşamba", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 745L, "Havza", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 746L, "Kavak", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 747L, "Ladik", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 748L, "Terme", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 764L, "Şirvan", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 749L, "Vezirköprü", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 751L, "19 Mayıs", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 752L, "Salıpazarı", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 753L, "Tekkeköy", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 754L, "Ayvacık", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 755L, "Yakakent", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 756L, "Atakum", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 757L, "Canik", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 758L, "İlkadım", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 759L, "Baykan", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 760L, "Eruh", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 761L, "Kurtalan", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 762L, "Pervari", 56L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 750L, "Asarcık", 55L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 794L, "Hayrabolu", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 795L, "Malkara", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 796L, "Muratlı", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 828L, "Düzköy", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 829L, "Hayrat", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 830L, "Köprübaşı", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 831L, "Ortahisar", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 832L, "Çemişgezek", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 833L, "Hozat", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 834L, "Malazgirt", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 835L, "Nazımiye", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 836L, "Ovacık", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 837L, "Pertek", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 838L, "Pülümür", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 839L, "Merkez", 62L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 827L, "Dernekpazarı", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 840L, "Akçakale", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 842L, "Bozova", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 843L, "Ceylanpınar", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 844L, "Halfeti", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 845L, "Hilvan", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 846L, "Siverek", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 847L, "Suruç", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 848L, "Viranşehir", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 849L, "Harran", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 850L, "Eyyübiye", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 851L, "Haliliye", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 852L, "Karaköprü", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 853L, "Banaz", 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 841L, "Birecik", 63L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 826L, "Çarşıbaşı", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 825L, "Şalpazarı", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 824L, "Beşikdüzü", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 797L, "Saray", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 798L, "Şarköy", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 799L, "Marmaraereğlisi", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 800L, "Ergene", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 801L, "Süleymanpaşa", 59L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 802L, "Almus", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 803L, "Artova", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 804L, "Erbaa", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 805L, "Niksar", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 806L, "Reşadiye", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 807L, "Merkez", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 808L, "Turhal", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 809L, "Zile", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 810L, "Pazar", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 811L, "Yeşilyurt", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 812L, "Başçiftlik", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 813L, "Sulusaray", 60L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 814L, "Akçaabat", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 815L, "Araklı", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 816L, "Arsin", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 817L, "Çaykara", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 818L, "Maçka", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 819L, "Of", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 820L, "Sürmene", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 821L, "Tonya", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 822L, "Vakfıkebir", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 823L, "Yomra", 61L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 855L, "Karahallı", 64L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 492L, "Narlıdere", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 496L, "Arpaçay", 36L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 490L, "Çiğli", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 161L, "Yenipazar", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 162L, "İnhisar", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 163L, "Merkez", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 164L, "Genç", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 165L, "Karlıova", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 166L, "Kığı", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 167L, "Solhan", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 168L, "Adaklı", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 169L, "Yayladere", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 170L, "Yedisu", 12L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 171L, "Adilcevaz", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 172L, "Ahlat", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 160L, "Söğüt", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 173L, "Merkez", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 175L, "Mutki", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 176L, "Tatvan", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 177L, "Güroymak", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 178L, "Merkez", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 179L, "Gerede", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 180L, "Göynük", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 181L, "Kıbrıscık", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 182L, "Mengen", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 183L, "Mudurnu", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 184L, "Seben", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 185L, "Dörtdivan", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 186L, "Yeniçağa", 14L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 174L, "Hizan", 13L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 187L, "Ağlasun", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 159L, "Pazaryeri", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 157L, "Gölpazarı", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 131L, "Karpuzlu", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 132L, "Köşk", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 133L, "Didim", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 134L, "Efeler", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 135L, "Ayvalık", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 136L, "Balya", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 137L, "Bandırma", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 138L, "Bigadiç", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 139L, "Burhaniye", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 140L, "Dursunbey", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 141L, "Edremit", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 142L, "Erdek", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 158L, "Osmaneli", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 143L, "Gönen", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 145L, "İvrindi", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 146L, "Kepsut", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 147L, "Manyas", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 148L, "Savaştepe", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 149L, "Sındırgı", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 150L, "Susurluk", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 151L, "Marmara", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 152L, "Gömeç", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 153L, "Altıeylül", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 154L, "Karesi", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 155L, "Merkez", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 156L, "Bozüyük", 11L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 144L, "Havran", 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 188L, "Bucak", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 189L, "Merkez", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 190L, "Gölhisar", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 222L, "Ezine", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 223L, "Gelibolu", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 224L, "Lapseki", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 225L, "Yenice", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 226L, "Merkez", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 227L, "Çerkeş", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 228L, "Eldivan", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 229L, "Ilgaz", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 230L, "Kurşunlu", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 231L, "Orta", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 232L, "Şabanözü", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 233L, "Yapraklı", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 221L, "Eceabat", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 234L, "Atkaracalar", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 236L, "Bayramören", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 237L, "Korgun", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 238L, "Alaca", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 239L, "Bayat", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 240L, "Merkez", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 241L, "İskilip", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 242L, "Kargı", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 243L, "Mecitözü", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 244L, "Ortaköy", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 491L, "Gaziemir", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 246L, "Sungurlu", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 247L, "Boğazkale", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 235L, "Kızılırmak", 18L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 220L, "Merkez", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 219L, "Çan", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 218L, "Bozcaada", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 191L, "Tefenni", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 192L, "Yeşilova", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 193L, "Karamanlı", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 194L, "Kemer", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 195L, "Altınyayla", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 196L, "Çavdır", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 197L, "Çeltikçi", 15L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 198L, "Gemlik", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 199L, "İnegöl", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 200L, "İznik", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 201L, "Karacabey", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 202L, "Keles", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 203L, "Mudanya", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 204L, "Mustafakemalpaşa", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 205L, "Orhaneli", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 206L, "Orhangazi", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 207L, "Yenişehir", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 208L, "Büyükorhan", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 209L, "Harmancık", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 210L, "Nilüfer", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 211L, "Osmangazi", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 212L, "Yıldırım", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 213L, "Gürsu", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 214L, "Kestel", 16L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 215L, "Ayvacık", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 216L, "Bayramiç", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 217L, "Biga", 17L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 130L, "İncirliova", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 129L, "Buharkent", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 128L, "Yenipazar", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 127L, "Sultanhisar", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 33L, "Emirdağ", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 34L, "Evciler", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 35L, "Hocalar", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 36L, "İhsaniye", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 37L, "İscehisar", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 38L, "Kızılören", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 39L, "Sandıklı", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 40L, "Sinanpaşa", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 41L, "Sultandağı", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 42L, "Şuhut", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 43L, "Ağrı", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 44L, "Diyadin", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 32L, "Dinar", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 45L, "Doğubayazıt", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 47L, "Hamur", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 48L, "Patnos", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 49L, "Taşlıçay", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 50L, "Tutak", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 58L, "Amasya", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 59L, "Göynücek", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 60L, "Gümüşhacıköy", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 61L, "Hamamözü", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 62L, "Merzifon", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 63L, "Suluova", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 64L, "Taşova", 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 65L, "Altındağ", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 46L, "Eleşkirt", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 31L, "Dazkırı", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 30L, "Çobanlar", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 29L, "Çay", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 2L, "Ceyhan", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 3L, "Çukurova", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 4L, "Feke", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 5L, "İmamoğlu", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 6L, "Karaisalı", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 7L, "Karataş", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 8L, "Kozan", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 9L, "Pozantı", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 10L, "Saimbeyli", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 11L, "Sarıçam", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 12L, "Seyhan", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 13L, "Tufanbeyli", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 14L, "Yumurtalık", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 15L, "Yüreğir", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 16L, "Adıyaman", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 17L, "Besni", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 18L, "Çelikhan", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 19L, "Gerger", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 20L, "Gölbaşı", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 21L, "Kahta", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 22L, "Samsat", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 23L, "Sincik", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 24L, "Tut", 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 25L, "Afyonkarahisar", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 26L, "Başmakçı", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 27L, "Bayat", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 28L, "Bolvadin", 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 66L, "Ayaş", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 248L, "Uğurludağ", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 67L, "Bala", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 69L, "Çamlıdere", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 101L, "Kemer", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 102L, "Kepez", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 103L, "Konyaaltı", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 104L, "Korkuteli", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 105L, "Kumluca", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 106L, "Manavgat", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 107L, "Muratpaşa", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 108L, "Serik", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 109L, "Ardanuç", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 110L, "Arhavi", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 111L, "Artvin", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 112L, "Merkez", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 100L, "Kaş", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 113L, "Borçka", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 115L, "Şavşat", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 116L, "Yusufeli", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 117L, "Murgul", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 118L, "Bozdoğan", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 119L, "Çine", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 120L, "Germencik", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 121L, "Karacasu", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 122L, "Koçarlı", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 123L, "Kuşadası", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 124L, "Kuyucak", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 125L, "Nazilli", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 126L, "Söke", 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 114L, "Hopa", 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 99L, "İbradı", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 98L, "Gündoğmuş", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 97L, "Gazipaşa", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 70L, "Çankaya", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 71L, "Çubuk", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 72L, "Elmadağ", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 73L, "Güdül", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 74L, "Haymana", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 75L, "Kalecik", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 76L, "Kızılcahamam", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 77L, "Nallıhan", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 78L, "Polatlı", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 79L, "Şereflikoçhisar", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 80L, "Yenimahalle", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 81L, "Gölbaşı", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 82L, "Keçiören", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 83L, "Mamak", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 84L, "Sincan", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 85L, "Kazan", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 86L, "Akyurt", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 87L, "Etimesgut", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 88L, "Evren", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 89L, "Pursaklar", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 90L, "Akseki", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 91L, "Aksu", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 92L, "Alanya", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 93L, "Demre", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 94L, "Döşemealtı", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 95L, "Elmalı", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 96L, "Finike", 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 68L, "Beypazarı", 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 249L, "Dodurga", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 245L, "Osmancık", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 251L, "Oğuzlar", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 403L, "Gelendost", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 404L, "Merkez", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 405L, "Keçiborlu", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 406L, "Senirkent", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 407L, "Sütçüler", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 408L, "Şarkikırkağaç", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 409L, "Uluborlu", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 410L, "Yalvaç", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 411L, "Aksu", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 412L, "Gönen", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 413L, "Yenişarbademli", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 414L, "Anamur", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 402L, "Eğirdir", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 415L, "Erdemli", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 417L, "Mut", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 418L, "Silifke", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 419L, "Tarsus", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 420L, "Aydıncık", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 421L, "Bozyazı", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 422L, "Çamlıyayla", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 423L, "Akdeniz", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 424L, "Mezitli", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 425L, "Toroslar", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 426L, "Yenişehir", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 427L, "Adalar", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 428L, "Bakırköy", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 416L, "Gülnar", 33L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 429L, "Beşiktaş", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 401L, "Atabey", 32L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 399L, "Defne", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 373L, "Çanakçı", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 374L, "Doğankent", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 250L, "Laçin", 19L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 376L, "Merkez", 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 377L, "Kelkit", 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 378L, "Şiran", 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 379L, "Torul", 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 380L, "Köse", 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 381L, "Kürtün", 29L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 382L, "Çukurca", 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 383L, "Merkez", 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 384L, "Şemdinli", 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 400L, "Payas", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 385L, "Yüksekova", 30L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 387L, "Dörtyol", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 388L, "Hassa", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 389L, "İskenderun", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 390L, "Kırıkhan", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 391L, "Reyhanlı", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 392L, "Samandağ", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 393L, "Yayladağı", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 394L, "Erzin", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 395L, "Belen", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 396L, "Kumlu", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 397L, "Antakya", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 398L, "Arsuz", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 386L, "Altınözü", 31L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 430L, "Beykoz", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 431L, "Beyoğlu", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 432L, "Çatalca", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 464L, "Sancaktepe", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 465L, "Sultangazi", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 466L, "Aliağa", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 467L, "Bayındır", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 468L, "Bergama", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 469L, "Bornova", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 470L, "Çeşme", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 471L, "Dikili", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 472L, "Foça", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 473L, "Karaburun", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 474L, "Karşıyaka", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 475L, "Kemalpaşa", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 463L, "Esenyurt", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 476L, "Kınık", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 478L, "Menemen", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 479L, "Ödemiş", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 480L, "Seferihisar", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 481L, "Selçuk", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 482L, "Tire", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 483L, "Torbalı", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 484L, "Urla", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 485L, "Beydağ", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 486L, "Buca", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 487L, "Konak", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 488L, "Menderes", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 489L, "Balçova", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 477L, "Kiraz", 35L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 462L, "Çekmeköy", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 461L, "Beylikdüzü", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 460L, "Başakşehir", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 433L, "Eyüp", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 434L, "Fatih", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 435L, "Gaziosmanpaşa", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 436L, "Kadıköy", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 437L, "Kartal", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 438L, "Sarıyer", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 439L, "Silivri", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 440L, "Şile", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 441L, "Şişli", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 442L, "Üsküdar", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 443L, "Zeytinburnu", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 444L, "Büyükçekmece", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 445L, "Kağıthane", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 446L, "Küçükçekmece", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 447L, "Pendik", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 448L, "Ümraniye", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 449L, "Bayrampaşa", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 450L, "Avcılar", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 451L, "Bağcılar", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 452L, "Bahçelievler", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 453L, "Güngören", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 454L, "Maltepe", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 455L, "Sultanbeyli", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 456L, "Tuzla", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 457L, "Esenler", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 458L, "Arnavutköy", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 459L, "Ataşehir", 34L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 372L, "Çamoluk", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 371L, "Yağlıdere", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 375L, "Güce", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 369L, "Tirebolu", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 282L, "Eğil", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 283L, "Kocaköy", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 284L, "Bağlar", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 285L, "Kayapınar", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 286L, "Sur", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 287L, "Yenişehir", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 288L, "Merkez", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 289L, "Enez", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 290L, "Havsa", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 291L, "İpsala", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 292L, "Keşan", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 293L, "Lalapaşa", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 281L, "Silvan", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 294L, "Meriç", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 296L, "Süloğlu", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 297L, "Ağın", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 298L, "Baskil", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 299L, "Merkez", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 300L, "Karakoçan", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 301L, "Keban", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 302L, "Maden", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 303L, "Palu", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 304L, "Sivrice", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 370L, "Piraziz", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 306L, "Kovancılar", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 307L, "Alacakaya", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 295L, "Uzunköprü", 22L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 308L, "Çayırlı", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 280L, "Lice", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 278L, "Hazro", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 252L, "Acıpayam", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 253L, "Buldan", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 254L, "Çal", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 255L, "Çameli", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 256L, "Çardak", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 257L, "Çivril", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 258L, "Güney", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 259L, "Kale", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 260L, "Sarayköy", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 261L, "Tavas", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 262L, "Babadağ", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 263L, "Bekilli", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 279L, "Kulp", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 264L, "Honaz", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 266L, "Pamukkale", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 267L, "Baklan", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 268L, "Beyağaç", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 269L, "Bozkurt", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 270L, "Merkezefendi", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 271L, "Bismil", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 272L, "Çermik", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 273L, "Çınar", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 274L, "Çüngüş", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 275L, "Dicle", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 276L, "Ergani", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 277L, "Hani", 21L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 265L, "Serinhisar", 20L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 309L, "Merkez", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 305L, "Arıcak", 23L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 311L, "Kemah", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 343L, "Alpu", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 344L, "Beylikova", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 310L, "İliç", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 346L, "Günyüzü", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 347L, "Han", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 348L, "Mihalgazi", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 349L, "Odunpazarı", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 350L, "Tepebaşı", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 351L, "Araban", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 352L, "Islahiye", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 353L, "Nizip", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 354L, "Oğuzeli", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 342L, "Sivrihisar", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 355L, "Yavuzeli", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 357L, "Şehitkamil", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[,]
                {
                    { 358L, "Karkamış", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 359L, "Nurdağı", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 360L, "Alucra", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 361L, "Bulancak", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 362L, "Dereli", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 363L, "Espiye", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 364L, "Eynesil", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 365L, "Merkez", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 366L, "Görele", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 367L, "Keşap", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 368L, "Şebinkarahisar", 28L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 356L, "Şahinbey", 27L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 341L, "Seyitgazi", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 345L, "İnönü", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 339L, "Mihalıççık", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 312L, "Kemaliye", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 313L, "Refahiye", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 314L, "Tercan", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 315L, "Üzümlü", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 316L, "Otlukbeli", 24L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 317L, "Aşkale", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 318L, "Çat", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 319L, "Hınıs", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 340L, "Sarıcakaya", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 321L, "İspir", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 322L, "Karayazı", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 323L, "Narman", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 324L, "Oltu", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 320L, "Horasan", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 326L, "Pasinler", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 338L, "Mahmudiye", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 337L, "Çifteler", 26L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 325L, "Olur", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 335L, "Palandöken", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 334L, "Köprüköy", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 333L, "Aziziye", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 336L, "Yakutiye", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 331L, "Uzundere", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 330L, "Karaçoban", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 329L, "Tortum", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 328L, "Tekman", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null },
                    { 327L, "Şenkaya", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null }
                });

            migrationBuilder.InsertData(
                table: "TT_COUNTY",
                columns: new[] { "ID", "ADI", "CITY_ID", "CREATED_DATE", "CREATED_USER", "UPDATED_DATE", "UPDATED_USER" },
                values: new object[] { 332L, "Pazaryolu", 25L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0L, null, null });

            migrationBuilder.InsertData(
                table: "T_USER_ROLE",
                columns: new[] { "ID", "CREATED_DATE", "CREATED_USER", "ROLE_TYPE_ID", "UPDATED_DATE", "UPDATED_USER", "USER_ID" },
                values: new object[,]
                {
                    { 9L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(981), 1L, 2L, null, null, 9L },
                    { 1L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(947), 1L, 1L, null, null, 1L },
                    { 2L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(963), 1L, 1L, null, null, 2L },
                    { 3L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(966), 1L, 2L, null, null, 3L },
                    { 4L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(968), 1L, 2L, null, null, 4L },
                    { 5L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(971), 1L, 2L, null, null, 5L },
                    { 6L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(974), 1L, 2L, null, null, 6L },
                    { 7L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(976), 1L, 2L, null, null, 7L },
                    { 8L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(979), 1L, 2L, null, null, 8L },
                    { 10L, new DateTime(2021, 2, 15, 22, 4, 18, 815, DateTimeKind.Local).AddTicks(984), 1L, 2L, null, null, 10L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_CAMPAIGN_BRAND_ID",
                table: "T_CAMPAIGN",
                column: "BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CAMPAIGN_CAMPAIGN_TYPE_ID",
                table: "T_CAMPAIGN",
                column: "CAMPAIGN_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CAMPAIGN_NOTIFICATION_ID",
                table: "T_CAMPAIGN",
                column: "NOTIFICATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CAMPAIGN_OWNER_BRAND_ID",
                table: "T_CAMPAIGN",
                column: "OWNER_BRAND_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CAMPAIGN_SECTOR_ID",
                table: "T_CAMPAIGN",
                column: "SECTOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_CONTACT_USER_ID",
                table: "T_CONTACT",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_LOGIN_USER_ID",
                table: "T_LOGIN",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_CITY_ID",
                table: "T_NOTIFICATION",
                column: "CITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_COUNTRY_ID",
                table: "T_NOTIFICATION",
                column: "COUNTRY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_COUNTY_ID",
                table: "T_NOTIFICATION",
                column: "COUNTY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_NOTIFICATION_STATUS_TYPE_ID",
                table: "T_NOTIFICATION",
                column: "NOTIFICATION_STATUS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_NOTIFICATION_TYPE_ID",
                table: "T_NOTIFICATION",
                column: "NOTIFICATION_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_VOTE_NOTIFICATION_ID",
                table: "T_NOTIFICATION_VOTE",
                column: "NOTIFICATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_NOTIFICATION_VOTE_USER_ID",
                table: "T_NOTIFICATION_VOTE",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_USER_LOGIN_TYPE_ID",
                table: "T_USER",
                column: "USER_LOGIN_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_USER_STATUS_TYPE_ID",
                table: "T_USER",
                column: "USER_STATUS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_NOTIFICATIONS_NOTIFICATION_TYPE_ID",
                table: "T_USER_FAVORITE_NOTIFICATIONS",
                column: "NOTIFICATION_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FAVORITE_NOTIFICATIONS_USER_ID",
                table: "T_USER_FAVORITE_NOTIFICATIONS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_ROLE_ROLE_TYPE_ID",
                table: "T_USER_ROLE",
                column: "ROLE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_ROLE_USER_ID",
                table: "T_USER_ROLE",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TT_BRAND_COUNTRY_ID",
                table: "TT_BRAND",
                column: "COUNTRY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TT_CITY_COUNTRY_ID",
                table: "TT_CITY",
                column: "COUNTRY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TT_COUNTY_CITY_ID",
                table: "TT_COUNTY",
                column: "CITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TT_SECTOR_COUNTRY_ID",
                table: "TT_SECTOR",
                column: "COUNTRY_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_CAMPAIGN");

            migrationBuilder.DropTable(
                name: "T_CONTACT");

            migrationBuilder.DropTable(
                name: "T_LOGIN");

            migrationBuilder.DropTable(
                name: "T_NOTIFICATION_VOTE");

            migrationBuilder.DropTable(
                name: "T_USER_FAVORITE_NOTIFICATIONS");

            migrationBuilder.DropTable(
                name: "T_USER_ROLE");

            migrationBuilder.DropTable(
                name: "T_USER_VERIFICATION");

            migrationBuilder.DropTable(
                name: "TT_BRAND");

            migrationBuilder.DropTable(
                name: "TT_CAMPAIGN");

            migrationBuilder.DropTable(
                name: "TT_SECTOR");

            migrationBuilder.DropTable(
                name: "T_NOTIFICATION");

            migrationBuilder.DropTable(
                name: "T_USER");

            migrationBuilder.DropTable(
                name: "TT_ROLE");

            migrationBuilder.DropTable(
                name: "TT_COUNTY");

            migrationBuilder.DropTable(
                name: "TT_NOTIFICATION");

            migrationBuilder.DropTable(
                name: "TT_NOTIFICATION_STATUS");

            migrationBuilder.DropTable(
                name: "TT_LOGIN");

            migrationBuilder.DropTable(
                name: "TT_USER_STATUS");

            migrationBuilder.DropTable(
                name: "TT_CITY");

            migrationBuilder.DropTable(
                name: "TT_COUNTRY");
        }
    }
}
