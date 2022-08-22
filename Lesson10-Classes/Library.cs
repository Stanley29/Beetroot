using System.Text;

namespace Lesson10_Classes;

public class Library
{
    private static Random random = new Random();
    string name;
    int numberOfBooks;
    List<string> listOfBooks = new List<string>();

    #region Ctors

    public Library(string name, int numberOfBooks, List<string> listOfBooks)
    {
        this.name = name;
        this.numberOfBooks = numberOfBooks;
        this.listOfBooks = listOfBooks;
    }

    public Library(string name)
        :this()
    {
        this.name = name;
    }
    
    public Library()
    {
        name = RandomName();
        numberOfBooks = random.Next(6);
        while (listOfBooks.Count < numberOfBooks)
        {
            listOfBooks.Add(RandomName());
        }
    }

    #endregion

    #region Methods

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Number of books: {numberOfBooks}");
        foreach (var book in listOfBooks)
        {
            Console.WriteLine(book);
        }
    }
    
    private static string RandomName()
    {
        StringBuilder result = new StringBuilder();
        string letterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < 5; i++)
        {
            result.Append(letterSet[random.Next(letterSet.Length)]);
        }

        return result.ToString();
    }

    #endregion
}