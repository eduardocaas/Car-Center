using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    public partial class NotaNumeroIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 55, 5, 204, DateTimeKind.Local).AddTicks(1825),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 41, 13, 310, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.CreateIndex(
                name: "IX_Nota_Numero",
                table: "Nota",
                column: "Numero",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Nota_Numero",
                table: "Nota");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 41, 13, 310, DateTimeKind.Local).AddTicks(6101),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 55, 5, 204, DateTimeKind.Local).AddTicks(1825));
        }
    }
}
