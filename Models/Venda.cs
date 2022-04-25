using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime data { get; set; }
        public Cliente cliente { get; set; }
        public Vendedor vendedor { get; set; }
        public Ingresso ingresso { get; set; }

    }
}
