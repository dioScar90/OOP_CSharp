using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.InterfaceAutenticavel
{
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }

        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Cliente autenticado");
                return true;
            }
            return false;
        }
    }
}