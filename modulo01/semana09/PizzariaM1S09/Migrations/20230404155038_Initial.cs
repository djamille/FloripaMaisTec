using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzariaM1S09.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Borda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Massa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Massa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sabor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSabor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sabor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pizza_Id = table.Column<int>(type: "int", nullable: false),
                    Sabores_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pizza", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Pizza_Borda",
                        column: x => x.Sabores_Id,
                        principalTable: "Borda",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Pizza_Massa",
                        column: x => x.Pizza_Id,
                        principalTable: "Massa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pizza_Id = table.Column<int>(type: "int", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Pizza_Pedido",
                        column: x => x.Pizza_Id,
                        principalTable: "Pizza",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Status_Pizza",
                        column: x => x.Status_Id,
                        principalTable: "Status",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PizzaSabor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pizza_Id = table.Column<int>(type: "int", nullable: false),
                    Sabores_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PizzaSabor", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Pizza_Sabor",
                        column: x => x.Pizza_Id,
                        principalTable: "Pizza",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Sabor_Pizza",
                        column: x => x.Sabores_Id,
                        principalTable: "Sabor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Pizza_Id",
                table: "Pedido",
                column: "Pizza_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Status_Id",
                table: "Pedido",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_Pizza_Id",
                table: "Pizza",
                column: "Pizza_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_Sabores_Id",
                table: "Pizza",
                column: "Sabores_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaSabor_Pizza_Id",
                table: "PizzaSabor",
                column: "Pizza_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaSabor_Sabores_Id",
                table: "PizzaSabor",
                column: "Sabores_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "PizzaSabor");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropTable(
                name: "Sabor");

            migrationBuilder.DropTable(
                name: "Borda");

            migrationBuilder.DropTable(
                name: "Massa");
        }
    }
}
