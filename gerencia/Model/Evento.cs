using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.model
{
    public enum Privacidade
    {
        Publico,
        Privado,
        SomenteConvidados
    }
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }
        [ForeignKey("Usuario")]
        public int CriadorId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(400)]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Horario { get; set; }
        public string Localizacao { get; set; }
        public Usuario Criador { get; set; }
        [Required]
        public Privacidade Privacidade { get; set; }
        public ICollection<Guest> Guests { get; set; }

    }




    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

    }


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
