using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hormona.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexos = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endocrino_codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endocrino_registro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<float>(type: "real", nullable: true),
                    longitud = table.Column<float>(type: "real", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaDeNacimineto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Familiarid = table.Column<int>(type: "int", nullable: true),
                    Endocrinoid = table.Column<int>(type: "int", nullable: true),
                    Pediatraid = table.Column<int>(type: "int", nullable: true),
                    Historiaid = table.Column<int>(type: "int", nullable: true),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Historias_Historiaid",
                        column: x => x.Historiaid,
                        principalTable: "Historias",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Endocrinoid",
                        column: x => x.Endocrinoid,
                        principalTable: "Personas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Familiarid",
                        column: x => x.Familiarid,
                        principalTable: "Personas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Pediatraid",
                        column: x => x.Pediatraid,
                        principalTable: "Personas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "sugerencias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: true),
                    descripcionCiudados = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historiaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sugerencias", x => x.id);
                    table.ForeignKey(
                        name: "FK_sugerencias_Historias_Historiaid",
                        column: x => x.Historiaid,
                        principalTable: "Historias",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Patrones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: true),
                    valor = table.Column<float>(type: "real", nullable: true),
                    patronesDeCrecimiento = table.Column<int>(type: "int", nullable: true),
                    Pacienteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Patrones_Personas_Pacienteid",
                        column: x => x.Pacienteid,
                        principalTable: "Personas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patrones_Pacienteid",
                table: "Patrones",
                column: "Pacienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Endocrinoid",
                table: "Personas",
                column: "Endocrinoid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Familiarid",
                table: "Personas",
                column: "Familiarid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Historiaid",
                table: "Personas",
                column: "Historiaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Pediatraid",
                table: "Personas",
                column: "Pediatraid");

            migrationBuilder.CreateIndex(
                name: "IX_sugerencias_Historiaid",
                table: "sugerencias",
                column: "Historiaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patrones");

            migrationBuilder.DropTable(
                name: "sugerencias");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Historias");
        }
    }
}
