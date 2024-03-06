string typeOfFigure = Console.ReadLine();


if (typeOfFigure == "square")
{
    double side = double.Parse(Console.ReadLine());

    double areaOfSquare = side * side;

    Console.WriteLine($"{areaOfSquare:F2}");
}
else if (typeOfFigure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double length = double.Parse(Console.ReadLine());

    double areaOfRectangle = width * length;

    Console.WriteLine($"{areaOfRectangle:F2}");
}
else if (typeOfFigure == "circle")
{
    double radius = double.Parse(Console.ReadLine());

    double areaOfCircle = Math.PI * radius * radius;

    Console.WriteLine($"{areaOfCircle:F2}");
}

