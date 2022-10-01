using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoVenda
{
    public class Produto
    {
        private static int s_codigoCount;
        public static int CodigoCount
        {
            get => s_codigoCount;
            private set { s_codigoCount += value; }
        }
        private int _codigo;
        public int Codigo
        {
            get => _codigo;
            private set { _codigo = s_codigoCount; }
        }
        private string _nome;
        public string Nome
        {
            get => _nome;
            set { _nome = value; }
        }
        private decimal _preco;
        public decimal Preco
        {
            get => _preco;
            set { _preco = value; }
        }

        static Produto()
        {
            CodigoCount = 500;
        }

        public Produto(string nome, decimal preco)
        {
            CodigoCount = 1;
            Codigo = CodigoCount;
            Nome = nome;
            Preco = preco;
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine(
                $"Código: {Codigo}" +
                $"\tNome: {Nome}" +
                $"\tPreço: {Preco:C2}");
        }
        
    }
}