string texto = "ABCDE";
Console.WriteLine(texto);

Console.WriteLine(texto.Length); //lenght conta os caracteres

string nome = "Marcel";
string sobrenome = " Yassumoto";

Console.WriteLine(nome + sobrenome);

Console.WriteLine(string.Concat(nome, sobrenome));  //concatena as duas strings, junta

Console.WriteLine($"{nome}{sobrenome}");

Console.WriteLine(nome[1]);  //[] pega na posição 1 a letra e imprime

Console.WriteLine(nome.IndexOf("c"));  //pega a posição da letra c e imprime

