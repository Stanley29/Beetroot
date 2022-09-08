namespace Lesson11_Encapsulation;

public class Teacher : Human
{
    public Classes _class { get; set; }

    public Teacher(Classes @class, int age, string firstName, string secondName)
        :base(age, firstName, secondName)
    {
        this._class = @class;
    }
    
    public Teacher(int age, string firstName, string secondName)
        :base(age, firstName, secondName)
    {
        Random random = new Random();
        _class = (Classes) random.Next(5);
    }

    public Teacher()
    :this(30, RandomName.Generate(), RandomName.Generate())
    {
            
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{SecondName} {FirstName}, who is {Age} y.o, teaches {_class}.");
    }

    public void ChangeInfo(string firstName, string secondName, Classes @class)
    {
        FirstName = firstName;
        SecondName = secondName;
        _class = @class;
    }
}