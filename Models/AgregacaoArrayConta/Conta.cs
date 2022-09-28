using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoArrayConta
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public List<Cliente> VetTitular { get; set; }
    }
}