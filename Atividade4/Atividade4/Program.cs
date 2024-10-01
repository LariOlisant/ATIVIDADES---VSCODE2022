
int nota;
Console.Write("Informe a nota do aluno: ");
int.TryParse(Console.ReadLine(), out nota);

if (nota < 60)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("F! Você se deu mal! tente recuperar na próxima vez, boa sorte.");
    Console.ResetColor();
}
if (nota >59  && nota <70)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("D! Eita, você está derrapando muito ein! tente recuperar na próxima vez, boa sorte.");
    Console.ResetColor();
}
if (nota >=70 && nota <80)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("C! Você pode melhorar! tente recuperar na próxima vez, boa sorte, está quase!.");
    Console.ResetColor();
}
if (nota >= 80 && nota < 90)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("B! Você está ótimo! continue dando seu melhor!.");
    Console.ResetColor();
}
if (nota >= 90 && nota <= 99)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A!! Perfeito! continue dando seu melhor, que orgulho!.");
    Console.ResetColor();
}
if (nota == 100)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A!! Tudo perfeito, você é o bichão mesmo ein!");
    Console.ResetColor();
}

Console.WriteLine("Programa encerrado, bom trabalho a todos os alunos!");
Console.ReadKey();