using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspCoreUdemy.Core.Data.Migrations
{
    public partial class _20200913_00h15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                schema: "app",
                table: "Question",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                schema: "app",
                table: "Question");
        }
    }
}
