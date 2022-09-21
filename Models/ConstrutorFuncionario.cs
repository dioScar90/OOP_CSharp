using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.ConstrutorFuncionario
{
    public class Funcionario
    {
        // Declarar atributos e métodos com o encapsulamento
        // completo (propfull), validando a digitação do usuário e na
        // apresentação do atributo nome, mostrar em maiúsculo.
        
        public string Nome
        {
            get { return Nome.ToUpper(); }
            set { Nome = value; }
        }
    }
}