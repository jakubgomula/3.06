public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Sprawdź czy trójkąt o podanych bokach a,b,c jest równoboczny");
        Console.WriteLine("Podaj a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj c:");
        c = double.Parse(Console.ReadLine());

        if (a == b & b == c)
            Console.WriteLine("Trójkąt o podanych bokach jest równoboczny");
        else 
            Console.WriteLine("Trójkąt o podanych bokach nie jest równoboczny");
    }
}