string input = Console.ReadLine();
double balance = 0;

while (input != "End")
{
    double money = double.Parse(input); 

    if (money > 0)
    {
        balance += money;
        Console.WriteLine($"Increase: {money}");
    }
    else
    {
        balance -= Math.Abs(money);
        Console.WriteLine($"Decrease: {Math.Abs(money)}");
    }
    input = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance}");





