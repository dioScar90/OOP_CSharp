using ClasseConta;
using System;

// Main()

// Lado esquedo é o tipo da variável.
Conta c1; // Declaração de variável.
c1 = new Conta(); // Instanciação de objeto.
c1.numero = 1;
c1.titular = "Bia";
c1.saldo = 100;

Conta c2 = new Conta();
Console.WriteLine("Digite o número da conta:");
c2.numero = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nome do titular:");
c2.titular = Console.ReadLine();
Console.WriteLine("Digite o saldo:");
c2.saldo = double.Parse(Console.ReadLine());

c1.MostrarDados();
c2.MostrarDados();

// Calcule e apresente o total de saldo dos correntistas (em apenas uma linha).
Console.WriteLine("Saldo de todas as contas: R$ " + (c1.saldo + c2.saldo));