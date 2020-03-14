using Microsoft.EntityFrameworkCore.Migrations;

namespace Repo.Migrations
{
    public partial class MobilePhoneWithLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MobilePhoneWithLine",
                columns: table => new
                {
                    PhoneNumber = table.Column<int>(nullable: false),
                    IMEI = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhoneWithLine", x => new { x.PhoneNumber, x.IMEI });
                    table.ForeignKey(
                        name: "FK_MobilePhoneWithLine_MobilePhones_IMEI",
                        column: x => x.IMEI,
                        principalTable: "MobilePhones",
                        principalColumn: "IMEI",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobilePhoneWithLine_PhoneLines_PhoneNumber",
                        column: x => x.PhoneNumber,
                        principalTable: "PhoneLines",
                        principalColumn: "PhoneNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhoneWithLine_IMEI",
                table: "MobilePhoneWithLine",
                column: "IMEI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MobilePhoneWithLine");
        }
    }
}
