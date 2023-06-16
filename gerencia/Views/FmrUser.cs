using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using gerencia.Models;

namespace gerencia.Views
{
    public partial class FmrUser : Form
    {
        public FmrUser()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (inputEmail.Text == "" || inputNome.Text == "" || inputSenha.Text == "")
            {
                MessageBox.Show("Prencha todos os campos",
                "Coloque seus dados e tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new EventosContext())
            {
                string email = inputEmail.Text;
                bool emailJaCadastrado = db.Usuarios.Any(u => u.EmailUsuario == email);
                if (emailJaCadastrado)
                {
                    MessageBox.Show("Este email já está sendo usado, por favor escolha outro.",
                    "Email já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inputEmail.Text = "";
                    inputNome.Text = "";
                    inputSenha.Text = "";

                    return;
                }
                else
                {
                    var novoUser = new Usuario
                    {
                        NomeUsuario = inputNome.Text,
                        EmailUsuario = email,
                        SenhaUsuario = inputSenha.Text

                    };
                    db.Usuarios.Add(novoUser);
                    db.SaveChanges();
                    MessageBox.Show("Cadastro realizado com sucesso!",
                    "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    var a = new FrmLogin();
                    a.Show();
                }
            }


        }

        private void FmrUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Voltar para a tela de login?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                var a = new FrmLogin();
                a.Show();
            }
        }


    }
}
