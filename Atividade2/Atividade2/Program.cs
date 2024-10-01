Console.WriteLine("Informe um número de 1 a 12 (de acordo com os meses do ano): ");
int numerodomes = int.Parse(Console.ReadLine());

switch (numerodomes)
{
    case 12: // Dezembro
    case 1:  // Janeiro
    case 2:  // Fevereiro
        Console.WriteLine("Essa estação é o: Verão");
        break;
    case 3:  // Março
    case 4:  // Abril
    case 5:  // Maio
        Console.WriteLine("Essa estação é o: Outono");
        break;
    case 6:  // Junho
    case 7:  // Julho
    case 8:  // Agosto
        Console.WriteLine("Essa estação é o: Inverno (Melhor estação!)");
        break;
    case 9:  // Setembro
    case 10: // Outubro
    case 11: // Novembro
        Console.WriteLine("Essa etação é a: Primavera");
        break;
    default:
        Console.WriteLine("Esse mês é inválido! Por favor, escolha um número entre 1 e 12(meses do ano).");
        break;
}

//encerrar
Console.WriteLine("Por favor, digite uma tecla para encerrar... bay bay :) ");
Console.ReadKey();