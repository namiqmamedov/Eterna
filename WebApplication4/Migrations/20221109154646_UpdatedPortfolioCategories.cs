using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class UpdatedPortfolioCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PortfolioCategories_PortfolioCategoryId",
                table: "Portfolios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioCategories",
                table: "PortfolioCategories");

            migrationBuilder.RenameTable(
                name: "Portfolios",
                newName: "Portfolio");

            migrationBuilder.RenameTable(
                name: "PortfolioCategories",
                newName: "PortfolioCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_PortfolioCategoryId",
                table: "Portfolio",
                newName: "IX_Portfolio_PortfolioCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioCategory",
                table: "PortfolioCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_PortfolioCategory_PortfolioCategoryId",
                table: "Portfolio",
                column: "PortfolioCategoryId",
                principalTable: "PortfolioCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolio_PortfolioCategory_PortfolioCategoryId",
                table: "Portfolio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioCategory",
                table: "PortfolioCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio");

            migrationBuilder.RenameTable(
                name: "PortfolioCategory",
                newName: "PortfolioCategories");

            migrationBuilder.RenameTable(
                name: "Portfolio",
                newName: "Portfolios");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolio_PortfolioCategoryId",
                table: "Portfolios",
                newName: "IX_Portfolios_PortfolioCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioCategories",
                table: "PortfolioCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PortfolioCategories_PortfolioCategoryId",
                table: "Portfolios",
                column: "PortfolioCategoryId",
                principalTable: "PortfolioCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
