using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace updateAndChangeState.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_courseid",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "courseid",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_courseid",
                table: "Students",
                column: "courseid",
                principalTable: "Courses",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_courseid",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "courseid",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_courseid",
                table: "Students",
                column: "courseid",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
