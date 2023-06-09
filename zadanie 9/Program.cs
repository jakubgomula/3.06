public class MyProgram
{
    static void Swap(ref int a, ref int b, ref int c)
    {
        a ^= b;
        b ^= a;
        a ^= b;
        c ^= a;
        a ^= c;
        c ^= a;
    }
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Podaj a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj c:");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("\na = "+a+"\nb = "+b+"\nc = "+c);
        Swap(ref a, ref b, ref c);
        Console.WriteLine("\na = " + a + "\nb = " + b + "\nc = " + c);
    }
}