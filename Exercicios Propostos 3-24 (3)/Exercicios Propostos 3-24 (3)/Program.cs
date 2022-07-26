

Console.WriteLine("Digite 4 valores inteiros, após digitar o primeiro aperte ENTER: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());

int diferenca = (num1 * num2) - (num3 * num4);
Console.WriteLine($"Diferença = {diferenca}");
