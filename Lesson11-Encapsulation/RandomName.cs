using System.Text;

namespace Lesson11_Encapsulation;

public static class RandomName
{
    static Random random = new Random();

    public static string Generate()
    {
        StringBuilder result = new StringBuilder();
        string letterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < 5; i++)
        {
            result.Append(letterSet[random.Next(letterSet.Length)]);
        }

        return result.ToString();
    }
}