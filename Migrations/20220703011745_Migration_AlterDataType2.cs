using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_AlterDataType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "StockTransaction");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedAt",
                table: "StockTransaction",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
