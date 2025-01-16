using System;

namespace Lab_12_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b;
            Console.WriteLine("Podaj pierwszą liczbę ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Suma podanych liczb to: "+(a+b));
        }
    }
}
