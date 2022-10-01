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
            get => _comprador;
            set { _comprador = value; }
        }
        private Vendedor _vendedor;
        public Vendedor Vendedor
        {
            get => _vendedor;
            set { _vendedor = value; }
        }
        private List<Produto> _vet_produto;
        public List<Produto> VetProduto
        {
            get => _vet_produto;
            set { _vet_produto = value; }
        }

        public Venda(Comprador comprador, Vendedor vendedor, List<Produto> vetProduto)
        {
            Comprador = comprador;
            Vendedor = vendedor;
            VetProduto = vetProduto;
        }
        
        public void MostrarAtributos()
        {
            
        }
    }
}