using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolsDbApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveExteriorColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExteriorColor",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "InteriorColor",
                table: "Car",
                newName: "Color");

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "blue");

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "red");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Car",
                newName: "InteriorColor");

            migrationBuilder.AddColumn<string>(
                name: "ExteriorColor",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExteriorColor", "InteriorColor" },
                values: new object[] { "blue", "tan" });

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExteriorColor", "InteriorColor" },
                values: new object[] { "red", "black" });
        }
    }
}
