using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        public int Numero { get; set; }       
        public string Titular { get; set; }  
        public double Saldo { get; set; }

        // Conta objetoConta é uma referência
        public void TransferirDinheiro(double valor, Conta objetoConta) {
            Saldo = Saldo - valor;
            objetoConta.Saldo += valor;
        }
    }
}