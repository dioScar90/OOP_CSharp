using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public static int Contador { get; private set; }
        
        static Conta() // Construtor estático.
        {
            Contador = 30;
        }

        public Conta() // Método construtor -> NUNCA usar return dentro de um método construtor.
        {
            Contador++;
        }
        public Conta(int numero)
        {
            this.Numero = numero;
            Contador++;
        }
        public Conta(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
            Contador++;
        }
        public Conta(int numero, string titular, decimal saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            Contador++;
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