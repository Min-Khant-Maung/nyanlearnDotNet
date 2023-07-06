using Microsoft.EntityFrameworkCore.Migrations;

namespace nyanlearnDotNet.Migrations
{
    public partial class updatedlessonmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Lesson",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Lesson");
        }
    }
}
