using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Droll.Migrations
{
    public partial class UpdateDogFoodTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "DogFoods");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "DogFoods",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
