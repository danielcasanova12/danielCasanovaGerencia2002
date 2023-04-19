
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
using WinFormsApp4.model;

namespace gerencia
{
    public partial class FrmAdicionar : Form
    {
        public FrmAdicionar()
        {
            InitializeComponent();
            cbM.SelectedIndex = 0;
            comboBoxPrivacidade.SelectedIndex = 0;
            cbH.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var db = new EventosContext())
            //{
            //    Usuario usuario = new Usuario();
            //    usuario.Nome = "samuca";
            //    usuario.Email = "squinalli212";
            //    usuario.Senha = "123sad123sd";
            //    db.SaveChanges();
            //}
        }

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
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

            int num = UserSession.GetUserId();


            using (var db = new EventosContext())
            {
                var novoEvento = new Evento
                {
                    CriadorId = num,
                    Nome = nome,
                    Descricao = descricao,
                    Data = data,
                    Horario = horario,
                    Localizacao = localizacao,
                    Privacidade = privacidadeSelecionada
                };
                db.Eventos.Add(novoEvento);
                db.SaveChanges();
            }
            MessageBox.Show("Evento cadastrado realizado com sucesso!",
                    "Cadastro de Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void cbM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    using (var db = new EventosContext())
            //    {
            //        var evento = new Evento
            //        {
            //            Nome = "Aniversário da Maria",
            //            Descricao = "Festa de aniversário da Maria",
            //            Data = new DateTime(2023, 04, 15),
            //            Horario = "19h",
            //            Localizacao = "Rua 123, São Paulo",
            //            Privacidade = Privacidade.SomenteConvidados,
            //            CriadorId = UserSession.GetUserId(),
            ////            Guests = new List<Guest>
            //{
            //    new Guest
            //    {
            //        UsuarioConvidado = new Usuario
            //        {
            //            Nome = "João",
            //            Email = "joao@gmail.com",
            //            Senha = "123456"
            //        }
            //    },
            //    new Guest
            //    {
            //        UsuarioConvidado = new Usuario
            //        {
            //            Nome = "Maria",
            //            Email = "maria@gmail.com",
            //            Senha = "123456"
            //        }
            //    }
            //}
            //        };

            //       db.Eventos.Add(evento);
            //        db.SaveChanges();
            // }

        }
    }
}
