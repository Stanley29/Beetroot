int x;
Console.WriteLine("Input X:");
if (!Int32.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Invalid input");
    return;
}

int y;
Console.WriteLine("Input Y:");
if (!Int32.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("Invalid input");
    return;
}

int sum = 0;
for (int i = x; i <= y; i++)
{
    sum += i;
}
Console.WriteLine($"Sum of numbers: {sum}");
