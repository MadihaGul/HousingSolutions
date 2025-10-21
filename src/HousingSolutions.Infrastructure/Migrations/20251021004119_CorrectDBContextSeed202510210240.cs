using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingSolutions.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorrectDBContextSeed202510210240 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 21, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 21, 13, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 21, 6, 17, 19, 247, DateTimeKind.Local).AddTicks(1731), new DateTime(2025, 10, 21, 3, 17, 19, 245, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 10, 21, 10, 17, 19, 247, DateTimeKind.Local).AddTicks(2067), new DateTime(2025, 10, 21, 7, 17, 19, 247, DateTimeKind.Local).AddTicks(2063) });
        }
    }
}
