using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreName",
                value: "GenreFromJsonFile1");

            migrationBuilder.UpdateData(
                table: "genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreName",
                value: "GenreFromJsonFile2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreName",
                value: null);

            migrationBuilder.UpdateData(
                table: "genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreName",
                value: null);
        }
    }
}
