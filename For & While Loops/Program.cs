using System.Diagnostics.CodeAnalysis;

int countOfNumbers = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= countOfNumbers; i++)
{
    double numbers = double.Parse(Console.ReadLine());
    sum = sum + numbers;
}
Console.WriteLine(sum);
