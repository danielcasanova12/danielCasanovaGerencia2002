using gerencia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gerencia.Views
{
    public partial class FrmAdicionar : Form
    {
        public FrmAdicionar()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.ShowUpDown = true;
            comboBoxPrivacidade.SelectedIndex = 0;

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
            DateTime dataCompleta = datammyy.Value;
            DateTime data = dataCompleta.Date;
            string localizacao = inputLocalizacao.Text;
            string privacidade = comboBoxPrivacidade.Text;

            if (nome == "" || descricao == "" || localizacao == "")
            {
                MessageBox.Show("Prencha todos os campos",
                "Coloque seus dados e tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Privacidade privacidadeSelecionada = (Privacidade)Enum.Parse(typeof(Privacidade), privacidade);

            int num = UserSession.GetUserId();
            TimeSpan horaSelecionada = dateTimePicker.Value.TimeOfDay;
            DateTime dataHoraSelecionada = DateTime.Today.Add(horaSelecionada);
            string horaSelecionadaString = dataHoraSelecionada.ToString("HH:mm:ss");

            using (var db = new EventosContext())
            {
                var novoEvento = new Evento
                {
                    CriadorId = num,
                    Nome = nome,
                    Descricao = descricao,
                    Data = data,
                    Horario = horaSelecionadaString,
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var db = new EventosContext())
            {
                var evento = new Evento
                {
                    Nome = "Aniversário da Maria",
                    Descricao = "Festa de aniversário da Maria",
                    Data = new DateTime(2023, 04, 15),
                    Horario = "19:09:09",
                    Localizacao = "Rua 123, São Paulo",
                    Privacidade = Privacidade.SomenteConvidados,
                    CriadorId = UserSession.GetUserId(),
                    Guests = new List<Guest>
                    {
                        new Guest
                        {
                            UsuarioConvidado = new Usuario
                            {
                                Nome = "João",
                                Email = "joao@gmail.com",
                                Senha = "123456"
                            }
                        },
                        new Guest
                        {
                            UsuarioConvidado = new Usuario
                            {
                                Nome = "Maria",
                                Email = "maria@gmail.com",
                                Senha = "123456"
                            }
                        },
                        new Guest
                        {
                            UsuarioConvidado = new Usuario
                            {
                                Nome = "Joana",
                                Email = "Joana@gmail.com",
                                Senha = "123456"

                             }
                        },
                        new Guest
                        {
                            UsuarioConvidado = new Usuario
                            {
                                Nome = "Claudio",
                                Email = "Claudio@gmail.com",
                                Senha = "123456"

                             }
                        },
                        new Guest
                        {
                            UsuarioConvidado = new Usuario
                            {
                                Nome = "Daniel",
                                Email = "Daniel@gmail.com",
                                Senha = "123456"

                             }
                        },
                        new Guest
                        {
                            UsuarioConvidado = new Usuario
                            {
                                Nome = "Everton",
                                Email = "Everton@gmail.com",
                                Senha = "123456"

                             }
                        }
                    }
                };
                MessageBox.Show("Evento usuarios e guest cadastrados com sucesso!",
                        "Cadastros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.Eventos.Add(evento);
                db.SaveChanges();
            }

        }

        private void FrmAdicionar_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }

        private void datammyy_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
