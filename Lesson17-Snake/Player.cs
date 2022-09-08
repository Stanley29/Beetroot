namespace Lesson17_Snake;

public class Player
{
    public Pixel Head { get; set; }
    public Queue<Pixel> Body = new Queue<Pixel>();
    public char HeadChar { get; }
    public char BodyChar { get; }

    public Player(int x, int y, char headChar, char bodyChar, int lenght = 1)
    {
        HeadChar = headChar;
        BodyChar = bodyChar;
        Head = new Pixel(x, y, headChar);
        for (int i = lenght; i > 0; i--)
        {
            Body.Enqueue(new Pixel(Head.X - i, Head.Y, BodyChar));
        }
    }

    public delegate void Move();

    public void Death()
    {
        Clear();
        Console.SetCursorPosition(10,10);
        Console.WriteLine("Game over!!!");
    }

    public void Grow()
    {
        Body.Enqueue(new Pixel(Head.X, Head.Y, BodyChar));
    }
    
    public Move ChangeDirection(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.W: return MoveUp;
            case ConsoleKey.S: return MoveDown;
            case ConsoleKey.A: return MoveLeft;
            case ConsoleKey.D: return MoveRight;
        }

        return Draw;
    }

    private void MoveUp()
    {
        Clear();
        
        Body.Enqueue(new Pixel(Head.X, Head.Y, BodyChar));
        Body.Dequeue();
        Head = new Pixel(Head.X, Head.Y - 1, HeadChar);
        
        Draw();
    }
    
    private void MoveDown()
    {
        Clear();
        
        Body.Enqueue(new Pixel(Head.X, Head.Y, BodyChar));
        Body.Dequeue();
        Head = new Pixel(Head.X, Head.Y + 1, HeadChar);
        
        Draw();
    }
    
    private void MoveLeft()
    {
        Clear();
        
        Body.Enqueue(new Pixel(Head.X, Head.Y, BodyChar));
        Body.Dequeue();
        Head = new Pixel(Head.X - 1, Head.Y, HeadChar);
        
        Draw();
    }
    
    private void MoveRight()
    {
        Clear();
        
        Body.Enqueue(new Pixel(Head.X, Head.Y, BodyChar));
        Body.Dequeue();
        Head = new Pixel(Head.X + 1, Head.Y, HeadChar);
        
        Draw();
    }
    
    public void Draw()
    {
        Head.Draw();

        foreach (var pixel in Body)
        {
            pixel.Draw();
        }
    }

    public void Clear()
    {
        Head.Clear();

        foreach (var pixel in Body)
        {
            pixel.Clear();
        }
    }
    
}