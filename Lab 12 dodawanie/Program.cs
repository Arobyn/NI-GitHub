﻿using System;

namespace Lab_12_dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;

            Console.WriteLine("Podaj pierwszą liczbę ");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę ");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę ");
            c = Double.Parse(Console.ReadLine());

            Console.WriteLine("Suma podanych liczb to: "+(a+b+c));
        }
    }
}
