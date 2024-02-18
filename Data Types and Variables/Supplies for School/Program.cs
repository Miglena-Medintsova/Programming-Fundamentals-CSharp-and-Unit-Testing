double packagesOfPens = double.Parse(Console.ReadLine());
double packagesOfMarkers = double.Parse(Console.ReadLine());
double litersOfBoardCleaner = double.Parse(Console.ReadLine());
double discountPercentage = double.Parse(Console.ReadLine());

double priceOfPens = packagesOfPens * 5.8;
double priceOfMarkers = packagesOfMarkers * 7.2;
double priceOfBoardCleaner = litersOfBoardCleaner * 1.2;
double priceForAllMaterials = priceOfPens + priceOfMarkers + priceOfBoardCleaner;
double discount = discountPercentage / 100;
double priceAfterDiscount = priceForAllMaterials - (priceForAllMaterials * discount);

Console.WriteLine(priceAfterDiscount);
