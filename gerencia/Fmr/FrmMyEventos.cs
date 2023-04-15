using gerencia.Fmr;
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

namespace gerencia
{
    public partial class FrmMyEventos : Form
    {
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
                //idSelecionado = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["Id"].Value);
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
                dataGridView2.Columns["IdEvento"].Visible = false;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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


    }
}
