﻿int number =  int.Parse(Console.ReadLine());
int sum = 0;
int digit = 0;

while (number > 0)
{
    digit = number % 10;
    sum += digit;
    number /= 10;   
}
Console.WriteLine(sum);


