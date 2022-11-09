using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoDepartamento
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public abstract decimal CalcularSalario(int diasUteis);
        public virtual void MostrarDados()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:C}");
        }
        public Funcionario(int codigo, string nome, decimal salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
    }
}