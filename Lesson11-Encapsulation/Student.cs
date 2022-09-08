namespace Lesson11_Encapsulation;

public class Student : Human
{
    public int Grade { get; set; }

    public Student(int grade, int age, string firstName, string secondName)
        :base(age, firstName, secondName)
    {
        Grade = grade;
    }
    
    public Student(int age, string firstName, string secondName)
        :base(age, firstName, secondName)
    {
        Random random = new Random();
        Grade = random.Next(1, 12);
    }

    public Student()
        :this(18, RandomName.Generate(), RandomName.Generate())
    {
            
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{SecondName} {FirstName}, who is {Age} y.o, study in {Grade} grade.");
    }
}