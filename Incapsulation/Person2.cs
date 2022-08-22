namespace Incapsulation;

public class Person2
{
    string firstName;
    string lastName;
    public string Name
    {
        get { return  $"{firstName} {lastName}"; }
    }
    public Person2(string firstName, string lastName)
    {
        this.firstName = firstName; 
        this.lastName = lastName;
    }
}