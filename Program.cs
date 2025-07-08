Using system;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prosty kalkulator!");
        Console.Write($"10 + 5 = ", { Add(10,5) });
        Console.Write($"10 - 5 = ", { Sub(10, 5) });
        Console.Write($"10 * 5 = ", { Multiply(10, 5) });
    }
    static int Add(x, y)
    {
        return x + y
    }
    static int Sub(x, y)
    {
        return x - y
    }
    static int Multiply(x, y)
    {
        return x * y;
    }
}