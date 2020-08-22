using Microsoft.EntityFrameworkCore.Migrations;

namespace AspCoreUdemy.Core.Data.Migrations
{
    public partial class _20200822_22h23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Question_ParagrapheId",
                schema: "dbo",
                table: "Question");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                schema: "dbo",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Paragraphe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_ParagrapheId",
                schema: "dbo",
                table: "Question",
                column: "ParagrapheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Question_ParagrapheId",
                schema: "dbo",
                table: "Question");

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                schema: "dbo",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Question_ParagrapheId",
                schema: "dbo",
                table: "Question",
                column: "ParagrapheId",
                unique: true);
        }
    }
}
