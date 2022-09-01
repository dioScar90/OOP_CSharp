// Main()
Console.WriteLine("Exemplo do FOR");
for(int x = 13; x < 25; x++){
    //outros comandos
    Console.WriteLine("Valor do contador " + x);
}
Console.WriteLine("Exemplo do WHILE");
int w = 5;
while (w < 12) {
    Console.WriteLine("Valor do contador " + w);
    w = w + 1;
}
Console.WriteLine("Exemplo DO .. WHILE");
int q = 0;
do{
    Console.WriteLine("Valor do contador " + q);
    q++; // q += 1
}while (q < 12);

/*crie um programa para calcaular a media 
de idade de algumas pessoas, digite zero 
para sair   while */
Console.Write("Digite a idade....: ");
int idade = Convert.ToInt32(Console.ReadLine());
int soma = 0, cont = 0;
while(idade  > 0){
    soma = soma + idade;
    Console.Write("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
    cont += 1;
}
Console.WriteLine("Média " + soma/cont);
soma = 0;
cont = 0;
do {
    Console.Write("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade > 0){
        soma += idade;
        cont += 1;
    }    
}while (idade > 0);
Console.WriteLine("Média " + soma/cont);
