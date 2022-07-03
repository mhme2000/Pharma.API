using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_AlterExpirationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExpirationDate",
                table: "StockItem",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "StockItem",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
