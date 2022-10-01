using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoVenda
{
    public class Comprador
    {
        private decimal _verba;
        public decimal Verba
        {
            get => _verba;
            set { _verba = value; }
        }

        public Comprador(decimal verba)
        {
            this.Verba = verba;
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine(
                $"Verba: {Verba:C2}");
        }
    }
}