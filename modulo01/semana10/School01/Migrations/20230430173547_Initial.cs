using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School01.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CPF = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    RA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK__User_Students",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK__User_Teachers",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher_Id = table.Column<int>(type: "int", nullable: false),
                    Name_Discipline = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Discipline", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Teacher_Disciplines",
                        column: x => x.Teacher_Id,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discipline_Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClose = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Discipline_Quizzes",
                        column: x => x.Discipline_Id,
                        principalTable: "Discipline",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Student_Discipline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discipline_Id = table.Column<int>(type: "int", nullable: false),
                    Student_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Student_Discipline", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Discipline_Student_Discipline",
                        column: x => x.Student_Id,
                        principalTable: "Discipline",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Student_Student_Discipline",
                        column: x => x.Student_Id,
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quiz_Id = table.Column<int>(type: "int", nullable: false),
                    Enunciation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Quiz_Questions",
                        column: x => x.Quiz_Id,
                        principalTable: "Quiz",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question_Id = table.Column<int>(type: "int", nullable: false),
                    Student_Id = table.Column<int>(type: "int", nullable: false),
                    Answers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Question_Answers",
                        column: x => x.Question_Id,
                        principalTable: "Question",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Student_Answers",
                        column: x => x.Student_Id,
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 118397500, "bart@hotmail.com", "Bart Simpson", "aabbcc" },
                    { 2, 171589470, "meggie@hotmail.com", "Meggie Simpson", "123456" },
                    { 3, 637012100, "lisa@hotmail.com", "Lisa Simpson", "a1b2c3" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Period", "RA", "User_Id" },
                values: new object[,]
                {
                    { 1, 1, 11548, 1 },
                    { 2, 1, 14999, 2 },
                    { 3, 2, 15129, 3 }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "Department", "User_Id" },
                values: new object[,]
                {
                    { 1, "", 1 },
                    { 2, "", 2 },
                    { 3, "", 3 }
                });

            migrationBuilder.InsertData(
                table: "Discipline",
                columns: new[] { "Id", "Name_Discipline", "Teacher_Id" },
                values: new object[,]
                {
                    { 1, "Biologia", 1 },
                    { 2, "Português", 2 },
                    { 3, "Matemática", 3 }
                });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "Id", "DateClose", "DateOpen", "Discipline_Id", "Title" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Conhecendo o aluno?" });

            migrationBuilder.InsertData(
                table: "Student_Discipline",
                columns: new[] { "Id", "Discipline_Id", "Student_Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Enunciation", "Quiz_Id", "Weight" },
                values: new object[,]
                {
                    { 1, "Qual o dia da semana que você mais gosta?", 1, 1m },
                    { 2, "Qual seu hobbie?", 1, 2m },
                    { 3, "Qual a sua matéria favorita?", 1, 1m }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "Answers", "Observation", "Question_Id", "Score", "Student_Id" },
                values: new object[,]
                {
                    { 1, "Segunda-feira", "", 1, 1f, 1 },
                    { 2, "Ler e montar quebra-cabeças", "", 2, 2f, 1 },
                    { 3, "Biologia", "", 3, 1f, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Question_Id",
                table: "Answer",
                column: "Question_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_Student_Id",
                table: "Answer",
                column: "Student_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Discipline_Teacher_Id",
                table: "Discipline",
                column: "Teacher_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Question_Quiz_Id",
                table: "Question",
                column: "Quiz_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_Discipline_Id",
                table: "Quiz",
                column: "Discipline_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_User_Id",
                table: "Student",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Discipline_Student_Id",
                table: "Student_Discipline",
                column: "Student_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_User_Id",
                table: "Teacher",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Student_Discipline");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
