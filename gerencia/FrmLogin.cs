using gerencia.Model;
using System.Linq;
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
using gerencia.Fmr;

namespace gerencia

{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string senha = inputSenha.Text;
            if (ValidarLogin(email, senha))
            {
                // Se o login for válido, abre o formulário principal
                var a = new Frm_principal();
                a.Show();
                this.Hide();
            }
            else
            {
                // Se o login for inválido, exibe uma mensagem de erro
                MessageBox.Show("Usuário ou senha incorretos", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Função para validar o login do usuário
        private bool ValidarLogin(string email, string senha)
        {
            using (var db = new EventosContext())
            {
                // consultar a tabela de usuários usando LINQ
                var usuario = db.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

                // verificar se o usuário foi encontrado
                if (usuario != null)
                {
                    UserSession.SetUserId(usuario.IdUsuario); //usuario.IdUsuario
                    return true;
                }
                else
                {
                    // usuário não encontrado, mostrar mensagem de erro
                    MessageBox.Show("Email ou senha incorretos.");
                }
                return false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // fecha o formulário de login
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var criarUser = new FmrUser();
            criarUser.Show();
            this.Hide();
        }
    }

}
