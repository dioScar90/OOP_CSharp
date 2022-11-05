using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        
        public ClienteJuridico(int codigo, string nome, int idade, int cnpj) : base(codigo, nome, idade)
        {
            Cnpj = cnpj;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"CNPJ: {Cnpj}.");
        }
        public override void VerificarIdade()
        {
            if (Idade >= 50)
                Console.WriteLine("Cliente Jurídico.");
        }
    }
}