using ArrayFuncionario;

// Função Main().
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