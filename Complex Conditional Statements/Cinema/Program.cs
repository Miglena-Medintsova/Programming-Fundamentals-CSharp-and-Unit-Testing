string typeOfMovie = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeats = int.Parse(Console.ReadLine());

double totalCount = countOfRows * countOfSeats;
double totalPrice = 0;

switch (typeOfMovie)
   {
    case "Premiere":
        totalPrice = totalCount * 12;
        break;

    case "Normal":
        totalPrice = totalCount * 7.5;

        break;

    case "Discount":
        totalPrice = totalCount * 5;
        break;
}
Console.WriteLine($"{totalPrice:F2}");

