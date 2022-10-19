using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models.ComposicaoNotaFiscal
{
    // Classe todo.
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public DateOnly Data { get; set; }
        public List<ItemNotaFiscal> Item { get; set; }

        public NotaFiscal(int numeronf, DateOnly data, List<ItemNotaFiscal> vetItens)
        {
            NumeroNF = numeronf;
            Data = data;
            Item = vetItens;
        }

        // Destrutor, que sempre deve começar com um "~" e não pode ter parâmetros.
        ~NotaFiscal()
        {
            Console.WriteLine("Destrutor da Nota Fiscal.");
        }
    }
}