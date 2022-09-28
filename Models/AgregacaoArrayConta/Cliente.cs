using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.AgregacaoArrayConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        // ctor
        public Cliente(string nome, string cpf, string rg)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
        }
    }
}