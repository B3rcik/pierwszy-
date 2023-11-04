using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj a");
            a = System.Int16.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = System.Int16.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = System.Int16.Parse(Console.ReadLine());
            Console.WriteLine("---");
            if (a > b & a > a)
                Console.Write(a);
            if (b > a & b > c)
                Console.Write(b);
            if (c > a & c > b)
                Console.Write(c);
        }
    }
}