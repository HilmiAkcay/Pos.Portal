using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudData.Migrations
{
    public partial class Page_data_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(184), new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(197), new Guid("8a7513ff-ef1d-457d-852a-d8436693da23") });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(474), new Guid("fa822607-d891-4219-a424-263096a3bc08") });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "ID", "CreatedDate", "IsDeleted", "ModifiedDate", "Name", "PurePosId", "UID" },
                values: new object[] { 3L, new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(492), false, new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(493), "User Setting", 3, new Guid("af711b87-fc1d-4735-9c6f-eb6aa054d665") });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(436), new Guid("5dd4a5f0-e4ab-4ab7-a67f-6e9ea2bea828") });

            migrationBuilder.UpdateData(
                table: "ShopGroup",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(417), new Guid("0cb9c57a-fbed-4ffd-b718-79435806f688") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(456), new Guid("7542d38f-e810-4682-a3a3-0161b1d0723f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(6877), new Guid("2c95d909-87bf-4260-9456-416be57aff04") });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7098), new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7099), new Guid("bfd9ecb4-9f37-4b0d-8418-932766396070") });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7073), new Guid("3a0521dd-db52-4db3-9fe2-bebd2c844516") });

            migrationBuilder.UpdateData(
                table: "ShopGroup",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7038), new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7040), new Guid("0ffb52f5-6ff4-4ba8-b4c4-63a9d375652a") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7091), new DateTime(2023, 6, 2, 11, 51, 19, 553, DateTimeKind.Local).AddTicks(7093), new Guid("1bb31986-b56c-4a62-9aae-5956d659092d") });
        }
    }
}
