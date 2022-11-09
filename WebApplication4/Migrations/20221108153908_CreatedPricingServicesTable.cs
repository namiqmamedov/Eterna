using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class CreatedPricingServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingId = table.Column<int>(nullable: false),
                    PRServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingServices_PRServices_PRServiceId",
                        column: x => x.PRServiceId,
                        principalTable: "PRServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PricingServices_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricingServices_PRServiceId",
                table: "PricingServices",
                column: "PRServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PricingServices_PricingId",
                table: "PricingServices",
                column: "PricingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingServices");
        }
    }
}
