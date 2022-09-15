using System;

namespace OOP_Teste.ArrayProduto
{
    public class Produto
    {
        // Declaração dos atributos (variáveis).
        public int codigo;
        public string nome;
        public double salario;
        // Declarar os métodos (funções).
        public void CalcularAumento(double porcentagem) {
            porcentagem += 1;
            salario *= porcentagem;
        }
        public void MostrarAtributos() {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário: " + salario);
        }
    }
}