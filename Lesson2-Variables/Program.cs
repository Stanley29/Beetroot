// -6*x^3+5*x^2-10*x+15
int x = 5;
double first = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
Console.WriteLine(first);

// abs(x)*sin(x)
x = -1;
double second = Math.Abs(x) * Math.Sin(x);
Console.WriteLine(second);

// 2*pi*x
x = 2;
double third = 2 * Math.PI * x;
Console.WriteLine(third);

// max(x, y)
x = 5;
int y = 10;
Console.WriteLine(Math.Max(x, y));

Console.WriteLine("-------------------------------------------------------");

// Write to console how many days left to New Year and how many days passed from New Year.
DateTime pastYear = new DateTime(2022, 1, 1);
DateTime nextYear = new DateTime(2023, 1, 1);
DateTime now = DateTime.Now;

Console.WriteLine($"{nextYear.Subtract(now).Days} days left to New Year");
Console.WriteLine($"{now.Subtract(pastYear).Days} days passed from New Year");
//checked
