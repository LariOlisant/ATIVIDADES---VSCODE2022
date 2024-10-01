double resultado;

Console.Write("Insira um número para você descobrir a tabuada dele até o 10: ");
double valor = double.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = valor * i;
    Console.WriteLine($"{valor} x {i} = {resultado}");
}
//encerrar
Console.WriteLine("Por favor, digite uma tecla para encerrar... bay bay :) ");
Console.ReadKey();