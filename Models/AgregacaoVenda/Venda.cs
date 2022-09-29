using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoVenda
{
    public class Venda
    {
        private Comprador _comprador;
        public Comprador Comprador
        {
            get { return _comprador; }
            set { _comprador = value; }
        }
        private Vendedor _vendedor;
        public Vendedor Vendedor
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }
        private List<Produto> _vet_produto;
        public List<Produto> VetProduto
        {
            get { return _vet_produto; }
            set { _vet_produto = value; }
        }

        public Venda()
        {
            
        }
        
        public void MostrarAtributos()
        {
            
        }
    }
}