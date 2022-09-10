using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public Conta() // Método construtor -> NUNCA usar return dentro de um método construtor.
        {

        }
        public Conta(int numero)
        {
            this.Numero = numero;
        }
        public Conta(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
    
        public void MostrarDados()
        {
            Console.WriteLine("" + 
                "Número da conta: " + Numero +
                "\tTitular: " + Titular +
                "\tSaldo: " + Saldo);
        }
    }
}