using Microsoft.EntityFrameworkCore.Migrations;

namespace AspCoreUdemy.Core.Data.Migrations
{
    public partial class _20200828_00h40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "app",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "app",
                table: "Exam",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "app",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "app",
                table: "Exam");
        }
    }
}
