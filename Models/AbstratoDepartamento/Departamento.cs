using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoDepartamento
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetF { get; set; }
        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            VetF.Add(funcionario);
        }
    }
}