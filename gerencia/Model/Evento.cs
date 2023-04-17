using gerencia.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gerencia.Model
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
        public Privacidade Privacidade { get; set; }
        public ICollection<Guest> Guests { get; set; }
    }

    public class Guest
    {
        public int IdGuest { get; set; }
        [ForeignKey("Evento")]
        public int IdEvento { get; set; }
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Evento Evento { get; set; }
        public Usuario UsuarioConvidado { get; set; }
    }

}