using System.Collections;

class Collection
{
    static void Main(string[] args)
    {
        Numbers numbers = new Numbers();
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}

class Numbers
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return i * i;
        }
    }
}

class WeekEnumerator : IEnumerator
{
    string[] days;
    int position = -1;
    public WeekEnumerator(string[] days) => this.days = days;
    public object Current
    {
        get
        {
            if (position == -1 || position >= days.Length)
                throw new ArgumentException();
            return days[position];
        }
    }
    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }
    public void Reset() => position = -1;
}
class Week
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
        "Friday", "Saturday", "Sunday" };
    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
}