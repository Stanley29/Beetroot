using System.Net.NetworkInformation;
using System.Security.Principal;

namespace Lesson17_Snake;

public class Food 
{
    static Random random = new Random();
    public Pixel pixel { get; }

    public Food()
    {
        pixel = new Pixel(random.Next(1, Program.Wide - 1), random.Next(1, Program.Height - 1), '+');
    }
}