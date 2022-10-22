using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.ComposicaoBanco
{
    public class Banco
    {
        // atributos da classe Poupanca e ContaCorrente
        private List<Poupanca> _poups;
        public List<Poupanca> Poups
        {
            get { return _poups; }
            set { _poups = value; }
        }
        private List<ContaCorrente> _contas;
        public List<ContaCorrente> Contas
        {
            get { return _contas; }
            set { _contas = value; }
        }

        public Banco(List<Poupanca> poups, List<ContaCorrente> contas)
        {
            this.Poups = poups;
            this.Contas = contas;
        }

        ~Banco()
        {
            
        }
        
    }
}