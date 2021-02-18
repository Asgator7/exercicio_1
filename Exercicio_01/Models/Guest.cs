using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_01.Models
{
    public class Guest
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Telefone { get; set; }
        public bool? comparecimento { get; set; }
    }
}
