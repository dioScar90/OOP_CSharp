using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.InterfaceAutenticavel
{
    public interface IAutenticavel
    {
        bool Autenticar(int senha);  
    }
}