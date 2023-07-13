using Microsoft.EntityFrameworkCore.Migrations;

namespace nyanlearnDotNet.Migrations
{
    public partial class updatecourseresultmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstructorId",
                table: "CourseResult",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseResult_InstructorId",
                table: "CourseResult",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResult_Instructor_InstructorId",
                table: "CourseResult",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseResult_Instructor_InstructorId",
                table: "CourseResult");

            migrationBuilder.DropIndex(
                name: "IX_CourseResult_InstructorId",
                table: "CourseResult");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CourseResult");
        }
    }
}
