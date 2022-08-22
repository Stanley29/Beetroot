namespace Incapsulation;

public class Person5
{
    string name;
    public string Name1 => name;
    public string Name 
    { 
        get => name;
        set => name = value; 
    }
}