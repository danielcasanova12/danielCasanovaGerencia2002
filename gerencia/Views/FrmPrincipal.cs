using System.Windows.Forms;
using gerencia.Models;

namespace gerencia.Views
{
    public partial class Frm_principal : Form
    {
        private Form frmAtivo;
        public Frm_principal()
        {
            InitializeComponent();
            AtualizarListaEventos();
            dataGridView1.ReadOnly = true;
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula e não no cabeçalho da coluna
            if (e.RowIndex >= 0)
            {
                // Obtém o valor da célula na coluna de ID da linha selecionada
                dataGridView1.Rows[e.RowIndex].Selected = true;
                //idSelecionado = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;
            frmAtivo.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarListaEventos();

        }
        private void AtualizarListaEventos()
        {
            using (var db = new EventosContext())
            {
                var eventosPublicos = db.Eventos.Where(e => e.Privacidade == Privacidade.Publico).ToList();
                dataGridView1.DataSource = eventosPublicos;
                dataGridView1.Columns["Criador"].Visible = false;
                dataGridView1.Columns["CriadorId"].Visible = false;
                dataGridView1.Columns["IdEvento"].Visible = false;
                dataGridView1.Columns["Guests"].Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }






        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
            AtualizarListaEventos();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActiveButton(btnBuscar);
            FormShow(new FrmBuscar());

        }

        private void btnMyEventos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnMyEventos);
            FormShow(new FrmMyEventos());
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ActiveButton(btnRemover);
            FormShow(new FrmRemover());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActiveButton(btnEditar);
            FormShow(new FrmEditar());
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ActiveButton(btnAdicionar);
            FormShow(new FrmAdicionar());


        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelForm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

        
    }
}








