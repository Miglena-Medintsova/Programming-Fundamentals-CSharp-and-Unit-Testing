string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfTheDays = int.Parse(Console.ReadLine());

double price = 0;

if (season == "Spring" && accommodationType == "Hotel")
{
    price = countOfTheDays * 30 * 0.8;
    Console.WriteLine($"{price:F2}");
}
else if (season == "Spring" && accommodationType == "Camping")
{
    price = countOfTheDays * 10 * 0.8;
    Console.WriteLine($"{price:F2}");
}
else if (season == "Summer" && accommodationType == "Hotel")
{
    price = countOfTheDays * 50;
    Console.WriteLine($"{price:F2}");
}
else if (season == "Summer" && accommodationType == "Camping")
{
    price = countOfTheDays * 30;
    Console.WriteLine($"{price:F2}");
}
else if (season == "Autumn" && accommodationType == "Hotel")
{
    price = countOfTheDays * 20 * 0.7;
    Console.WriteLine($"{price:F2}");
}
else if (season == "Autumn" && accommodationType == "Camping")
{
    price = countOfTheDays * 15 * 0.7;
    Console.WriteLine($"{price:F2}");
}
else if (season == "Winter" && accommodationType == "Hotel")
{
    price = countOfTheDays * 40 * 0.9;
    Console.WriteLine($"{price:F2}");
}
else if (season ==  "Winter" && accommodationType == "Camping")
{
    price = countOfTheDays * 10 * 0.9;
    Console.WriteLine($"{price:F2}");
}
