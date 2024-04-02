int number = int.Parse(Console.ReadLine());
int divisibleBy2 = 0;
int divisibleBy3 = 0;
int divisibleBy4 = 0;

for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
    {
        divisibleBy2++;
    }
    
    if (currentNumber % 3 == 0)
    {
        divisibleBy3++;
    }

    if (currentNumber % 4 == 0)
    {
        divisibleBy4++;
    }
}
double divisibleBy2Percentage = divisibleBy2 * 100.00 / number;
double divisibleBy3Percentage = divisibleBy3 * 100.00 / number;
double divisibleBy4Percentage = divisibleBy4 * 100.00 / number;

Console.WriteLine($"{divisibleBy2Percentage:F2}%");
Console.WriteLine($"{divisibleBy3Percentage:F2}%");
Console.WriteLine($"{divisibleBy4Percentage:F2}%");
