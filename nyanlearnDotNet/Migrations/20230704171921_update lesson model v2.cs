using Microsoft.EntityFrameworkCore.Migrations;

namespace nyanlearnDotNet.Migrations
{
    public partial class updatelessonmodelv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Lesson",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Lesson");
        }
    }
}
