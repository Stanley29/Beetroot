namespace Lesson13_Abstract;

public class Buyer
{
    string Name { get; set; }
    int Index { get; }
    List<Product> Owned { get; set; }

    public Buyer(string name)
    {
        Name = name;
    }

}