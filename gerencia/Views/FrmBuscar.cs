
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

namespace gerencia.Views
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
            dataGridView4.CellClick += new DataGridViewCellEventHandler(dataGridView4_CellClick);
            dataGridView4.ReadOnly = true;
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula e não no cabeçalho da coluna
            if (e.RowIndex >= 0)
            {
                // Obtém o valor da célula na coluna de ID da linha selecionada
                dataGridView4.Rows[e.RowIndex].Selected = true;
                //idSelecionado = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            AtualizarListaEventos();
            
        }
        private void AtualizarListaEventos()
        {
            using (var db = new EventosContext())
            {
                var eventosPublicos = db.Eventos.Where(e => e.Privacidade == Privacidade.Publico).ToList();
                dataGridView4.DataSource = eventosPublicos;
                dataGridView4.Columns["Criador"].Visible = false;
                dataGridView4.Columns["CriadorId"].Visible = false;
                dataGridView4.Columns["IdEvento"].Visible = false;
                dataGridView4.Columns["Guests"].Visible = false;
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

            private void btnBuscarid_Click(object sender, EventArgs e)
        {
            String pesquisa = inputPesquisa.Text;
            if (pesquisa == "")
            {
                AtualizarListaEventos();
            }
            else
            {
                using (var db = new EventosContext())
                {
                    var eventosPublicos = db.Eventos.Where(e => e.Nome.Contains(pesquisa) || e.Localizacao.Contains(pesquisa)).ToList();
                    dataGridView4.DataSource = eventosPublicos;
                    dataGridView4.Columns["Criador"].Visible = false;
                    dataGridView4.Columns["CriadorId"].Visible = false;
                    dataGridView4.Columns["IdEvento"].Visible = false;
                    dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBuscar_Load_1(object sender, EventArgs e)
        {

        }
    }
}
