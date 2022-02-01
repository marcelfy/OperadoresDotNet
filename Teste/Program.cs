Console.WriteLine("Digite o primeiro nº:");
int n1 = Convert.ToInt32(Console.ReadLine());  //readline só le string, por isso a conversão pra int

if (n1 % 2 == 0)
{
    Console.WriteLine("É par!");
}
else
{
    Console.WriteLine("É impar!");
}

