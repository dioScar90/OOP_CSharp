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
            get { return _verba; }
            set { _verba = value; }
        }
        
        public void MostrarAtributos()
        {
            
        }
    }
}