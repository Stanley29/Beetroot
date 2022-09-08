using System.Text.RegularExpressions;

string[] phoneBook = new [] { "Denis-Drobin-0958275671", "Slutu-Sergei-0951987782", "Sergei-Drobin-0951927783" };
List<string> result = new List<string>();

string ?str = Console.ReadLine();
Regex regex = new Regex(str);

foreach (var person in phoneBook)
{
    MatchCollection matches = regex.Matches(person);
    if (matches.Count > 0)
    {
        result.Add(person);
    }
}

if (result.Count > 0)
{
    Console.WriteLine("Matches:");
    foreach (var person in result)
    {
        Console.WriteLine(person);
    }
}
else
{
    Console.WriteLine("Doesn't exist");
}