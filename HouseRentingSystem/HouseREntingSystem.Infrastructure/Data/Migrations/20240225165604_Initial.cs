using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Agent identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                },
                comment: "Agents table");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Table identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Table name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Categories table");

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "House identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", maxLength: 50, nullable: false, comment: "House title"),
                    Address = table.Column<int>(type: "int", maxLength: 150, nullable: false, comment: "House address"),
                    Description = table.Column<int>(type: "int", maxLength: 500, nullable: false, comment: "House description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "House image url"),
                    PricePerMonth = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Monthly price"),
                    RenterId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "User id of the renterer"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier"),
                    AgentId = table.Column<int>(type: "int", nullable: false, comment: "Agent identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Agents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Houses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Houses table");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_AgentId",
                table: "Houses",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_CategoryId",
                table: "Houses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
