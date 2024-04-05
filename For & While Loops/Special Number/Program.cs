int number = int.Parse(Console.ReadLine());
int tempNumber = number;
bool isSpecial = true;

while (tempNumber > 0)
{
    int currentLastDigit = tempNumber % 10;
    tempNumber = tempNumber / 10;

    if (number % currentLastDigit != 0)
    {

        isSpecial = false;
        break;
    }
}
if (isSpecial)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}






