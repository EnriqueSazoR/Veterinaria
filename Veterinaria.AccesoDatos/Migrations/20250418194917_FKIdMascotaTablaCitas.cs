using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veterinaria.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKIdMascotaTablaCitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_AspNetUsers_IdUsuario",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Mascota_MascotaId",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Sucursal_IdSucursal",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_AspNetUsers_IdUsuario",
                table: "Mascota");

            migrationBuilder.DropIndex(
                name: "IX_Cita_MascotaId",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "MascotaId",
                table: "Cita");

            migrationBuilder.AddColumn<int>(
                name: "IdMascota",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cita_IdMascota",
                table: "Cita",
                column: "IdMascota");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_AspNetUsers_IdUsuario",
                table: "Cita",
                column: "IdUsuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Mascota_IdMascota",
                table: "Cita",
                column: "IdMascota",
                principalTable: "Mascota",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Sucursal_IdSucursal",
                table: "Cita",
                column: "IdSucursal",
                principalTable: "Sucursal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_AspNetUsers_IdUsuario",
                table: "Mascota",
                column: "IdUsuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_AspNetUsers_IdUsuario",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Mascota_IdMascota",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Sucursal_IdSucursal",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_AspNetUsers_IdUsuario",
                table: "Mascota");

            migrationBuilder.DropIndex(
                name: "IX_Cita_IdMascota",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "IdMascota",
                table: "Cita");

            migrationBuilder.AddColumn<int>(
                name: "MascotaId",
                table: "Cita",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cita_MascotaId",
                table: "Cita",
                column: "MascotaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_AspNetUsers_IdUsuario",
                table: "Cita",
                column: "IdUsuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Mascota_MascotaId",
                table: "Cita",
                column: "MascotaId",
                principalTable: "Mascota",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Sucursal_IdSucursal",
                table: "Cita",
                column: "IdSucursal",
                principalTable: "Sucursal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_AspNetUsers_IdUsuario",
                table: "Mascota",
                column: "IdUsuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
