class Program
{
    static void Main(string[] args)
    {
        // Person tom = new Person();
        // tom.name = "Tom";
        // tom.Print();

        Person1 tom = new Person1();
        tom.Print();
        Person1 ben = tom with { name = "Ben" };
    }
}

struct Person
{
    public string name;
    public int age;
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}

struct Person1
{
    
    public string name = "Tom";
    public int age = 1;
    public Person1() { }
    public void Print() =>Console.WriteLine($"Имя: {name}  Возраст: {age}");
}