// using OOP_CSharp.ArrayFuncionario;
// using OOP_CSharp.ArrayProduto;
// using OOP_CSharp.ClasseConta;
// using OOP_CSharp.ClasseFuncionario;
// using OOP_CSharp.ConstrutorConta;
// using OOP_CSharp.ConstrutorFuncionario;
// using OOP_CSharp.EncapsulamentoConta;
// using OOP_CSharp.EncapsulamentoFuncionario;
// using OOP_CSharp.Models.AgregacaoConta;
// using OOP_CSharp.Models.AgregacaoArrayConta;
using OOP_CSharp.Models.AgregacaoVenda;

using System.Globalization;

// Definindo a cultura local do Brasil. Útil no momento de formatar a moeda.
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// ************************************************************************************

// AgregacaoVenda
Console.WriteLine("---------------- SISTEMA PARA CADASTRO DE VENDA ----------------");

Comprador comprador = new Comprador(5000M);

Console.WriteLine($"\nIniciando cadastro da venda. Verba do comprador: {comprador.Verba:C2}.");

var produtos = new List<Produto> {
    new Produto("Módulo Amp TS 0400", 257.99M),
    new Produto("Módulo Amp HD 3000", 647.9M),
    new Produto("Módulo Amp DS 0800", 527.99M),
    new Produto("Módulo Amp TI 1500", 275.08M),
    new Produto("Módulo Amp TI 0500", 109.99M),
    new Produto("Módulo Amp MD 1200", 672.25M),
    new Produto("Pro Charger 60a BV", 419.9M)
};

List<Produto> produtosDaVenda = new List<Produto>();
List<int> aux = new List<int>();
Console.WriteLine("\nLista de produtos:");
foreach (var item in produtos)
{
    aux.Add(item.Codigo);
    item.MostrarAtributos();
}

Console.WriteLine("\nEscolha quantos e quais produtos serão incluídos nessa venda:");
Console.Write("Quantidade de produtos: ");
int.TryParse(Console.ReadLine(), out int qtdeProdutos);

Console.WriteLine($"Escreva os CÓDIGOS dos {qtdeProdutos} produtos:");
for (int i = 1; i <= qtdeProdutos; i++)
{
    Console.Write($"Produto {i}: ");
    int.TryParse(Console.ReadLine(), out int codigo);
    int idx = aux.IndexOf(codigo);
    
    if (idx > 0)
        produtosDaVenda.Add(produtos[idx]);
}
produtosDaVenda = produtosDaVenda.OrderBy(item => item.Codigo).ToList();

decimal valorTotalProdutos = produtosDaVenda.Sum(item => item.Preco);
Vendedor vendedor = new(valorTotalProdutos);
Venda venda1 = new(comprador, vendedor, produtosDaVenda);

Console.WriteLine($"\nSegue abaixo os detalhes da venda:");
venda1.MostrarAtributos();

































// // AgregacaoArrayConta
// Cliente cliente1 = new("Ana", "123", "11");
// Cliente cliente2 = new("Bia", "345", "76");

// Conta c1 = new();
// c1.NumeroConta = 1;
// c1.Saldo = 1000M;
// c1.VetTitular = new List<Cliente>();
// c1.VetTitular.Add(cliente1);

// Conta c2 = new();
// c2.NumeroConta = 1;
// c2.Saldo = 100M;
// c1.VetTitular.Add(cliente2);

// foreach (var item in c1.VetTitular)
// {
//     Console.WriteLine($"Nome: {item.Nome}");
// }

































// // AgregacaoConta
// Cliente cliente = new();
// cliente.Nome = "Ana";
// cliente.CPF = "123";
// cliente.RG = "11";

// Conta c1 = new();
// c1.NumeroConta = 1;
// c1.Saldo = 100M;
// c1.Titular = cliente;

// Conta c2 = new();
// c2.NumeroConta = 1;
// c2.Saldo = 100M;
// c2.Titular = new Cliente();
// c2.Titular.Nome = "Bia";
// c2.Titular.CPF = "345";
// c2.Titular.RG = "76";

// Console.WriteLine($"Nome: {c1.Titular.Nome}");
// Console.WriteLine($"Nome: {c2.Titular.Nome}");

































// // EncapsulamentoFuncionario
// Funcionario f1 = new Funcionario();
// f1.Codigo = 10; //utilizou o set, simbologia de recebe = utiliza o set, tem atribuição
// Console.WriteLine("Código: " + f1.Codigo); //get, qndo está mostrando, está fazendo o get
// Console.WriteLine("Cadastre o nome do funcionário: ");
// f1.Nome = Console.ReadLine(); //Não precisa converter, pois nome é string
// Console.WriteLine("Nome: " + f1.Nome); // get
// Console.WriteLine("Cadastre o salário do funcionário: ");
// f1.Salario = Convert.ToDouble(Console.ReadLine());

// if (f1.Salario >= 1000)
//     Console.WriteLine("Bem Remunerado: " + f1.Salario);
// else {
//     double novo = f1.Salario + 150; //get
//     Console.WriteLine($"Novo: {novo:n}");
//     //aumento de 10%
//     f1.Salario = f1.Salario + f1.Salario * 10/100;
//     Console.WriteLine($"Novo salário R${f1.Salario:C2}");
// }*/
// Funcionario f2 = new Funcionario();
// f2.Codigo = 5;
// f2.Salario = 1000;
// f2.Nome = "Leidy";

// f2.MostrarAtributos();

































// // EncapsulamentoConta
// Conta c1 = new Conta();
// c1.Titular = "Giovana";
// c1.Saldo = 50;

// Conta c2 = new Conta();
// c2.Titular = "Reinaldo";
// c2.Saldo = 20;

// c1.TransferirDinheiro(10, c2);
// Console.WriteLine("Saldo c1 Giovana: " + c1.Saldo);
// Console.WriteLine("Saldo c2 Reinaldo: " + c2.Saldo);

































// ConstrutorFuncionario
// Console.WriteLine("--------------------- CADASTRO DE FUNCIONÁRIOS ---------------------");

// Declarando lista, ao invés de array, para deixar o tamanho indefinido.
// List<Funcionario> vetF = new();

// Instanciando os funcionários, em duas formas diferentes.
// vetF.Add(new Funcionario{
//     Nome = "diogo DE liMA SCARMAGNANI",
//     Salario = 1500M
// });
// vetF.Add(new("diogo DE liMA SCARMAGNANI", 1500M));
// vetF.Add(new("   Linus   benEDICt TORVALDS ", 4890.4M));
// vetF.Add(new("GIOVANA ANGELICA R. MIOLA", 7500M));

// Quantidade atual de funcionários cadastrados (instâncias).
// int atualCount = Funcionario.Contador;

// Console.WriteLine($"\n{atualCount} funcionários cadastrados com sucesso:");
// foreach (var item in vetF)
// {
//     item.MostrarDados();
// }

// Console.Write("\nInforme o percentual de reajuste salarial\n(se precisar, separe casa decimal com vírgula): ");
// decimal reajuste = decimal.Parse(Console.ReadLine());
// reajuste /= 100;
// foreach (var item in vetF)
// {
//     item.ReajustarSalario(reajuste);
// }

// Console.WriteLine($"\nSalários reajustados em {reajuste:P2}:");
// foreach (var item in vetF)
// {
//     item.MostrarDados();
// }

































// // ConstrutorConta
// // Construtor padrão, sem parâmetros.
// var c1 = new Conta{
//     Numero = 25,
//     Titular = "Brabo",
//     Saldo = 1000.00M
// };
// c1.MostrarDados();

// // 2º construtor, com 1 parâmetro.
// Conta c2 = new(10);
// c2.MostrarDados();

// // 3º construtor, com 2 parâmetros.
// Conta c3 = new(11, "Ana");
// c3.MostrarDados();

// // 4º construtor, com 3 parâmetros.
// Conta c4 = new(12, "Bia", 100.00M);
// c4.MostrarDados();

// Console.WriteLine($"Quantidade de instâncias: {Conta.Contador}");

































// // ClasseFuncionario
// // Instanciação de objeto.
// Funcionario f1 = new Funcionario();
// Console.Write("Cadastre o código do funcionário: ");
// f1.codigo = int.Parse(Console.ReadLine());
// Console.Write("Cadastre o nome do funcionário: ");
// f1.nome = Console.ReadLine();
// Console.Write("Cadastre o salário do funcionário: ");
// f1.salario = double.Parse(Console.ReadLine());
// f1.MostrarAtributos();

// Funcionario f2 = new Funcionario();
// f2.MostrarAtributos();

































// // ClasseConta
// // Lado esquedo é o tipo da variável.
// Conta c1; // Declaração de variável.
// c1 = new Conta(); // Instanciação de objeto.
// c1.numero = 1;
// c1.titular = "Bia";
// c1.saldo = 100;

// Conta c2 = new Conta();
// Console.WriteLine("Digite o número da conta:");
// c2.numero = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o nome do titular:");
// c2.titular = Console.ReadLine();
// Console.WriteLine("Digite o saldo:");
// c2.saldo = double.Parse(Console.ReadLine());

// c1.MostrarDados();
// c2.MostrarDados();

// // Calcule e apresente o total de saldo dos correntistas (em apenas uma linha).
// Console.WriteLine("Saldo de todas as contas: R$ " + (c1.saldo + c2.saldo));

































// // ArrayProduto
// Console.WriteLine("--- EXEMPLO COM FOREACH ---");

// Produto[] vetF = new Produto[5];
// for (int i = 0; i < vetF.Length; i++) {
//     // Instancia cada índice do vetor.
//     vetF[i] = new Produto();
//     Console.Write("Informe o código: ");
//     vetF[i].codigo = int.Parse(Console.ReadLine());
//     Console.Write("Informe o nome: ");
//     vetF[i].nome = Console.ReadLine();
//     Console.Write("Informe o salário: ");
//     vetF[i].salario = double.Parse(Console.ReadLine());
// }

// Console.Write("Digite a porcentagem de aumento: ");
// double aux = double.Parse(Console.ReadLine());
// double porcentagem = aux / 100;

// foreach (Produto item in vetF) {
//     item.CalcularAumento(porcentagem);
//     item.MostrarAtributos();
// }

































// // ArrayFuncionario
// Console.WriteLine("--- EXEMPLO COM VETOR ---");

// // Funcionario f1 = new Funcionario();
// // Funcionario f2 = new Funcionario();
// // Funcionario f3 = new Funcionario();
// // Funcionario f4 = new Funcionario();
// // Funcionario f5 = new Funcionario();
// // É inviável trabalhar instanciando diversos objetos. Solução: usar vetor.

// Funcionario[] vetF = new Funcionario[3];
// for (int i = 0; i < vetF.Length; i++) {
//     // Instancia cada índice do vetor.
//     vetF[i] = new Funcionario();
//     Console.Write("Informe o código: ");
//     vetF[i].codigo = int.Parse(Console.ReadLine());
//     Console.Write("Informe o nome: ");
//     vetF[i].nome = Console.ReadLine();
//     Console.Write("Informe o salário: ");
//     vetF[i].salario = Convert.ToDouble(Console.ReadLine());
// }
// for (int i = 0; i < vetF.Length; i++) {
//     vetF[i].MostrarAtributos();
// }