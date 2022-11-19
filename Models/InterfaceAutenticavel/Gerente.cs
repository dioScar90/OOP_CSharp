using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.InterfaceAutenticavel
{
    public class Gerente : Funcionario, IAutenticavel
    {

        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Gerente autenticado");
                return true;
            }
            return false;
        }
    }
}