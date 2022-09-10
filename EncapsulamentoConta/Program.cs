using EncapsulamentoConta;
//Função Main()

Conta c1 = new Conta();
c1.Titular = "Giovana";
c1.Saldo = 50;

Conta c2 = new Conta();
c2.Titular = "Reinaldo";
c2.Saldo = 20;

c1.TransferirDinheiro(10, c2);
Console.WriteLine("Saldo c1 Giovana: " + c1.Saldo);
Console.WriteLine("Saldo c2 Reinaldo: " + c2.Saldo);