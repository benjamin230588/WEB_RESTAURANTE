using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_RESTAURANTE_DATOS.Migrations
{
    /// <inheritdoc />
    public partial class quinto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destino4",
                table: "Cliente",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destino4",
                table: "Cliente");
        }
    }
}
