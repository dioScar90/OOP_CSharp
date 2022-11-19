using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.InterfaceAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Diretor autenticado");
                return true;
            }
            return false;
        }
    }
}