using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace OOP_CSharp.ConstrutorFuncionario
{
    public class Funcionario
    {
        static Funcionario()
        {
            Contador = Contador;
            CodigoCount = 100;
        }
        public Funcionario() // Construtor 1, sem parâmetros.
        {
            Contador = Contador;

            CodigoCount = 1;
            Codigo = CodigoCount;
        }
        public Funcionario(string nome, decimal salario) // Construtor 2, com parâmetros.
        {
            Contador = Contador;

            CodigoCount = 1;
            Codigo = CodigoCount;

            Nome = nome;
            Salario = salario;
        }

        private static int s_contador;
        private const decimal _salarioMinimo = 1212M;
        private static int s_codigoCount;
        private int _codigo;
        private string _nome;
        private decimal _salario;

        public static int Contador
        {
            get => s_contador;
            private set { s_contador++; }
        }
        public static int CodigoCount
        {
            get => s_codigoCount;
            private set { s_codigoCount += value; }
        }
        public int Codigo
        {
            get => _codigo;
            private set { _codigo = s_codigoCount; }
        }
        public string Nome
        {
            get => _nome;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode estar vazio.");
                }
                else if (value.Any(ch => !Char.IsLetter(ch) && !Char.IsWhiteSpace(ch) && ch != '.'))
                {
                    throw new ArgumentException("O nome deve conter apenas ponto ou letras, sem números ou caracteres especiais.");
                }
                
                _nome = ToUpperFirst(value);
            }
        }
        public decimal Salario
        {
            get => _salario;
            set {
                if (value < 0)
                {
                    throw new ArgumentException($"Erro no cadastro de {Nome}: salário não pode ser negativo.");
                }
                else if (value >= 0 && value < 1212)
                {
                    throw new ArgumentException($"Erro no cadastro de {Nome}: salário não pode ser menor que o salário mínimo vigente: {_salarioMinimo:C}.");
                }

                _salario = value;
            }
        }
        
        private string ToUpperFirst(string name)
        {
            string newStr = "";
            string newName = Regex.Replace(name.Trim(), @"\s+", " ");
            string[] arrStr = newName.Split(" ");

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
        
        public void ReajustarSalario(decimal reajuste)
        {
            reajuste += 1;
            Salario *= reajuste;
        }

        public void MostrarDados()
        {
            Console.WriteLine("" + 
                $"Código: {Codigo}" +
                $"\tNome: {Nome}" +
                $"\tSalário: {Salario:C}");
        }
    }
}