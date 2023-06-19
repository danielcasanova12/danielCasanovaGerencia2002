using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerencia.Models
{
    public class Guest : Entidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGuest { get; set; }
        [ForeignKey("Evento")]
        public int IdEventoGuest { get; set; }
        public Evento EventoGuest { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioGuestIdUsuario { get; set; }
        public int EventoGuestIdEvento { get; set; }
        public Usuario UsuarioGuest { get; set; }




        public override void ExibirInformacoes()
        {
            Console.WriteLine(IdEventoGuest);
            Console.WriteLine(EventoGuest);
            Console.WriteLine(UsuarioGuestIdUsuario);
            Console.WriteLine(EventoGuestIdEvento);
            Console.WriteLine(UsuarioGuest);

        }

    }
}
