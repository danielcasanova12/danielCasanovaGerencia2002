using gerencia.Models;
using gerencia.Controllers;
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
using gerencia.Views;

namespace gerencia

{
    public partial class FrmLogin : Form
    {
        private LoginController _loginController;
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            _loginController = new LoginController();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string senha = inputSenha.Text;
            if (_loginController.ValidarLogin(email, senha))
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }

}
