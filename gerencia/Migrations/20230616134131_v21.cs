using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gerencia.Migrations
{
    public partial class v21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Usuarios_CriadorId",
                table: "Eventos");

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
                name: "IX_Eventos_CriadorId",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "SenhaUsuario");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "NomeUsuario");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "EmailUsuario");

            migrationBuilder.RenameColumn(
                name: "UsuarioConvidadoIdUsuario",
                table: "Guests",
                newName: "UsuarioGuestIdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdEvento",
                table: "Guests",
                newName: "IdEventoGuest");

            migrationBuilder.RenameIndex(
                name: "IX_Guests_UsuarioConvidadoIdUsuario",
                table: "Guests",
                newName: "IX_Guests_UsuarioGuestIdUsuario");

            migrationBuilder.RenameColumn(
                name: "Privacidade",
                table: "Eventos",
                newName: "PrivacidadeEvento");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Eventos",
                newName: "NomeEvento");

            migrationBuilder.RenameColumn(
                name: "Localizacao",
                table: "Eventos",
                newName: "LocalizacaoEvento");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "Eventos",
                newName: "HorarioEvento");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Eventos",
                newName: "DescricaoEvento");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Eventos",
                newName: "DataEvento");

            migrationBuilder.RenameColumn(
                name: "CriadorId",
                table: "Eventos",
                newName: "IdCriadorEvento");

            migrationBuilder.AddColumn<int>(
                name: "EventoGuestIdEvento",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CriadorEventoIdUsuario",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Guests_EventoGuestIdEvento",
                table: "Guests",
                column: "EventoGuestIdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CriadorEventoIdUsuario",
                table: "Eventos",
                column: "CriadorEventoIdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Usuarios_CriadorEventoIdUsuario",
                table: "Eventos",
                column: "CriadorEventoIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Eventos_EventoGuestIdEvento",
                table: "Guests",
                column: "EventoGuestIdEvento",
                principalTable: "Eventos",
                principalColumn: "IdEvento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Usuarios_UsuarioGuestIdUsuario",
                table: "Guests",
                column: "UsuarioGuestIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Usuarios_CriadorEventoIdUsuario",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Eventos_EventoGuestIdEvento",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Usuarios_UsuarioGuestIdUsuario",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_EventoGuestIdEvento",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_CriadorEventoIdUsuario",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "EventoGuestIdEvento",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "CriadorEventoIdUsuario",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "SenhaUsuario",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "NomeUsuario",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "EmailUsuario",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UsuarioGuestIdUsuario",
                table: "Guests",
                newName: "UsuarioConvidadoIdUsuario");

            migrationBuilder.RenameColumn(
                name: "IdEventoGuest",
                table: "Guests",
                newName: "IdEvento");

            migrationBuilder.RenameIndex(
                name: "IX_Guests_UsuarioGuestIdUsuario",
                table: "Guests",
                newName: "IX_Guests_UsuarioConvidadoIdUsuario");

            migrationBuilder.RenameColumn(
                name: "PrivacidadeEvento",
                table: "Eventos",
                newName: "Privacidade");

            migrationBuilder.RenameColumn(
                name: "NomeEvento",
                table: "Eventos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "LocalizacaoEvento",
                table: "Eventos",
                newName: "Localizacao");

            migrationBuilder.RenameColumn(
                name: "IdCriadorEvento",
                table: "Eventos",
                newName: "CriadorId");

            migrationBuilder.RenameColumn(
                name: "HorarioEvento",
                table: "Eventos",
                newName: "Horario");

            migrationBuilder.RenameColumn(
                name: "DescricaoEvento",
                table: "Eventos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "DataEvento",
                table: "Eventos",
                newName: "Data");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_IdEvento",
                table: "Guests",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CriadorId",
                table: "Eventos",
                column: "CriadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Usuarios_CriadorId",
                table: "Eventos",
                column: "CriadorId",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);

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
    }
}
