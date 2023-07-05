using Microsoft.EntityFrameworkCore.Migrations;

namespace nyanlearnDotNet.Migrations
{
    public partial class fixedmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LessonId",
                table: "CourseLessons",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstructorId",
                table: "CourseLessons",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "CourseLessons",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_InstructorId",
                table: "CourseLessons",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessons_LessonId",
                table: "CourseLessons",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_Course_CourseId",
                table: "CourseLessons",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_Instructor_InstructorId",
                table: "CourseLessons",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLessons_Lesson_LessonId",
                table: "CourseLessons",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseLessons_Course_CourseId",
                table: "CourseLessons");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseLessons_Instructor_InstructorId",
                table: "CourseLessons");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseLessons_Lesson_LessonId",
                table: "CourseLessons");

            migrationBuilder.DropIndex(
                name: "IX_CourseLessons_CourseId",
                table: "CourseLessons");

            migrationBuilder.DropIndex(
                name: "IX_CourseLessons_InstructorId",
                table: "CourseLessons");

            migrationBuilder.DropIndex(
                name: "IX_CourseLessons_LessonId",
                table: "CourseLessons");

            migrationBuilder.AlterColumn<string>(
                name: "LessonId",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstructorId",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "CourseLessons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
