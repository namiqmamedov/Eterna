using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class CreatedDescriptionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Abouts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_DescriptionId",
                table: "Abouts",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Descriptions_DescriptionId",
                table: "Abouts",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Descriptions_DescriptionId",
                table: "Abouts");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_DescriptionId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Abouts");
        }
    }
}
