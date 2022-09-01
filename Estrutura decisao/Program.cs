/*Aqui é a função main
Console.Write("Digite o salário: ");
double salario = Convert.ToDouble(Console.ReadLine());

if (salario < 1000)
    Console.WriteLine("Não paga imposto");
else if (salario >= 1000 && salario < 5000)
    Console.WriteLine("Paga INSS");
else
    Console.WriteLine("Paga IR");
*/
char mes = 'w';
switch(mes)
{
    case 'j': Console.WriteLine("Janeiro");
            break;
    case 'f': Console.WriteLine("Fevereiro");
            break;
    default: Console.WriteLine("Mês inválido");
             break;
}

