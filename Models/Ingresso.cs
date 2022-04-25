using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ingresso
    {
        public int Id { get; set; }

        public Evento evento { get; set; }
    }
}
