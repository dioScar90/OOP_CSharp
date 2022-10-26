using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.HerancaCliente
{
    public class ClienteFisico : Cliente
    {
        private int _rg;
        public int RG
        {
            get { return _rg; }
            set { _rg = value; }
        }
        private int _cpf;
        public int CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public ClienteFisico()
        {
            
        }
        public ClienteFisico(int codigo, string nome, string endereco, int rg, int cpf) : base(codigo, nome, endereco)
        {
            this.RG = rg;
            this.CPF = cpf;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"RG: {RG}\tCPF: {CPF}");
        }
    }
}