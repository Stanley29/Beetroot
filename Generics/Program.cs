class Program
{
    static void Main(string[] args)
    {
        // Person tom = new Person(546, "Tom");
        // Person bob = new Person("abc123", "Bob");
        // int tomId = (int)tom.Id;
        // string bobId = (string) bob.Id;
        //
        // Console.WriteLine(tomId);
        // Console.WriteLine(bobId);
        //
        
        // Person<int> tom = new Person<int>(546, "Tom");
        // Person<string> bob = new Person<string>("abc123", "Bob");
        // int tomId = tom.Id;
        // string bobId = bob.Id;
        // Console.WriteLine(tomId);
        // Person<int> tom = new Person<int>(546, "Tom");
        // Company<Person<int>> microsoft =  new Company<Person<int>>(tom);
        //
        // Console.WriteLine(microsoft.CEO.Id);  // 546
        // Console.WriteLine(microsoft.CEO.Name);  // Tom
        int x = 7;
        int y = 25;
        Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
        Console.WriteLine($"x={x}    y={y}");   // x=25   y=7
        string s1 = "hello";
        string s2 = "bye";
        Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
        Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello
    }
    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}

// class Person
// {
//     public object Id { get; }
//     public string Name { get; }
//     public Person(object id, string name)
//     {
//         Id = id; 
//         Name = name;
//     }
// }
//
// class Person<T>
// {
//     public T Id { get; set; }
//     public string Name { get; set; }
//     public Person(T id, string name)
//     {
//         Id = id; 
//         Name = name;
//     }
// }

// class Company<P>
// {
//     public P CEO { get; set; }  // президент компании
//     public Company(P ceo)
//     {
//         CEO = ceo;
//     }
// }
// class Person<T>
// {
//     public T Id { get;}
//     public string Name { get;}
//     public Person(T id, string name)
//     {
//         Id = id; 
//         Name = name;
//     }
// }
// class Person<T, K>
// {
//     public T Id { get;}
//     public K Password { get; set; }
//     public string Name { get;}
//     public Person(T id, K password, string name)
//     {
//         Id = id; 
//         Name = name;
//         Password = password;
//     }
// }

