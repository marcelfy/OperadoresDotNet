Console.WriteLine("Digite 1 ou 2:");
int n1 = Convert.ToInt32(Console.ReadLine());

switch (n1)
{
    case 1:
        Console.WriteLine("Oi!");
        break;
    case 2:
        Console.WriteLine("Tchau!");
        break;
    default:
        Console.WriteLine("Não é uma opção válida!");
        break;
}