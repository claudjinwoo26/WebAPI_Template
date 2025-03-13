using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Housings.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeCountryToCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_Country",
                table: "Housing",
                newName: "Address_City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Housing",
                newName: "Address_Country");
        }
    }
}
