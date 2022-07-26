using System.Globalization;

Console.WriteLine("Digite o número do funcionário: ");
int numero_funcionario = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero de horas trabalhadas: ");
int horas_trabalhadas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor recebido por hora: ");
double valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salario = horas_trabalhadas * valor_hora;

Console.WriteLine("NUMBER = " + numero_funcionario);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
