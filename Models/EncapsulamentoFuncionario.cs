using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.EncapsulamentoFuncionario
{
    public class Funcionario
    {
        // declaração dos atributos
        private int codigo;
        private string nome;
        private double salario;

        // encapsulamento
        // declaração dos métodos get e se
        /*public int Codigo //propriedade
        {
            get { return codigo; }
            set { codigo = value; }
        } */
        public int Codigo //propriedade
        {
            get => codigo; // get
            set => codigo = value; // set, pq tem atribuição =
        }

        public string Nome //propriedade
        {
            get { return nome; }
            set 
            { 
                if (value != "")
                    nome = value; 
            else
                Console.WriteLine("Nome deve ter conteúdo");
            }
        }

        public double Salario //propriedade
        {
            get { return salario; }
            set 
            { 
                if (value > 0) // value pode ser qualquer coisa, em java temos que colocar o tipo
                    salario = value; // Value vem da Main()
                else
                    Console.WriteLine("Salário Inválido");
                    System.Console.WriteLine();
            }
        }
        public void MostrarAtributos(){
            Console.WriteLine("Código: " + codigo + 
                            "\tNome: " + nome +
                            "\tSalário: " + salario);
        }
    }
}