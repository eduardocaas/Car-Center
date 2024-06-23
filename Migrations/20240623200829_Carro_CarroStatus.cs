using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    public partial class Carro_CarroStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 17, 8, 29, 597, DateTimeKind.Local).AddTicks(8413),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 55, 5, 204, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.AddColumn<int>(
                name: "CarroStatus",
                table: "Carro",
                type: "int",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarroStatus",
                table: "Carro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 55, 5, 204, DateTimeKind.Local).AddTicks(1825),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 17, 8, 29, 597, DateTimeKind.Local).AddTicks(8413));
        }
    }
}
