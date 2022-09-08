namespace Lesson11_Encapsulation;

public abstract class Human
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public int Age { get; }

    protected Human(int age, string firstName, string secondName)
    {
        if (age < 18 || age > 90)
        {
            Console.WriteLine("Wrong age. It will be set to 18.");
            Age = 18;
        }
        else
        {
            Age = age;
        }
        FirstName = firstName;
        SecondName = secondName;
    }

    protected Human()
    :this(18, RandomName.Generate(), RandomName.Generate()) 
    {
        
    }

}