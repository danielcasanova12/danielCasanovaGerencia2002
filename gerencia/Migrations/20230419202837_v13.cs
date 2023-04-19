using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gerencia.Migrations
{
    public partial class v13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Eventos_EventoIdEvento",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_EventoIdEvento",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "EventoIdEvento",
                table: "Guests");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioConvidadoIdUsuario",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_IdEvento",
                table: "Guests",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_UsuarioConvidadoIdUsuario",
                table: "Guests",
                column: "UsuarioConvidadoIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Eventos_IdEvento",
                table: "Guests",
                column: "IdEvento",
                principalTable: "Eventos",
                principalColumn: "IdEvento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Usuarios_UsuarioConvidadoIdUsuario",
                table: "Guests",
                column: "UsuarioConvidadoIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Eventos_IdEvento",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Usuarios_UsuarioConvidadoIdUsuario",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_IdEvento",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_UsuarioConvidadoIdUsuario",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "UsuarioConvidadoIdUsuario",
                table: "Guests");

            migrationBuilder.AddColumn<int>(
                name: "EventoIdEvento",
                table: "Guests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_EventoIdEvento",
                table: "Guests",
                column: "EventoIdEvento");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Eventos_EventoIdEvento",
                table: "Guests",
                column: "EventoIdEvento",
                principalTable: "Eventos",
                principalColumn: "IdEvento");
        }
    }
}
