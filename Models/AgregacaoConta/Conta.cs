using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoConta
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Titular { get; set; }
    }
}