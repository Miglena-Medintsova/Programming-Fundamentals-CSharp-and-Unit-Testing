int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

double chickenMenuPrice = chickenMenu * 10.35;
double fishMenuPrice = fishMenu * 12.4;
double vegetarianMenuPrice = vegetarianMenu * 8.15;
double totalCost = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
double dessert = 0.2 * totalCost;
double totalOrderPrice = totalCost + dessert + 2.5;

Console.WriteLine(totalOrderPrice);
