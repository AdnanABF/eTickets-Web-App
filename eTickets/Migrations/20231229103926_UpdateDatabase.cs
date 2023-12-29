using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProducerID",
                table: "Producers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CinemaID",
                table: "Cinemas",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ActorID",
                table: "Actors",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Producers",
                newName: "ProducerID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Movies",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cinemas",
                newName: "CinemaID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Actors",
                newName: "ActorID");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
