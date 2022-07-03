using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_AddPhotoProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StockTransaction",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Product",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedAt",
                table: "StockTransaction",
                type: "integer",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
