using EncapsulamentoFuncionario;
namespace EncapsulamentoFuncionario {
    public class Program {
        public static void Main(string[] args) {
            /*
            Funcionario f1 = new Funcionario();
            f1.Codigo = 10; //utilizou o set, simbologia de recebe = utiliza o set, tem atribuição
            Console.WriteLine("Código: " + f1.Codigo); //get, qndo está mostrando, está fazendo o get
            Console.WriteLine("Cadastre o nome do funcionário: ");
            f1.Nome = Console.ReadLine(); //Não precisa converter, pois nome é string
            Console.WriteLine("Nome: " + f1.Nome); // get
            Console.WriteLine("Cadastre o salário do funcionário: ");
            f1.Salario = Convert.ToDouble(Console.ReadLine());

            if (f1.Salario >= 1000)
                Console.WriteLine("Bem Remunerado: " + f1.Salario);
            else {
                double novo = f1.Salario + 150; //get
                Console.WriteLine($"Novo: {novo:n}");
                //aumento de 10%
                f1.Salario = f1.Salario + f1.Salario * 10/100;
                Console.WriteLine($"Novo salário R${f1.Salario:c}");
            }*/
            Funcionario f2 = new Funcionario();
            f2.Codigo = 5;
            f2.Salario = 1000;
            f2.Nome = "Leidy";

            f2.MostrarAtributos();
        }
    }
}