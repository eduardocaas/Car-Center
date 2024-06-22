using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "VARCHAR", nullable: false),
                    Modelo = table.Column<string>(type: "VARCHAR", nullable: false),
                    Ano_Modelo = table.Column<short>(type: "SMALLINT", nullable: false),
                    Ano_Fabricação = table.Column<short>(type: "SMALLINT", nullable: false),
                    Chassi = table.Column<string>(type: "VARCHAR", nullable: false),
                    Preco = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR", nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR", nullable: false),
                    Data_Admissao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(3048)),
                    Matricula = table.Column<string>(type: "VARCHAR", nullable: false),
                    Salario = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "INT", nullable: false),
                    Data_Emissao = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2024, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(1774)),
                    Garantia = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2026, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(2153)),
                    Valor_Venda = table.Column<double>(type: "FLOAT", nullable: false),
                    CompradorId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    CarroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nota_Carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nota_Cliente_CompradorId",
                        column: x => x.CompradorId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nota_Vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Email",
                table: "Cliente",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nota_CarroId",
                table: "Nota",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_CompradorId",
                table: "Nota",
                column: "CompradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_VendedorId",
                table: "Nota",
                column: "VendedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
