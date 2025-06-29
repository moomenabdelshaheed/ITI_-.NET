using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCEFLAB2Day02.Migrations
{
    /// <inheritdoc />
    public partial class add_one_in_onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Courses_CourseId",
                table: "CrsResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Trainees_TraineeId",
                table: "CrsResult");

            migrationBuilder.DropIndex(
                name: "IX_CrsResult_TraineeId",
                table: "CrsResult");

            migrationBuilder.DropColumn(
                name: "TraineeId",
                table: "CrsResult");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CrsResult",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrsResult_Trainee_ID",
                table: "CrsResult",
                column: "Trainee_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Courses_CourseId",
                table: "CrsResult",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Trainees_Trainee_ID",
                table: "CrsResult",
                column: "Trainee_ID",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Courses_CourseId",
                table: "CrsResult");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Trainees_Trainee_ID",
                table: "CrsResult");

            migrationBuilder.DropIndex(
                name: "IX_CrsResult_Trainee_ID",
                table: "CrsResult");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CrsResult",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TraineeId",
                table: "CrsResult",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrsResult_TraineeId",
                table: "CrsResult",
                column: "TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Courses_CourseId",
                table: "CrsResult",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Trainees_TraineeId",
                table: "CrsResult",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id");
        }
    }
}
