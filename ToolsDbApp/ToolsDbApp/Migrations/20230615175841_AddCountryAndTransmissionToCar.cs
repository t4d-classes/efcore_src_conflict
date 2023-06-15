using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolsDbApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryAndTransmissionToCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Country", "Transmission" },
                values: new object[] { "USA", "automatic" });

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "Transmission" },
                values: new object[] { "USA", "automatic" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Car");
        }
    }
}
