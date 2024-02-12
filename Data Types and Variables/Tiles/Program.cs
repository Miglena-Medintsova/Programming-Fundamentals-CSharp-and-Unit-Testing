double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight;
double surplus = bathroomArea * 1.1;
double tileArea = tileWidth * tileHeight;
double tilesNeeded = surplus / tileArea;

Console.WriteLine(Math.Round(tilesNeeded));


