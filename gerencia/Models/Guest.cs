using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerencia.Models
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGuest { get; set; }
        [ForeignKey("Evento")]
        public int IdEvento { get; set; }
        public Evento Evento { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioConvidadoIdUsuario { get; set; }

        public Usuario UsuarioConvidado { get; set; }
    }
}
