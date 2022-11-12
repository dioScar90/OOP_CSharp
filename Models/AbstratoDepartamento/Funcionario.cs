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
        public List<Dependente> VetDependentes { get; set; }
        
        public Funcionario(int codigo, string nome, decimal salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public abstract decimal CalcularSalario(int diasUteis);

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:C}");
        }
        
        public virtual int CalcularTotalDependentes()
        {
            return VetDependentes.Count();
        }

        public void AdicionarDependente(Dependente novoDependente)
        {
            VetDependentes.Add(novoDependente);
        }

        public void RemoverDependenteMaioridade(int codigoDependente)
        {
            for (int i = 0; i < VetDependentes.Count(); i++)
            {
                if (VetDependentes[i].Codigo == codigoDependente)
                    VetDependentes.RemoveAt(i);
            }
        }

        public void ListarDependentes()
        {
            if (VetDependentes.Count() == 0)
            {
                Console.WriteLine($"Ainda não há dependentes para o funcionário {this.Nome}.");
            }
            else
            {
                foreach (var dependente in VetDependentes)
                {
                    string cod = dependente.Codigo.ToString().PadLeft(2, '0');
                    string nome = dependente.NomeDependente;
                    int idade = dependente.Idade;
                    Console.WriteLine($"Dependente {cod}: {nome}, {idade} anos de idade.");
                }
            }
        }
    }
}