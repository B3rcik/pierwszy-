using System;

    internal class Program
{
    private static void Main(string[] args)
    {
        double result;
        result = 6.2 / 0.31;
        result -= 5.0 / 6.0 * 0.9;
        result *= 0.2;
        result += 0.15;
        result /= 0.02;
        result *= result * result;

        Console.WriteLine($"Wynik : {result}");


    }
}





