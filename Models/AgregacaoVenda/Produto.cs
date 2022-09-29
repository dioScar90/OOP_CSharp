using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoVenda
{
    public class Produto
    {
        private int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        
        public void MostrarAtributos()
        {
            
        }
        
    }
}