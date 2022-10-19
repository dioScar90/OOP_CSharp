using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.ComposicaoNotaFiscal
{
    // Classe parte.
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }
        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }

        // Destrutor, que sempre deve começar com um "~" e não pode ter parâmetros.
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destrutor do Item de Nota Fiscal.");
        }
    }
}