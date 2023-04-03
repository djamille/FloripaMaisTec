using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maternidade.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Mae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Parto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario_Parto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medico_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parto", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Medico_Parto",
                        column: x => x.Medico_Id,
                        principalTable: "Medico",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bebe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso_Nascimento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Mae_Id = table.Column<int>(type: "int", nullable: false),
                    Parto_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebe", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Mae_Bebe",
                        column: x => x.Mae_Id,
                        principalTable: "Mae",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Parto_Bebe",
                        column: x => x.Parto_Id,
                        principalTable: "Parto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Mae_Id",
                table: "Bebe",
                column: "Mae_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_Parto_Id",
                table: "Bebe",
                column: "Parto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Parto_Medico_Id",
                table: "Parto",
                column: "Medico_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebe");

            migrationBuilder.DropTable(
                name: "Mae");

            migrationBuilder.DropTable(
                name: "Parto");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
