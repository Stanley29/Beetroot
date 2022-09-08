namespace Incapsulation;

public class Person1
{
    string name = "Tom";
    int age = 1;
    // свойство только для записи
    public int Age
    {
        set { age = value; }
    }
    // свойство только для чтения
    public string Name
    {
        get { return name; }
    }
    public void Print()=> Console.WriteLine($"Name: {name}  Age: {age}");
}