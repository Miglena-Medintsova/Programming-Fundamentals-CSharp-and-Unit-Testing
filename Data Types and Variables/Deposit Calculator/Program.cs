double depositedAmount = double.Parse(Console.ReadLine());
double termOfTheDeposit = double.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double accumulatedInterest = depositedAmount * (annualInterestRate / 100);
double interestForMonth = accumulatedInterest / 12;
double totalAmount = depositedAmount + termOfTheDeposit * interestForMonth;

Console.WriteLine(totalAmount);

