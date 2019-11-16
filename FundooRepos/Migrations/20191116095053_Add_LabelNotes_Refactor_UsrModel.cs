using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepos.Migrations
{
    public partial class Add_LabelNotes_Refactor_UsrModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LABELID",
                table: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "PROFILEIMAGE",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Labelnotes",
                columns: table => new
                {
                    LABELLEDNOTEID = table.Column<string>(nullable: false),
                    NOTEID = table.Column<string>(nullable: false),
                    LABELID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labelnotes", x => x.LABELLEDNOTEID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Labelnotes");

            migrationBuilder.DropColumn(
                name: "PROFILEIMAGE",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "LABELID",
                table: "Notes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
