using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Evento
    {
        public int Id { get; set; }

        public string nome { get; set; }

        public DateTime data { get; set; }

        public Endereco endereco { get; set; }

        public Tipo tipo { get; set; }

        public int capacidade { get; set; }

        public List<Apresentacao> apresentacao { get; set; }

        public int duracao { get; set; }
    }
}
