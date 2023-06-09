﻿using gerencia.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gerencia.Views
{
    public partial class FrmConvidados : Form
    {
        private int _numeroRecebido;
        public FrmConvidados(int numero)
        {
            InitializeComponent();
            this.CenterToScreen();
            this._numeroRecebido = numero;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmConvidados_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using (var context = new EventosContext())
            {
                var evento = context.Eventos.FirstOrDefault(e => e.GetIdEvento() == _numeroRecebido);
                if (evento != null)
                {
                    string email = inputEmail.Text;
                    var usuarioExistente = context.Usuarios.FirstOrDefault(u => u.EmailUsuario == email);

                    if (usuarioExistente != null)
                    {
                        int eventoId = evento.GetIdEvento();
                        var guestExistente = context.Guests.FirstOrDefault(g => g.UsuarioGuest.EmailUsuario == email && g.EventoGuestIdEvento == eventoId);
                        if (guestExistente != null)
                        {
                            MessageBox.Show("Esse usuário já foi convidado!");
                            return;
                        }

                        int idUser = usuarioExistente.IdUsuario;
                        var guest1 = new Guest
                        {
                            UsuarioGuestIdUsuario = idUser,
                            EventoGuestIdEvento = eventoId
                        };

                        context.Guests.Add(guest1);
                        context.SaveChanges();

                        MessageBox.Show("Convite enviado");
                    }
                    else
                    {
                        MessageBox.Show("O e-mail informado não foi encontrado.");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmConvidados_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

