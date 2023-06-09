public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, n;
        a = 0;
        Console.WriteLine("Podaj liczbę naturalną:");
        n = int.Parse(Console.ReadLine());
        n =OstatniaCyfra(a,n);
        Console.WriteLine("\nOstatnia cyfra Twojej liczby to: " + n);
    }
    
    public static int OstatniaCyfra(int a, int n)
    {
        a = n % 10;

        return a;
    }
}