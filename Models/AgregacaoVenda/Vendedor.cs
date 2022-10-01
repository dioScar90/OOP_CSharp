using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoVenda
{
    public class Vendedor
    {
        private decimal _comissao;
        public decimal Comissao
        {
            get => _comissao;
            set { _comissao = value * 2 / 100; }
        }

        public Vendedor(decimal comissao)
        {
            this.Comissao = comissao;
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine(
                $"Comissão: {Comissao:C2}");
        }
    }
}