using Lesson10_Classes;

Library a = new Library();
Library b = new Library("Library 1");
Library c = new Library("Library 2", 3, new List<string>() {"Book A", "Book B", "Book C"});

a.ShowInfo();
Console.WriteLine("-------------------------------------------");
b.ShowInfo();
Console.WriteLine("-------------------------------------------");
c.ShowInfo();