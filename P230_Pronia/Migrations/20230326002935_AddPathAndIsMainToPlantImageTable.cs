using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P230_Pronia.Migrations
{
    public partial class AddPathAndIsMainToPlantImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "PlantImages",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "PlantImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "PlantImages");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "PlantImages");
        }
    }
}
