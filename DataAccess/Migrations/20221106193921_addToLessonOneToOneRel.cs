using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class addToLessonOneToOneRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonTeacher",
                table: "Lesson");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Lesson",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_TeacherId",
                table: "Lesson",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Teachers_TeacherId",
                table: "Lesson",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Teachers_TeacherId",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_TeacherId",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Lesson");

            migrationBuilder.AddColumn<string>(
                name: "LessonTeacher",
                table: "Lesson",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
