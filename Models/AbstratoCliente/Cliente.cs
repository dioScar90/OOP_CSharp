using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(int codigo, string nome, int idade)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Idade = idade;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"\nCódigo: {Codigo}\tNome: {Nome}.\tIdade: {Idade}.");
        }
        public abstract void VerificarIdade();

    }
}