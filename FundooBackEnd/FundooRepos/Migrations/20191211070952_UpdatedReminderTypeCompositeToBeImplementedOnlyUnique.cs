using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepos.Migrations
{
    public partial class UpdatedReminderTypeCompositeToBeImplementedOnlyUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ADMINEMAIL = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: false),
                    ADMINNAME = table.Column<string>(nullable: false),
                    PROFILEIMAGE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ADMINEMAIL);
                });

            migrationBuilder.CreateTable(
                name: "Collabration",
                columns: table => new
                {
                    COLLABRATIONID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOTEID = table.Column<int>(nullable: false),
                    SENDEREMAIL = table.Column<string>(nullable: false),
                    RECIEVEDEMAIL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collabration", x => x.COLLABRATIONID);
                });

            migrationBuilder.CreateTable(
                name: "Labelnotes",
                columns: table => new
                {
                    LABELNOTEID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOTEID = table.Column<int>(nullable: false),
                    LABELID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labelnotes", x => x.LABELNOTEID);
                });

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    LABELID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    USEREMAIL = table.Column<string>(nullable: false),
                    LABEL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.LABELID);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NOTEID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DISPLAYORDER = table.Column<int>(nullable: false),
                    USEREMAIL = table.Column<string>(nullable: false),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    CREATEDDATE = table.Column<DateTime>(nullable: true),
                    MODIFIEDDATA = table.Column<DateTime>(nullable: true),
                    IMAGES = table.Column<string>(nullable: true),
                    REMINDER = table.Column<DateTime>(nullable: true),
                    ISARCHIVE = table.Column<bool>(nullable: false),
                    ISTRASH = table.Column<bool>(nullable: false),
                    ISPIN = table.Column<bool>(nullable: false),
                    COLOR = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NOTEID);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    REMINDERID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    USEREMAIL = table.Column<string>(nullable: false),
                    NOTEID = table.Column<int>(nullable: false),
                    REMINDERTIME = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.REMINDERID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    USEREMAIL = table.Column<string>(nullable: false),
                    USERID = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: false),
                    USERNAME = table.Column<string>(nullable: false),
                    CARDTYPE = table.Column<string>(nullable: true),
                    PROFILEIMAGE = table.Column<string>(nullable: true),
                    STATUS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.USEREMAIL);
                });

            migrationBuilder.CreateTable(
                name: "UserStatistics",
                columns: table => new
                {
                    SINO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    USEREMAIL = table.Column<string>(nullable: false),
                    LOGINDATETIME = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatistics", x => x.SINO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Collabration");

            migrationBuilder.DropTable(
                name: "Labelnotes");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserStatistics");
        }
    }
}
