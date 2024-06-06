using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pos.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class isPackRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPack",
                table: "Module");

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 11L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 12L,
                column: "CTime",
                value: new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "ShopGroup",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1052), new DateTime(2024, 5, 23, 7, 43, 13, 6, DateTimeKind.Utc).AddTicks(1054) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPack",
                table: "Module",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 1L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 2L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 3L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 4L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 5L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 6L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 7L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 8L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 9L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 10L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 11L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 12L,
                column: "CTime",
                value: new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "ShopGroup",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7050), new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7141), new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CTime", "MTime" },
                values: new object[] { new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 5, 10, 12, 48, 17, 29, DateTimeKind.Utc).AddTicks(7165) });
        }
    }
}
