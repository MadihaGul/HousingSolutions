using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HousingSolutions.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLocked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "EndTime", "ResidentName", "StartTime" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 10, 21, 6, 17, 19, 247, DateTimeKind.Local).AddTicks(1731), "Resident 1", new DateTime(2025, 10, 21, 3, 17, 19, 245, DateTimeKind.Local).AddTicks(4546) },
                    { 4, new DateTime(2025, 10, 21, 10, 17, 19, 247, DateTimeKind.Local).AddTicks(2067), "Resident 1", new DateTime(2025, 10, 21, 7, 17, 19, 247, DateTimeKind.Local).AddTicks(2063) }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "IsLocked", "Name" },
                values: new object[,]
                {
                    { 1, true, "Main Entrance" },
                    { 2, false, "Garage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Doors");
        }
    }
}
