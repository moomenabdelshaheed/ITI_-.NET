using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCEFLAB2Day02.Migrations
{
    /// <inheritdoc />
    public partial class setnull_for_coursefk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Courses_CourseId",
                table: "CrsResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_CrsResult_CourseId",
                table: "CrsResult");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CrsResult");

            migrationBuilder.AlterColumn<int>(
                name: "crs_ID",
                table: "CrsResult",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CrsResult_crs_ID",
                table: "CrsResult",
                column: "crs_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Courses_crs_ID",
                table: "CrsResult",
                column: "crs_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseID",
                table: "Instructors",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Courses_crs_ID",
                table: "CrsResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_CrsResult_crs_ID",
                table: "CrsResult");

            migrationBuilder.AlterColumn<int>(
                name: "crs_ID",
                table: "CrsResult",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CrsResult",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CrsResult_CourseId",
                table: "CrsResult",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Courses_CourseId",
                table: "CrsResult",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseID",
                table: "Instructors",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
