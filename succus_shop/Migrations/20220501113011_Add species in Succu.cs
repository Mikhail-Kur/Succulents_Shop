using Microsoft.EntityFrameworkCore.Migrations;

namespace succus_shop.Migrations
{
    public partial class AddspeciesinSuccu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "SuccuModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Species",
                table: "SuccuModels");
        }
    }
}
