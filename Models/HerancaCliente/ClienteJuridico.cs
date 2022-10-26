using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        private int _cnpj;
        public int CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        private int _ie;
        public int IE
        {
            get { return _ie; }
            set { _ie = value; }
        }

        public ClienteJuridico()
        {
            
        }
        public ClienteJuridico(int codigo, string nome, string endereco, int cnpj, int ie) : base(codigo, nome, endereco)
        {
            this.CNPJ = cnpj;
            this.IE = ie;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"CNPJ: {CNPJ}\tIE: {IE}");
        }
    }
}