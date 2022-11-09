using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoDepartamento
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, decimal salario) : base(codigo, nome, salario)
        {
            //
        }
        public override decimal CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
    }
}