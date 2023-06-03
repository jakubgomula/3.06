using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, a, b, c, d;

        Console.WriteLine("Podaj a");
        a = inputValue();
        Console.WriteLine("Podaj b");
        b = inputValue();
        Console.WriteLine("Podaj c");
        c = inputValue();
        Console.WriteLine("Podaj d");
        d = inputValue();

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            x = ((a * d) + (b * c));
            y = (b * d);
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
