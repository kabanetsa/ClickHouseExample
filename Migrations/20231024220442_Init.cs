using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClickHouseExample.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "default");

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                schema: "default",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UUID", nullable: false),
                    Date = table.Column<DateOnly>(type: "Date", nullable: false),
                    TemperatureC = table.Column<int>(type: "Int32", nullable: false),
                    Summary = table.Column<string>(type: "String", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecast",
                schema: "default");
        }
    }
}
