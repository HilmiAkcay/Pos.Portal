using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudData.Migrations
{
    /// <inheritdoc />
    public partial class Admin_user_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Application",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5164), new Guid("87fb83df-1e37-48fc-8b23-bd84fa84b9b3") });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5424), new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5425), new Guid("76515f8c-3cf7-4fd1-aeb7-8ea72cecb76e") });

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5439), new Guid("b88a2b64-bdcb-4735-b09f-ca1d946f4205") });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5386), new Guid("2c722719-3f12-45c1-9f60-9d7ff8e54deb") });

            migrationBuilder.UpdateData(
                table: "ShopGroup",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5363), new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5364), new Guid("9bcaad6b-2437-40cc-913e-c87e1a7be919") });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5406), new Guid("42d5fcfc-f5fd-4898-be67-c474063b4499") });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CreatedDate", "Email", "IsDeleted", "IsValidated", "ModifiedDate", "Password", "RememberMe", "ShopId", "UID" },
                values: new object[] { 2L, new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5417), "admin", false, true, new DateTime(2023, 7, 18, 0, 11, 58, 533, DateTimeKind.Local).AddTicks(5418), "1", true, 1L, new Guid("6d0f201e-31b7-41fa-8ece-332372e915be") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2L);

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

            migrationBuilder.UpdateData(
                table: "Page",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate", "UID" },
                values: new object[] { new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 6, 2, 13, 59, 50, 8, DateTimeKind.Local).AddTicks(493), new Guid("af711b87-fc1d-4735-9c6f-eb6aa054d665") });

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
    }
}
