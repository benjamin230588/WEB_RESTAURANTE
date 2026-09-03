using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_RESTAURANTE_DATOS.Migrations
{
    /// <inheritdoc />
    public partial class cambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idcorrelativo",
                table: "Proveedor");

            migrationBuilder.DropColumn(
                name: "Pasword",
                table: "Proveedor");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Proveedor");

            migrationBuilder.RenameColumn(
                name: "Idusuario",
                table: "Proveedor",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Proveedor",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Proveedor",
                type: "varchar(200)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Proveedor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Proveedor",
                newName: "Idusuario");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Proveedor",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Idcorrelativo",
                table: "Proveedor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pasword",
                table: "Proveedor",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Proveedor",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
