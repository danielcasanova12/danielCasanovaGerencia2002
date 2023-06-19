using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerencia.Models
{
    public abstract class Entidade
    {
        public string Detalhes { get; set; }



        public virtual void ExibirInformacoes()
        {
            Console.WriteLine(Detalhes);
        }
    }
}
