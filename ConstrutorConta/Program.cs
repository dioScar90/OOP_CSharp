// Função Main()
using ConstrutorConta;

// Construtor padrão, sem parâmetros.
Conta c1 = new Conta();
c1.MostrarDados();

// 2º construtor, com 1 parâmetro.
Conta c2 = new Conta(10);
c2.MostrarDados();

// 3º construtor, com 2 parâmetros.
Conta c3 = new Conta(11, "Ana");
c3.MostrarDados();

// 4º construtor, com 3 parâmetros.
Conta c4 = new Conta(12, "Bia", 100);
c4.MostrarDados();