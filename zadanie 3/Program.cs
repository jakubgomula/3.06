public class MyProgram
{
    public static void Main(string[] args)
    {
        double w,h,bmi;
        Console.WriteLine("Wyznaczanie BMI");
        Console.WriteLine("Podaj swoją wagę i wzrost:");
        Console.WriteLine("Waga w Kilogramach:");
        w = inputValue();
        Console.WriteLine("Wzrost w metrach");
        h = inputValue();
        bmi = w / Math.Pow(h, 2);
        Console.WriteLine("Twoje BMI wynosi:");

        Console.WriteLine(bmi);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}