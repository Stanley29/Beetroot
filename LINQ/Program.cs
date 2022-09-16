class Program
{
    static void Main(string[] args)
    {
        // string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
        // var selectedPeople = people.Where(person => person.ToUpper().StartsWith("T")).ToList().OrderBy(people => people);
        // foreach (string person in selectedPeople)
        //     Console.WriteLine(person);
        // var people = new List<Person>
        // {
        //     new Person ("Tom", 23),
        //     new Person ("Bob", 27),
        //     new Person ("Sam", 29),
        //     new Person ("Alice", 24)
        // };
        // // var names = from p in people select p.Name;
        // var names = people.Select(u => u.Name);
        // foreach (string n in names)
        //     Console.WriteLine(n);
        // int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
        // var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);
        // var evens2 = from i in numbers
        //     where i%2==0 && i>10
        //     select i;
        var people = new List<Person>
        {
            new Person ("Tom", 23, new List<string> {"english", "german"}),
            new Person ("Bob", 27, new List<string> {"english", "french" }),
            new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
            new Person ("Alice", 24, new List<string> {"spanish", "german" })
        };
        var selectedPeople = people.SelectMany(u => u.Languages,
                (u, l) => new { Person = u, Lang = l })
            .Where(u => u.Lang == "english" && u.Person.Age < 28)
            .Select(u=>u.Person);
    }
}

// class Person
// {
//     string name;
//     int age;
//     public string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }
//     public int Age
//     {
//         get { return age; }
//         set { age = value; }
//     }
//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
// }

record class Person(string Name, int Age, List<string> Languages);