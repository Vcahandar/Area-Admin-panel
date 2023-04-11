using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntytiFramework_Slider.Migrations
{
    public partial class CreateColum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Sliders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "SliderInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SoftDelete",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "SliderInfos");

            migrationBuilder.DropColumn(
                name: "SoftDelete",
                table: "Blogs");
        }
    }
}
