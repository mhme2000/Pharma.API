using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_CreateTableStockItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockItem",
                columns: table => new
                {
                    StockItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StockId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Lote = table.Column<string>(type: "text", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Saldo = table.Column<int>(type: "integer", nullable: false),
                    UnitaryValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItem", x => x.StockItemId);
                    table.ForeignKey(
                        name: "FK_StockItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockItem_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockItem_ProductId",
                table: "StockItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockItem_StockId",
                table: "StockItem",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockItem");
        }
    }
}
