using ArrayProduto;

// Função Main().
Console.WriteLine("--- EXEMPLO COM FOREACH ---");

Produto[] vetF = new Produto[5];
for (int i = 0; i < vetF.Length; i++) {
    // Instancia cada índice do vetor.
    vetF[i] = new Produto();
    Console.Write("Informe o código: ");
    vetF[i].codigo = int.Parse(Console.ReadLine());
    Console.Write("Informe o nome: ");
    vetF[i].nome = Console.ReadLine();
    Console.Write("Informe o salário: ");
    vetF[i].salario = double.Parse(Console.ReadLine());
}

Console.Write("Digite a porcentagem de aumento: ");
double aux = double.Parse(Console.ReadLine());
double porcentagem = aux / 100;

foreach (Produto item in vetF) {
    item.CalcularAumento(porcentagem);
    item.MostrarAtributos();
}