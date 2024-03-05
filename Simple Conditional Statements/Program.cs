string ticketType = Console.ReadLine();

if (ticketType == "student")
{
    Console.WriteLine($"${1:F2}");
}
else if (ticketType == "regular")
{
    Console.WriteLine($"${1.60:F2}");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}
