using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gerencia.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Eventos_IdEvento",
                table: "Guest");

            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Usuarios_UsuarioConvidadoIdUsuario",
                table: "Guest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guest",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_IdEvento",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_UsuarioConvidadoIdUsuario",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "UsuarioConvidadoIdUsuario",
                table: "Guest");

            migrationBuilder.RenameTable(
                name: "Guest",
                newName: "Guests");

            migrationBuilder.AddColumn<int>(
                name: "EventoIdEvento",
                table: "Guests",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guests",
                table: "Guests",
                column: "IdGuest");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Eventos_EventoIdEvento",
                table: "Guests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guests",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_EventoIdEvento",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "EventoIdEvento",
                table: "Guests");

            migrationBuilder.RenameTable(
                name: "Guests",
                newName: "Guest");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioConvidadoIdUsuario",
                table: "Guest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guest",
                table: "Guest",
                column: "IdGuest");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_IdEvento",
                table: "Guest",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_UsuarioConvidadoIdUsuario",
                table: "Guest",
                column: "UsuarioConvidadoIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Eventos_IdEvento",
                table: "Guest",
                column: "IdEvento",
                principalTable: "Eventos",
                principalColumn: "IdEvento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Usuarios_UsuarioConvidadoIdUsuario",
                table: "Guest",
                column: "UsuarioConvidadoIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
