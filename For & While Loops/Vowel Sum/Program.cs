﻿using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

int countOfChars = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < countOfChars; i++)
{
    char letter = char.Parse(Console.ReadLine());

    switch (letter)
    {
        case 'a': sum += 1 ; break;
        case 'e': sum += 2; break;
        case 'i': sum += 3; break;
        case 'o': sum += 4; break;
        case 'u': sum += 5; break;
    }
}
Console.WriteLine(sum);













