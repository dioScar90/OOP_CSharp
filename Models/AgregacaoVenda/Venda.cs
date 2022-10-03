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
            this.Comprador = comprador;
            this.Vendedor = vendedor;
            this.VetProduto = vetProduto;
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine(
                $"O comprador tinha {Comprador.Verba:C2} de verba." +
                $"\nProdutos comprados: "
            );



            decimal valorTotal = 0;
            foreach (var item in VetProduto)
            {
                valorTotal += item.Preco;
                Console.WriteLine(
                    $"Código: {item.Codigo}" +
                    $"\tNome: {item.Nome}" +
                    $"\tPreço: {item.Preco:C2}"
                );
            }

            Comprador.Verba -= valorTotal;

            Console.WriteLine($"Total da venda: {valorTotal:C2}.");
            Console.WriteLine($"Comissão ao vendedor: {Vendedor.Comissao:C2}.");
            Console.WriteLine($"Saldo final do comprador: {Comprador.Verba:C2}.");
        }
    }
}