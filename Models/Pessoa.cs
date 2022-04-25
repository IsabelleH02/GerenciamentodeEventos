using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Pessoa : IPessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        public string PrintTelephone()
        {
            return Telephone;
        }

        public override string ToString()
        {
            return "Id: " + Id +
                 "\nNome: " + Name +
                 "\nTelefone: " + Telephone;
        }

        public virtual int GetNumberOfCaracters(string text)
        {
            return text.Length;
        }

    }

}
