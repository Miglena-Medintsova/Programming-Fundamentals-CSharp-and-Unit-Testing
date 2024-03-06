string drink = Console.ReadLine();
string extraSugar = Console.ReadLine();

double coffeePrice = 1;
double teaPrice = 0.6;
double sugarPrice = 0.4;

if (drink == "coffee" && extraSugar == "sugar")
{
    double totalPriceForCoffee = coffeePrice + sugarPrice;
    Console.WriteLine($"Final price: ${totalPriceForCoffee:F2}");
}
else if (drink == "coffee" && extraSugar == "no")
{
    Console.WriteLine($"Final price: ${coffeePrice:F2}");
}
else if (drink == "tea" && extraSugar == "sugar")
{
    double totalPriceForTea = teaPrice + sugarPrice;
    Console.WriteLine($"Final price: ${totalPriceForTea:F2}");
}
else if (drink == "tea" && extraSugar == "no")
{
    Console.WriteLine($"Final price: ${teaPrice:F2}");
}
