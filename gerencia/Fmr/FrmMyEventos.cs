using gerencia.Fmr;
using gerencia.Model;
using Microsoft.VisualStudio.VSHelp80;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerencia
{
    public partial class FrmMyEventos : Form
    {
        private int idSelecionado = 0;
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
                idSelecionado = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["IdEvento"].Value);
            }
        }
        private void FrmMyEventos_Load(object sender, EventArgs e)
        {

            using (var context = new EventosContext())
            {
                int idUsuarioLogado = UserSession.GetUserId();
                var eventos = context.Eventos.Where(e => e.CriadorId == idUsuarioLogado).ToList();

                dataGridView2.DataSource = eventos;

                //// Define as colunas "Criador" e "Id" como invisíveis
                dataGridView2.Columns["Criador"].Visible = false;
                dataGridView2.Columns["CriadorId"].Visible = false;
                dataGridView2.Columns["Guests"].Visible = false;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                var eventosConvidado = context.Eventos.Where(e => e.Guests.Any(g => g.UsuarioConvidado.IdUsuario == idUsuarioLogado)).ToList();
                dataGridView3.DataSource = eventosConvidado;
                dataGridView3.Columns["Criador"].Visible = false;
                dataGridView3.Columns["CriadorId"].Visible = false;
                dataGridView3.Columns["IdEvento"].Visible = false;
                dataGridView3.Columns["Guests"].Visible = false;
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
                var evento = context.Eventos.FirstOrDefault(e => e.IdEvento == idSelecionado);
                if (evento != null)
                {
                    Privacidade privacidade = evento.Privacidade;
                    if (privacidade != Privacidade.Publico)
                    {
                        FrmConvidados tela2 = new FrmConvidados(idSelecionado);
                        tela2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Eventos com privacidade publica não tem convidados");
                    }


                }
                
            }

            if(idSelecionado == 0)
            {
                MessageBox.Show("Para adicionar convidados selecione o evento");
            }
        }
    }
}
