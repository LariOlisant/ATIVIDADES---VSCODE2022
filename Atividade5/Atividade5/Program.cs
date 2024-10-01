int numero = 7;
int adivinha;

do
{
    Console.Write("\nTente adivinhar o numero secreto: ");
    adivinha = int.Parse(Console.ReadLine());

    if (adivinha != numero)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Seu lado sensitivo está fraco, tente novamente!");
        Console.ResetColor();
    };


} while (numero != adivinha);


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("MÁRCIA SENSITIVA ÉS TU? VOCÊ ACERTOU O NÚMERO SECRETO");
Console.ResetColor();

//encerrar
Console.WriteLine("Por favor, digite uma tecla para encerrar... bay bay :) ");
Console.ReadKey();