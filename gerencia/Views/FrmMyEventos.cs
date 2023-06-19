using gerencia.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gerencia.Models;
using gerencia.Enuns;

namespace gerencia.Views
{
    public partial class FrmMyEventos : Form
    {
        private int _idSelecionado = 0;
        private int _pagina = 1;
        public FrmMyEventos()
        {
            InitializeComponent();
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dataGridView2.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula e não no cabeçalho da coluna
            if (e.RowIndex >= 0)
            {
                // Obtém o valor da célula na coluna de ID da linha selecionada
                dataGridView2.Rows[e.RowIndex].Selected = true;
                _idSelecionado = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["IdEvento"].Value);
            }
        }
        private void FrmMyEventos_Load(object sender, EventArgs e)
        {

            using (var context = new EventosContext())
            {
                int idUsuarioLogado = UserSession.GetUserId();
                var eventos = context.Eventos.Where(e => e.IdCriadorEvento == idUsuarioLogado).ToList();

                dataGridView2.DataSource = eventos;

                //// Define as colunas "Criador" e "Id" como invisíveis
                dataGridView2.Columns["CriadorEvento"].Visible = false;
                dataGridView2.Columns["IdCriadorEvento"].Visible = false;
                dataGridView2.Columns["GuestsEvento"].Visible = false;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                var eventosConvidado = context.Eventos.Where(e => e.GuestsEvento.Any(g => g.UsuarioGuestIdUsuario == idUsuarioLogado)).ToList();
                dataGridView3.DataSource = eventosConvidado;
                dataGridView3.Columns["CriadorEvento"].Visible = false;
                dataGridView3.Columns["IdCriadorEvento"].Visible = false;
                dataGridView3.Columns["IdEvento"].Visible = false;
                dataGridView3.Columns["GuestsEvento"].Visible = false;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnConvidados_Click(object sender, EventArgs e)
        {
            using (var context = new EventosContext())
            {
                var evento = context.Eventos.FirstOrDefault(e => e.GetIdEvento() == _idSelecionado);
                if (evento != null)
                {
                    Privacidade privacidade = evento.PrivacidadeEvento;
                    if (privacidade != Privacidade.Publico)
                    {
                        FrmConvidados tela2 = new FrmConvidados(_idSelecionado);
                        tela2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Eventos com privacidade publica não tem convidados");
                    }


                }

            }

            if (_idSelecionado == 0)
            {
                MessageBox.Show("Para adicionar convidados selecione o evento");
            }
        }

        private void FrmMyEventos_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConvidados_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new EventosContext())
                {
                    var evento = context.Eventos.FirstOrDefault(e => e.GetIdEvento() == _idSelecionado);
                    if (evento != null)
                    {
                        var convidados = context.Guests.Where(c => c.EventoGuestIdEvento == _idSelecionado).ToList();
                        if (convidados.Any())
                        {
                            FmrListaConvidados tela2 = new FmrListaConvidados(_idSelecionado, _pagina);
                            tela2.Show();
                        }
                        else
                        {
                            MessageBox.Show("O evento selecionado não tem convidados.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Evento não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os convidados do evento: " + ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
