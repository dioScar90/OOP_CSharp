using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.ComposicaoBanco
{
    public class ContaCorrente
    {
        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        private decimal _cheque_especial;
        public decimal ChequeEspecial
        {
            get { return _cheque_especial; }
            set { _cheque_especial = value; }
        }

        public ContaCorrente(decimal saldo, decimal chequeEspecial)
        {
            this.Saldo = saldo;
            this.ChequeEspecial = chequeEspecial;
        }
        
        ~ContaCorrente()
        {
            
        }
    }
}