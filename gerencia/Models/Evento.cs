using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerencia.Enuns;

namespace gerencia.Models
{

    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }
        [ForeignKey("Usuario")]
        public int IdCriadorEvento { get; set; }
        [Required, MaxLength(100)]
        public string NomeEvento { get; set; }
        [MaxLength(400)]
        public string DescricaoEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public string HorarioEvento { get; set; }
        public string LocalizacaoEvento { get; set; }
        public Usuario CriadorEvento { get; set; }
        [Required]
        public Privacidade PrivacidadeEvento { get; set; }
        public int CriadorEventoIdUsuario  { get; set; }
        public ICollection<Guest> GuestsEvento { get; set; }

    }











}
