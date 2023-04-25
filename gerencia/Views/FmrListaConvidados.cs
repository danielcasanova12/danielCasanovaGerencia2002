using gerencia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerencia.Views
{
    public partial class FmrListaConvidados : Form
    {
        private int _numero = 0;
        private int _idSelecionado;
        private int _pagina;
        public FmrListaConvidados(int numero,int pagina)
        {
            InitializeComponent();
            this.CenterToScreen();
            this._numero = numero;
            this._pagina = pagina;
            dataGridView2.ReadOnly = true;
            dataGridView2.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellCClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDeletar_Click(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FmrListaConvidados_Load(object sender, EventArgs e)
        {
            atualiza();
            if(_pagina == 0)
            {
                BtnDeletar.Enabled = false;
            }
        }
        private void atualiza()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (var db = new EventosContext())
            {
                // Obter todos os convidados do evento com id 3
                var convidados = (from g in db.Guests
                                  where g.IdEvento == _numero
                                  select new
                                  {
                                      IdGuest = g.IdGuest,
                                      Nome = g.UsuarioConvidado.Nome,
                                      Email = g.UsuarioConvidado.Email
                                  }).ToList();
                var bindingSource = new BindingSource();
                bindingSource.DataSource = convidados;
                dataGridView2.DataSource = bindingSource;
                dataGridView2.Columns["IdGuest"].Visible = false;
                // Encontrar a coluna correspondente à propriedade IdGuest e definir sua propriedade Visible como false


            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula e não no cabeçalho da coluna
            if (e.RowIndex >= 0)
            {
                // Obtém o valor da célula na coluna de ID da linha selecionada
                _idSelecionado = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["IdGuest"].Value);
            }
        }


        private void BtnDeletar_Click(object sender, EventArgs e)
        {
        
            try
            {
                if(_idSelecionado != 0)
                {
                    DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o convidado selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (var db = new EventosContext())
                        {
                            var guestToRemove = db.Guests.Find(_idSelecionado);
                            if (guestToRemove != null)
                            {
                                db.Guests.Remove(guestToRemove);
                                db.SaveChanges();
                                MessageBox.Show("Convidado removido");
                                _idSelecionado = 0;
                            }
                        }
                        atualiza();


                    }

                }
                else
                {
                    MessageBox.Show("Selecione um convidado para excluir");
                }

            }
            catch
            {
                MessageBox.Show("Selecione um convidado para excluir");

            }

               // 
            
        }
    }
}
