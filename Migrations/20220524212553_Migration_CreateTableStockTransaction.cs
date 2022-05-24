using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_CreateTableStockTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "StockItem",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "Lote",
                table: "StockItem",
                newName: "Batch");

            migrationBuilder.RenameColumn(
                name: "DataValidade",
                table: "StockItem",
                newName: "ExpirationDate");

            migrationBuilder.CreateTable(
                name: "TransactionStatus",
                columns: table => new
                {
                    TransactionStatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatus", x => x.TransactionStatusId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "StockTransaction",
                columns: table => new
                {
                    StockTransactionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "integer", nullable: false),
                    TransactionStatusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransaction", x => x.StockTransactionId);
                    table.ForeignKey(
                        name: "FK_StockTransaction_TransactionStatus_TransactionStatusId",
                        column: x => x.TransactionStatusId,
                        principalTable: "TransactionStatus",
                        principalColumn: "TransactionStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransaction_TransactionType_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransaction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockTransactionItem",
                columns: table => new
                {
                    StockTransactionItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StockTransactionId = table.Column<int>(type: "integer", nullable: false),
                    StockItemId = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransactionItem", x => x.StockTransactionItemId);
                    table.ForeignKey(
                        name: "FK_StockTransactionItem_StockItem_StockItemId",
                        column: x => x.StockItemId,
                        principalTable: "StockItem",
                        principalColumn: "StockItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockTransactionItem_StockTransaction_StockTransactionId",
                        column: x => x.StockTransactionId,
                        principalTable: "StockTransaction",
                        principalColumn: "StockTransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_TransactionStatusId",
                table: "StockTransaction",
                column: "TransactionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_TransactionTypeId",
                table: "StockTransaction",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_UserId",
                table: "StockTransaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactionItem_StockItemId",
                table: "StockTransactionItem",
                column: "StockItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactionItem_StockTransactionId",
                table: "StockTransactionItem",
                column: "StockTransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTransactionItem");

            migrationBuilder.DropTable(
                name: "StockTransaction");

            migrationBuilder.DropTable(
                name: "TransactionStatus");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "StockItem",
                newName: "DataValidade");

            migrationBuilder.RenameColumn(
                name: "Batch",
                table: "StockItem",
                newName: "Lote");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "StockItem",
                newName: "Saldo");
        }
    }
}
