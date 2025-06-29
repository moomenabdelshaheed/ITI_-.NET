using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCEFLAB2Day02.Migrations
{
    /// <inheritdoc />
    public partial class lastone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrsResult_Courses_crs_ID",
                table: "CrsResult");

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Courses_crs_ID",
                table: "CrsResult",
                column: "crs_ID",
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

            migrationBuilder.AddForeignKey(
                name: "FK_CrsResult_Courses_crs_ID",
                table: "CrsResult",
                column: "crs_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
