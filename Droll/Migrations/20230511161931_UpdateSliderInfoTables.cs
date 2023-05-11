using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Droll.Migrations
{
    public partial class UpdateSliderInfoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "SliderInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "SliderInfos");
        }
    }
}
