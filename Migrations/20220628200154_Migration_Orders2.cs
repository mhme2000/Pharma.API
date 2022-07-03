using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_Orders2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnitaryValue",
                table: "StockTransactionItem",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "UnitaryValue",
                table: "StockTransactionItem",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }
    }
}
