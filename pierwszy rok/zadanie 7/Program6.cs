using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wiek");
        int wiek = int.Parse(Console.ReadLine());
        if (wiek >= 18)
        {
            Console.WriteLine("Jesteś pełnoletni");
        }
        else
        {
            Console.WriteLine("Jesteś niepełnoletni");
        }
    }
}




