namespace Tests;


public class Animal  // Base class (parent) 
{
    public virtual void animalSound() 
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Pig : Animal  // Derived class (child) 
{
    public override void animalSound() 
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

public class Dog : Animal  // Derived class (child) 
{
    public override void animalSound() 
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
