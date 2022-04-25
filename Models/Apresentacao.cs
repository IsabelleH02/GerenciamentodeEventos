using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Apresentacao
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int duracao { get; set; }
        public DateTime hora { get; set; }
    }
}
