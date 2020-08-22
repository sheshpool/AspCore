using Microsoft.EntityFrameworkCore.Migrations;

namespace AspCoreUdemy.Core.Data.Migrations
{
    public partial class _20200822_20h28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reponse_QuestionId",
                schema: "dbo",
                table: "Reponse",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                schema: "dbo",
                table: "Reponse",
                column: "QuestionId",
                principalSchema: "dbo",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                schema: "dbo",
                table: "Reponse");

            migrationBuilder.DropIndex(
                name: "IX_Reponse_QuestionId",
                schema: "dbo",
                table: "Reponse");
        }
    }
}
