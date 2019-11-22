using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepos.Migrations
{
    public partial class ChangedUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "STATUS",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "Users");
        }
    }
}
