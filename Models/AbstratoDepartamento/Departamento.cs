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
        public void AdmitirFuncionario(Funcionario funcionario)
        {
            VetF.Add(funcionario);
        }

        public void DemitirFuncionario(int codigo)
        {
            for (int i = 0; i < VetF.Count(); i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);
            }
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("\nListagem de funcionários....................................:");
            foreach (var funcionario in VetF)
            {
                funcionario.MostrarDados();
            }
        }

        public decimal CalcularFolhaPagamento(int diasUteis)
        {
            decimal folha = 0;
            for (int i = 0; i < VetF.Count(); i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}