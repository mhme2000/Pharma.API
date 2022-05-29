using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pharma.API.Migrations
{
    public partial class Migration_AlterAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress_City",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Adress_Complement",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Adress_District",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Adress_Number",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Adress_Street",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Adress_Zipcode",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Street = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Zipcode = table.Column<string>(type: "text", nullable: true),
                    Complement = table.Column<string>(type: "text", nullable: true),
                    PersonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "User",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Adress_City",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress_Complement",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress_District",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Adress_Number",
                table: "Person",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress_Street",
                table: "Person",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress_Zipcode",
                table: "Person",
                type: "text",
                nullable: true);
        }
    }
}
