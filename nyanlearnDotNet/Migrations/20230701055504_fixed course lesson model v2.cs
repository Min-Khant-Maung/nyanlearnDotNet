using Microsoft.EntityFrameworkCore.Migrations;

namespace nyanlearnDotNet.Migrations
{
    public partial class fixedcourselessonmodelv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstructorId",
                table: "Lesson",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstructorId",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_InstructorId",
                table: "Lesson",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Instructor_InstructorId",
                table: "Lesson",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Instructor_InstructorId",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_InstructorId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CourseLessons");
        }
    }
}
