using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace OOP_CSharp.ConstrutorFuncionario
{
    public class Funcionario
    {
        // Declarar atributos e métodos com o encapsulamento
        // completo (propfull), validando a digitação do usuário e na
        // apresentação do atributo nome, mostrar em maiúsculo.
        private int codigo;
        private string nome;
        private decimal salario;

        public int Codigo
        {
            get => codigo;
            set {
                if (value > 0)
                    codigo = value;
                else
                    Console.WriteLine("Código inválido!");
            }
        }
        public string Nome
        {
            get => nome;
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome não pode estar vazio!");
                else
                    nome = ToUpperFirst(value);
            }
        }
        public decimal Salario
        {
            get => salario;
            set => salario = value;
        }
        public Funcionario(int codigo, string nome, decimal salario)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Salario = salario;
        }

        private string ToUpperFirst(string name)
        {
            string newStr = "";
            string[] arrStr = name.Split(' ');

            foreach(var item in arrStr)
            {
                if (new[] {"de", "da", "do", "dos", "das", "e"}.Contains(item.ToLower()))
                    newStr += item.ToLower();
                else
                    newStr += char.ToUpper(item[0]) + item.Substring(1).ToLower();

                if (arrStr.Last() != item)
                    newStr += " ";
            }

            return newStr;
        }

        public void MostrarDados()
        {
            Console.WriteLine("" + 
                "Código do funcionário: " + Codigo +
                "\tNome: " + Nome +
                "\tSalário: R$ " + String.Format("{0:N}", Salario));
        }
    }
}