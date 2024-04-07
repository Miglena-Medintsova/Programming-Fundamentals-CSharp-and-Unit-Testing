int stopNumber = int.Parse(Console.ReadLine());
int currentNumber = int.Parse(Console.ReadLine());
double sum = 0;

while (currentNumber >= stopNumber || currentNumber <= stopNumber)
{
    sum = 0;
    sum = currentNumber + (currentNumber * 0.2) ;
    currentNumber = int.Parse(Console.ReadLine());
    
    if (currentNumber == stopNumber)
    {
        break;
    }
}
Console.WriteLine(sum);

