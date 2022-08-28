using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WFAEntity270822A.Migrations
{
    public partial class thirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeID",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_GradeID",
                table: "StudentCourses",
                column: "GradeID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Grades_GradeID",
                table: "StudentCourses",
                column: "GradeID",
                principalTable: "Grades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Grades_GradeID",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_GradeID",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "GradeID",
                table: "StudentCourses");
        }
    }
}
