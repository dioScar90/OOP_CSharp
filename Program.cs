using OOP_Teste.ArrayFuncionario;
// using OOP_Teste.ArrayProduto;
// using OOP_Teste.ClasseConta;
// using OOP_Teste.ClasseFuncionario;
// using OOP_Teste.ConstrutorConta;
// using OOP_Teste.EncapsulamentoConta;
// using OOP_Teste.EncapsulamentoFuncionario;

// ArrayFuncionario
Console.WriteLine("--- EXEMPLO COM VETOR ---");

// Funcionario f1 = new Funcionario();
// Funcionario f2 = new Funcionario();
// Funcionario f3 = new Funcionario();
// Funcionario f4 = new Funcionario();
// Funcionario f5 = new Funcionario();
// É inviável trabalhar instanciando diversos objetos. Solução: usar vetor.

Funcionario[] vetF = new Funcionario[3];
for (int i = 0; i < vetF.Length; i++) {
    // Instancia cada índice do vetor.
    vetF[i] = new Funcionario();
    Console.Write("Informe o código: ");
    vetF[i].codigo = int.Parse(Console.ReadLine());
    Console.Write("Informe o nome: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Informe o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i < vetF.Length; i++) {
    vetF[i].MostrarAtributos();
}

// ************************************************************************************

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

// ************************************************************************************

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

// ************************************************************************************

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

// ************************************************************************************

// // ConstrutorConta
// // Construtor padrão, sem parâmetros.
// Conta c1 = new Conta();
// c1.MostrarDados();

// // 2º construtor, com 1 parâmetro.
// Conta c2 = new Conta(10);
// c2.MostrarDados();

// // 3º construtor, com 2 parâmetros.
// Conta c3 = new Conta(11, "Ana");
// c3.MostrarDados();

// // 4º construtor, com 3 parâmetros.
// Conta c4 = new Conta(12, "Bia", 100);
// c4.MostrarDados();

// ************************************************************************************

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

// ************************************************************************************

// // EncapsulamentoFuncionario
// /*
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
//     Console.WriteLine($"Novo salário R${f1.Salario:c}");
// }*/
// Funcionario f2 = new Funcionario();
// f2.Codigo = 5;
// f2.Salario = 1000;
// f2.Nome = "Leidy";

// f2.MostrarAtributos();

// ************************************************************************************

// ************************************************************************************

// ************************************************************************************