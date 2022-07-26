using System.Globalization;

Console.WriteLine("Digite valor do raio do círculo: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pi = Math.PI;
double area = pi * Math.Pow(raio, 2);
Console.WriteLine("A área calculada foi: " + area.ToString("F4", CultureInfo.InvariantCulture));