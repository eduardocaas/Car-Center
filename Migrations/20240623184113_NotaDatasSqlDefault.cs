using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCenter.Migrations
{
    public partial class NotaDatasSqlDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 41, 13, 310, DateTimeKind.Local).AddTicks(6101),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Garantia",
                table: "Nota",
                type: "DATETIME",
                nullable: true,
                defaultValueSql: "DATEADD(YEAR, 2, GETDATE())",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Emissao",
                table: "Nota",
                type: "DATETIME",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(6687));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Admissao",
                table: "Vendedor",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(8214),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldDefaultValue: new DateTime(2024, 6, 23, 15, 41, 13, 310, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Garantia",
                table: "Nota",
                type: "DATETIME",
                nullable: true,
                defaultValue: new DateTime(2026, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(7143),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true,
                oldDefaultValueSql: "DATEADD(YEAR, 2, GETDATE())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Emissao",
                table: "Nota",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 23, 15, 31, 47, 161, DateTimeKind.Local).AddTicks(6687),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
