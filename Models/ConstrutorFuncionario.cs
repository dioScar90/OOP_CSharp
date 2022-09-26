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

        public Funcionario()
        {
            
        }
        public Funcionario(int codigo, string nome, decimal salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        private int _codigo;
        private string _nome;
        private decimal _salario;

        public int Codigo
        {
            get => _codigo;
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Código inválido!");
                }

                _codigo = value;
            }
        }
        public string Nome
        {
            get => _nome;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode estar vazio!");
                }
                
                _nome = ToUpperFirst(value);
            }
        }
        public decimal Salario
        {
            get => _salario;
            set => _salario = value;
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

        private string MoneyFormated(decimal number)
        {
            return String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N2}", number);
        }

        public void MostrarDados()
        {
            Console.WriteLine("" + 
                "Código do funcionário: " + Codigo +
                "\tNome: " + Nome +
                "\tSalário: R$ " + MoneyFormated(Salario) + ".");
        }
    }
}