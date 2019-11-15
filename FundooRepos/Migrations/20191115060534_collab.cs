using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepos.Migrations
{
    public partial class collab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collabration");
        }
    }
}
