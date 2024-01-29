using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_HW2.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SubjectId",
                table: "Lectures",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TeacherId",
                table: "Lectures",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_TeacherId",
                table: "Lectures",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Subjects_SubjectId",
                table: "Lectures",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Teachers_TeacherId",
                table: "Lectures",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Subjects_SubjectId",
                table: "Lectures");

            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Teachers_TeacherId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_TeacherId",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Lectures");
        }
    }
}
