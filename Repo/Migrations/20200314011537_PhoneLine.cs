using Microsoft.EntityFrameworkCore.Migrations;

namespace Repo.Migrations
{
    public partial class PhoneLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneLines",
                columns: table => new
                {
                    PhoneNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PUK = table.Column<int>(nullable: false),
                    PIN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneLines", x => x.PhoneNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneLines");
        }
    }
}
