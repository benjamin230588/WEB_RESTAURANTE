using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_RESTAURANTE_DATOS.Migrations
{
    /// <inheritdoc />
    public partial class segundo77 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre44",
                table: "Proveedor",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre44",
                table: "Proveedor");
        }
    }
}
