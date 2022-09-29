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
            get { return _comissao; }
            set { _comissao = value; }
        }
        
        public void MostrarAtributos()
        {
            //
        }
    }
}