using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AbstratoDepartamento
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string NomeDependente { get; set; }
        public int Idade { get; set; }

        public Dependente(int codigo, string nomeDependente, int idade)
        {
            Codigo = codigo;
            NomeDependente = nomeDependente;
            Idade = idade;
        }

        public bool VerificaMaioridade()
        {
            return Idade >= 18 ? true : false;
        }
    }
}