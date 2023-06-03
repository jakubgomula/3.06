public class Myprogram
{
    public static void Main(string[] args)
    {
        double p, o, r;

        Console.WriteLine("Podaj pole koła:");
        p = inputValue();
        r = Math.Sqrt(p / Math.PI);
        o = 2 * Math.PI * r;

        Console.WriteLine("Obwód tego koła wynosi:");

        Console.WriteLine(o);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}