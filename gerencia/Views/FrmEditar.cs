using gerencia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace gerencia.Views
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
            dateTimePicker.Enabled = false;
            datammyy.Enabled = false;
            btnCancelar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.ShowUpDown = true;

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
            DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o convidado selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
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
                    TimeSpan horaSelecionada = dateTimePicker.Value.TimeOfDay;
                    DateTime dataHoraSelecionada = DateTime.Today.Add(horaSelecionada);
                    string horaSelecionadaString = dataHoraSelecionada.ToString("HH:mm:ss");

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
                    evento.Horario = horaSelecionadaString;
                    evento.Localizacao = localizacao;
                    evento.Privacidade = privacidadeSelecionada;
                    context.SaveChanges();
                    MessageBox.Show("Evento editado");
                    limpar();

                }

            }
        }
        private void limpar()
        {
            inputId.Text = "";
            inputNome.Text = "";
            inputDescricao.Text = "";
            inputLocalizacao.Text = "";
            comboBoxPrivacidade.SelectedIndex = -1;
            inputNome.Enabled = false;
            inputDescricao.Enabled = false;
            inputLocalizacao.Enabled = false;
            comboBoxPrivacidade.Enabled = false;
            dateTimePicker.Enabled = false;
            datammyy.Enabled = false;
            btnCancelar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            inputId.Enabled = true;
        }

        private void btnBuscarid_Click(object sender, EventArgs e)
        {

            
            
            using (var context = new EventosContext())
            {
                try
                {
                    int id = int.Parse(inputId.Text);
                    var evento = context.Eventos.FirstOrDefault(e => e.IdEvento == id);
                    int num = UserSession.GetUserId();
                    if (num != evento.CriadorId)
                    {
                        MessageBox.Show("ID inserido não coresponde ao seus eventos", "Erro ID não existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpar();
                        return;
                    }
                    if (evento != null)
                    {
                        inputNome.Enabled = true;
                        inputDescricao.Enabled = true;
                        inputLocalizacao.Enabled = true;
                        comboBoxPrivacidade.Enabled = true;
                        dateTimePicker.Enabled = true;
                        btnEditar.Enabled = true;
                        btnCancelar.Enabled = true;
                        datammyy.Enabled = true;
                        inputId.Enabled = false;
                        btnCancelar.Enabled = true;
                        // Preenche os campos com os dados do evento
                        string horaString = evento.Horario; // valor do horário armazenado no banco de dados
                        DateTime hora = DateTime.ParseExact(horaString, "HH:mm:ss", CultureInfo.InvariantCulture);
                        dateTimePicker.Value = DateTime.Today.Add(hora.TimeOfDay);
                        inputNome.Text = evento.Nome;
                        inputDescricao.Text = evento.Descricao;
                        datammyy.Value = evento.Data;
                        dateTimePicker.Value = dateTimePicker.Value;
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
                    MessageBox.Show("Busque por um Id valido");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar? As alterações não serão salvas", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                inputNome.Enabled = false;
                inputDescricao.Enabled = false;
                inputLocalizacao.Enabled = false;
                comboBoxPrivacidade.Enabled = false;
                dateTimePicker.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                datammyy.Enabled = false;
                inputId.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                // código para continuar sem cancelar
            }


        }

        private void FrmEditar_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBuscarid_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
