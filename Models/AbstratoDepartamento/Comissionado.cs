using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoDepartamento
{
    public class Comissionado : Funcionario
    {
        public decimal Porcentagem { get; set; }
        public Comissionado(int codigo, string nome, decimal salario, decimal porcentagem) : base(codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }
        public override decimal CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis * Porcentagem + Salario;
        }
        public override void MostrarDados()
        {
            base.MostrarDados();
            Console.WriteLine($"Porcentagem: {Porcentagem * 100}%");
        }
    }
}