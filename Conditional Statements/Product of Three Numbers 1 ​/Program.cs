double numberOne = double.Parse(Console.ReadLine());
double numberTwo = double.Parse(Console.ReadLine());
double numberThree = double.Parse(Console.ReadLine());

double sum = 0;

if (numberOne < 0)
{
    sum++;
}
if (numberTwo < 0)
{
    sum++;
}
if (numberThree < 0)
{
    sum++;
}

if (sum == 1)
{
    Console.WriteLine("negative");
}
else if (sum == 2)
{
    Console.WriteLine("positive");
}
else if (sum == 3)
{
    Console.WriteLine("negative");
}
else if (sum == 0)
{
    Console.WriteLine("zero");
}
