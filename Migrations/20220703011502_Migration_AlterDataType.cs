using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_AlterDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "StockTransaction",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StockTransaction",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
