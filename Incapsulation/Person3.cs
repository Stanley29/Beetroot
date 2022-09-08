namespace Incapsulation;

public class Person3
{
    string name = "";
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }
    public Person3(string name) => Name = name;
}