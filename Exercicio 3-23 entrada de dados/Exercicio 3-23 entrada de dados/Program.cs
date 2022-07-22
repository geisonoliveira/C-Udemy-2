// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha com espaço)");
string[] registro = Console.ReadLine().Split(' ');
string nome_registro = registro[0];
int idade_registro = int.Parse(registro[1]);
double altura_registro = double.Parse(registro[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(nome_registro);
Console.WriteLine(idade_registro);
Console.WriteLine(altura_registro.ToString("F2", CultureInfo.InvariantCulture));


