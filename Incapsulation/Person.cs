namespace Incapsulation;

public class Person
{
    int age = 1;
    string value;
    public int Age
    {
        set
        {
            if (value < 1 || value > 120)
                Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
            else
                age = value;
        }
        get { return age; }
    }
}