using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "StockTransaction");

            migrationBuilder.AddColumn<float>(
                name: "UnitaryValue",
                table: "StockTransactionItem",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitaryValue",
                table: "StockTransactionItem");

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "StockTransaction",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
