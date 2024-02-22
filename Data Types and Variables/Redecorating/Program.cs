int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hoursNeeded = int.Parse(Console.ReadLine());

double nylonAmount = (nylon + 2) * 1.5;
double paintAmount = (paint * 1.1) * 14.5;
double thinnerAmount = thinner * 5;
double totalAmount = nylonAmount + paintAmount + thinnerAmount + 0.4;
double craftmenAmount = (totalAmount * 0.3) * hoursNeeded;
double sum = totalAmount + craftmenAmount;

Console.WriteLine(sum);




