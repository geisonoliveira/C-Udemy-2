// See https://aka.ms/new-console-template for more information
using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("", CultureInfo.InvariantCulture));

string[] lista = Console.ReadLine().Split(' ');
string nome = lista[0];
char sexo = char.Parse(lista[1]);
int idade = int.Parse(lista[2]);
double altura = double.Parse(lista[3], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

