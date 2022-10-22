using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.ComposicaoBanco
{
    public class Poupanca
    {
        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        
        public Poupanca(decimal saldo)
        {
            this.Saldo = saldo;
        }

        ~Poupanca()
        {
            
        }
    }
}