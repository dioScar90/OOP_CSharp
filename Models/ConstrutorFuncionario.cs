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

        // static Funcionario()
        // {
        //     Codigo = 100;
        // }
        public Funcionario()
        {
            Codigo = Codigo;
        }
        public Funcionario(string nome, decimal salario)
        {
            Codigo = Codigo;
            Nome = nome;
            Salario = salario;
        }

        private static int s_codigo = 100;
        private string _nome;
        private decimal _salario;

        public static int Codigo
        {
            get => s_codigo;
            private set { s_codigo++; }
        }
        public string Nome
        {
            get => _nome;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode estar vazio!");
                }
                
                _nome = ToUpperFirst(value.Trim());
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

                newStr += arrStr.Last() == item ? "" : ' ';
            }

            return newStr;
        }

        // private string MoneyFormated(decimal number)
        // {
        //     return String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", number);
        //     // ou...
        //     return number.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        // }

        public void MostrarDados()
        {
            Console.WriteLine("" + 
                $"Código: {Codigo}" +
                $"\tNome: {Nome}" +
                // "\tSalário: " + MoneyFormated(Salario));
                $"\tSalário: {Salario:C}");
        }
    }
}