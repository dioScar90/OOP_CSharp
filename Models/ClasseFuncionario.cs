using System;

namespace OOP_CSharp.ClasseFuncionario
{
    public class Funcionario
    {
        // Declaração dos atributos (variáveis).
        public int codigo;
        public string nome;
        public double salario;
        // Declarar os métodos (funções).
        public void MostrarAtributos() {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário: " + salario);
        }
    }
}