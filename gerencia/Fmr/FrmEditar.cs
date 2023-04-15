using gerencia.Model;
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

namespace gerencia
{
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
            inputNome.Enabled = false;
            inputDescricao.Enabled = false;
            inputLocalizacao.Enabled = false;
            comboBoxPrivacidade.Enabled = false;
            cbH.Enabled = false;
            cbM.Enabled = false;
            datammyy.Enabled = false;
            btnCancelar.Enabled = false;    

        }
        private void FrmEditar_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(inputId.Text);
            using (var context = new EventosContext())
            {
                var evento = context.Eventos.FirstOrDefault(e => e.IdEvento == id);
                int num = UserSession.GetUserId();
                if (num != evento.CriadorId)
                {
                    MessageBox.Show("ID inserido não coresponde ao seus eventos", "Erro ID não existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nome = inputNome.Text;
                string descricao = inputDescricao.Text;
                DateTime data = datammyy.Value;
                string localizacao = inputLocalizacao.Text;
                string privacidade = comboBoxPrivacidade.Text;
                string hora = cbH.Text;
                string min = cbM.Text;
                string horario = hora + ":" + min;

                if (nome == "" || descricao == "" || localizacao == "")
                {
                    MessageBox.Show("Prencha todos os campos",
                    "Coloque seus dados e tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                Privacidade privacidadeSelecionada = (Privacidade)Enum.Parse(typeof(Privacidade), privacidade);
                evento.Nome = nome;
                evento.Descricao = descricao;
                evento.Data = data;
                evento.Horario = horario;
                evento.Localizacao = localizacao;
                evento.Privacidade = privacidadeSelecionada;
                context.SaveChanges();
            }
        }

        private void btnBuscarid_Click(object sender, EventArgs e)
        {
            int id = int.Parse(inputId.Text);
            using (var context = new EventosContext())
            {
                try
                {
                    // Busca o evento no banco de dados pelo id
                    var evento = context.Eventos.FirstOrDefault(e => e.IdEvento == id);
                    int num = UserSession.GetUserId();
                    if (num != evento.CriadorId)
                    {
                        MessageBox.Show("ID inserido não coresponde ao seus eventos", "Erro ID não existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inputId.Text = "";
                        inputNome.Text = "";
                        inputDescricao.Text = "";
                        inputLocalizacao.Text = "";
                        comboBoxPrivacidade.SelectedIndex = -1;
                        return;
                    }
                    if (evento != null)
                    {
                        inputNome.Enabled = true;
                        inputDescricao.Enabled = true;
                        inputLocalizacao.Enabled = true;
                        comboBoxPrivacidade.Enabled = true;
                        cbH.Enabled = true;
                        cbM.Enabled = true;
                        datammyy.Enabled = true;
                        inputId.Enabled = false;
                        btnCancelar.Enabled = true;
                        // Preenche os campos com os dados do evento
                        inputNome.Text = evento.Nome;
                        inputDescricao.Text = evento.Descricao;
                        datammyy.Value = evento.Data;
                        inputLocalizacao.Text = evento.Localizacao;
                        comboBoxPrivacidade.SelectedIndex = (int)evento.Privacidade;
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado no banco de dados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao buscar o evento no banco de dados: " + ex.Message);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inputNome.Enabled = false;
            inputDescricao.Enabled = false;
            inputLocalizacao.Enabled = false;
            comboBoxPrivacidade.Enabled = false;
            cbH.Enabled = false;
            cbM.Enabled = false;
            datammyy.Enabled = false;
            inputId.Enabled = true;
        }
    }
}
