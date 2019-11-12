using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepos.Migrations
{
    public partial class newnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    LABELID = table.Column<int>(nullable: false),
                    USEREMAIL = table.Column<string>(nullable: false),
                    TITLE = table.Column<string>(nullable: true),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    CREATEDDATE = table.Column<DateTime>(nullable: true),
                    MODIFIEDDATA = table.Column<DateTime>(nullable: true),
                    IMAGES = table.Column<string>(nullable: true),
                    REMINDER = table.Column<string>(nullable: true),
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
                name: "Users",
                columns: table => new
                {
                    USEREMAIL = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: false),
                    USERNAME = table.Column<string>(nullable: false),
                    CARDTYPE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.USEREMAIL);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
