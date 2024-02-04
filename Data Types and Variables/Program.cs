// See https://aka.ms/new-console-template for more information
double celsius = double.Parse(Console.ReadLine());
double fh = celsius * 1.8 + 32;
Console.WriteLine($"{fh:F2}");
