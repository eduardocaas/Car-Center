using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    public partial class NotaGarantiaNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(8214),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Garantia",
                table: "Nota",
                type: "DATETIME",
                nullable: true,
                defaultValue: new DateTime(2026, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(7143),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2026, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Emissao",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(6687),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(3970));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(5565),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Garantia",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2026, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(4535),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Emissao",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 21, 22, 54, 13, 869, DateTimeKind.Local).AddTicks(3970),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(6687));
        }
    }
}
