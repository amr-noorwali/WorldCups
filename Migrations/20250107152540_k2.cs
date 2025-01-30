using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldCups.Migrations
{
    /// <inheritdoc />
    public partial class k2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transport_CatogorisTransportation_CatogorisTransportation",
                table: "Transport");

            migrationBuilder.DropIndex(
                name: "IX_Transport_CatogorisTransportation",
                table: "Transport");

            migrationBuilder.RenameColumn(
                name: "CatogorisTransportation",
                table: "Transport",
                newName: "vehicle");

            migrationBuilder.AddColumn<string>(
                name: "Ctiy",
                table: "TableFootbul",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TableFootbul",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ctiy",
                table: "TableFootbul");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TableFootbul");

            migrationBuilder.RenameColumn(
                name: "vehicle",
                table: "Transport",
                newName: "CatogorisTransportation");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_CatogorisTransportation",
                table: "Transport",
                column: "CatogorisTransportation");

            migrationBuilder.AddForeignKey(
                name: "FK_Transport_CatogorisTransportation_CatogorisTransportation",
                table: "Transport",
                column: "CatogorisTransportation",
                principalTable: "CatogorisTransportation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
