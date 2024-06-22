using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    public partial class FixLengthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Vendedor",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Matricula",
                table: "Vendedor",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(5565),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Garantia",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2026, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(4535),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2026, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Emissao",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(3970),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "VARCHAR(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Cliente",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Carro",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Carro",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Chassi",
                table: "Carro",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Vendedor",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Matricula",
                table: "Vendedor",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(3048),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Garantia",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2026, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(2153),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2026, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Emissao",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 21, 22, 28, 9, 922, DateTimeKind.Local).AddTicks(1774),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Cliente",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Carro",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Carro",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Chassi",
                table: "Carro",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100);
        }
    }
}
