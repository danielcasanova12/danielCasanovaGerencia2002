using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gerencia.Models
{
    public class Usuario : Entidade // HERANÇA POLIMORFISMO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required]
        public string NomeUsuario { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string EmailUsuario { get; set; }

        [Required]
        public string SenhaUsuario { get; set; }


        public override void ExibirInformacoes()
        {
            Console.WriteLine(NomeUsuario);
            Console.WriteLine(EmailUsuario);
            // ABSTRAÇÃO
        }

    }


}








