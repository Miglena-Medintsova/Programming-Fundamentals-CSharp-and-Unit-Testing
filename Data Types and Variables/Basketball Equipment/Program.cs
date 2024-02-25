int annualTrainingFee = int.Parse(Console.ReadLine());

double sneakers = annualTrainingFee * 0.6;
double team = sneakers * 0.8;
double basketball = 0.25 * team;
double accessories = 0.2 * basketball;
double totalPrice = annualTrainingFee + sneakers + team + basketball + accessories;

Console.WriteLine(totalPrice);
