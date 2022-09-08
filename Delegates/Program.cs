class Program
{

    static void Main(string[] args)
    {
        // SomeDel a;
        // a = SomeMethod1;
        // a.Invoke(1, 2);

        Test a = Func1;
        a += Func2;
        Console.WriteLine(a(2));

    }
    
    // delegate void Message();
    // static void Hello() => Console.WriteLine("Hello world");
    //
    // delegate void SomeDel(int a, double b);
    // static void SomeMethod1(int g, double n) => Console.WriteLine("SomeMethod1");

    delegate int Test(int a);

    static int Func1(int a) => a * a;

    static int Func2(int a) => a * a * a;

}