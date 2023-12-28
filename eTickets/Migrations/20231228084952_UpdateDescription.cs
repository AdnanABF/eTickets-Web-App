using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripiton",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Descripiton",
                table: "Cinemas",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Descripiton");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Descripiton");
        }
    }
}
