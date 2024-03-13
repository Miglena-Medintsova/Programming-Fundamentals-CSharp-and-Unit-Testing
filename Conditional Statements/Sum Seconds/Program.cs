using System.Collections.Concurrent;
using System.Xml.Schema;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

double minutes = num1 + num2 + num3;
double totalMins = minutes / 60;
double seconds = minutes % 60;

if (seconds <= 9)
{
    Console.WriteLine($"{Math.Floor(totalMins)}:0{seconds}");
}
else
{
    Console.WriteLine($"{Math.Floor(totalMins)}:{seconds}");
}





