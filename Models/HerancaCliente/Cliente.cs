using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.HerancaCliente
{
    public class Cliente
    {
        protected int _codigo;
        public int Codigo;
        protected string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public Cliente()
        {
            
        }

        public Cliente(int codigo, string nome, string endereco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tEndereço: {Endereco}");
        }
    }
}