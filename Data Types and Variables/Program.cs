int numberOfPages = int.Parse(Console.ReadLine());
int readedPagesInHour = int.Parse(Console.ReadLine());
int numberOfDaysNeeded = int.Parse(Console.ReadLine());

int totalReadingTime = numberOfPages / readedPagesInHour;
int hourPerDayNeeded = totalReadingTime / numberOfDaysNeeded;

Console.WriteLine(hourPerDayNeeded);
