using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = double.Parse(Console.ReadLine());

        if (liczba1 > liczba2)
        {
            Console.WriteLine("Większa liczba to: " + liczba1);
        }
        else if (liczba2 > liczba1)
        {
            Console.WriteLine("Większa liczba to: " + liczba2);
        }
        else
        {
            Console.WriteLine("Podane liczby są równe.");
        }
    }
}
