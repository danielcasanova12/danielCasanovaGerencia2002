﻿using gerencia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.model;
namespace gerencia
{
    public partial class FrmRemover : Form
    {
        private int idSelecionado;
        public FrmRemover()
        {
            InitializeComponent();
            dataGridView5.ReadOnly = true;
            dataGridView5.CellClick += new DataGridViewCellEventHandler(dataGridView5_CellClick);
        }


        private void FrmRemover_Load(object sender, EventArgs e)
        {
            AtualizarListaEventos();
        }
        private void AtualizarListaEventos()
        {
            using (var db = new EventosContext())
            {
                int idUsuarioLogado = UserSession.GetUserId();
                var eventos = db.Eventos.Where(e => e.CriadorId == idUsuarioLogado).ToList();
                dataGridView5.DataSource = eventos;
                dataGridView5.Columns["Criador"].Visible = false;
                dataGridView5.Columns["CriadorId"].Visible = false;
                dataGridView5.Columns["Guests"].Visible = false;
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idUsuarioLogado = UserSession.GetUserId();
            String pesquisa = inputRemover.Text;
            if (pesquisa == "")
            {
                using (var db = new EventosContext())
                {
                    var eventos = db.Eventos.Where(e => e.CriadorId == idUsuarioLogado).ToList();
                    dataGridView5.DataSource = eventos;
                    dataGridView5.Columns["Criador"].Visible = false;
                    dataGridView5.Columns["CriadorId"].Visible = false;
                    dataGridView5.Columns["IdEvento"].Visible = false;
                    dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    return;
                }
            }
            if (int.TryParse(inputRemover.Text, out int result))
            {
                int pesquisa2 = int.Parse(inputRemover.Text);
                using (var db = new EventosContext())
                {
                    var eventosPublicos = db.Eventos.Where(e => e.IdEvento == pesquisa2 && e.CriadorId == idUsuarioLogado).ToList();
                    dataGridView5.DataSource = eventosPublicos;
                    dataGridView5.Columns["Criador"].Visible = false;
                    dataGridView5.Columns["CriadorId"].Visible = false;
                    dataGridView5.Columns["IdEvento"].Visible = false;
                    dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            else
            {
                using (var db = new EventosContext())
                {
                    var eventosPublicos = db.Eventos.Where((e => (e.Nome.Contains(pesquisa) || e.Localizacao.Contains(pesquisa)) && e.CriadorId == idUsuarioLogado)).ToList();
                    dataGridView5.DataSource = eventosPublicos;
                    dataGridView5.Columns["Criador"].Visible = false;
                    dataGridView5.Columns["CriadorId"].Visible = false;
                    dataGridView5.Columns["IdEvento"].Visible = false;
                    dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula e não no cabeçalho da coluna
            if (e.RowIndex >= 0)
            {
                // Obtém o valor da célula na coluna de ID da linha selecionada
                dataGridView5.Rows[e.RowIndex].Selected = true;
                //idSelecionado = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }
        private void btnRmover_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um evento para remover.");
                return;
            }

            var selectedEvent = (Evento)dataGridView5.SelectedRows[0].DataBoundItem;

            var confirmResult = MessageBox.Show("Tem certeza de que deseja remover o evento selecionado?", "Confirmação de Remoção", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new EventosContext())
                {
                    db.Eventos.Remove(selectedEvent);
                    db.SaveChanges();
                }

                MessageBox.Show("Evento removido com sucesso!");
                AtualizarListaEventos();
            }
        }
    }
}
