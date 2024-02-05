// See https://aka.ms/new-console-template for more information
double dogFood = double.Parse(Console.ReadLine());
double catFood = double.Parse(Console.ReadLine());

double dogFoodPrice = dogFood * 2.5;
double catFoodPrice = catFood * 4;

double expenses = dogFoodPrice + catFoodPrice;

Console.WriteLine($"{expenses:F2} lv.");



