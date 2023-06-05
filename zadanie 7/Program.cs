public class MyProgram
{
    public static void Main(string[] args)
    {
        double x,y,r,o;
        Console.WriteLine("Sprawdź czy punkt P(x,y) leży w obrębie koła o środku w punkcie O(0,0) i promieniu r");
        Console.WriteLine("Podaj x:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj y:");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj r:");
        r = double.Parse(Console.ReadLine());
        if ((x * x + y * y) <= (r * r))
            Console.WriteLine("Punkt (" + x + "," + y + ") leży w obrębie koław o środku (0,0) i promieniu " + r);
        else
            Console.WriteLine("Punkt (" + x + "," + y + ") nie leży w obrębie koław o środku (0,0) i promieniu " + r);
    }
}