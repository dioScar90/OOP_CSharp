using ClasseFuncionario;

// Função Main().
// Instanciação de objeto.
Funcionario f1 = new Funcionario();
Console.Write("Cadastre o código do funcionário: ");
f1.codigo = int.Parse(Console.ReadLine());
Console.Write("Cadastre o nome do funcionário: ");
f1.nome = Console.ReadLine();
Console.Write("Cadastre o salário do funcionário: ");
f1.salario = double.Parse(Console.ReadLine());
f1.MostrarAtributos();

Funcionario f2 = new Funcionario();
f2.MostrarAtributos();