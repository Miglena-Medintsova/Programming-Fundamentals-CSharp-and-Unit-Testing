int amountOfNums = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue;
int sum = 0;

for (int i = 0; i < amountOfNums; i++)
{

    int currentNumber = int.Parse((Console.ReadLine()));
    sum = 0;

    if (currentNumber > maxNumber)
    {
        sum += currentNumber;
        maxNumber = currentNumber;
    }
}
Console.WriteLine(maxNumber);

