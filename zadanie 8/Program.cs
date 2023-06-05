public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, dod, ode, mno, dzi;
        Console.WriteLine("Podaj liczby a, b oraz numer działania:\n1. Dodawanie\n2. Odejmowanie\n3. Mnożenie\n4. Dzielenie");
        Console.WriteLine("\nLiczba a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Liczba b:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Numer działania:");
        c = double.Parse(Console.ReadLine());
        dod = a + b;
        ode = a - b;
        mno = a * b;
        dzi = a / b;

        while(c < 1 || c > 4)
        {
            Console.WriteLine("Proszę o wpisanie poprawnego numeru działania");
            c = double.Parse(Console.ReadLine());
        }
        if (c == 1)
            Console.WriteLine("\n" + dod);
        else if (c == 2)
            Console.WriteLine("\n" + ode);
        else if (c == 3)
            Console.WriteLine("\n" + mno);
        else if (c == 4)
        {
            if (b == 0)
            Console.WriteLine("\n" + a + "/0");
            else
            Console.WriteLine("\n" + dzi);
        }
    }
}