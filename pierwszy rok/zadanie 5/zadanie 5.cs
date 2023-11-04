using System;
{
{
    Console.WriteLine("podaj współczynnik a różny od zera");
    Console.WriteLine("podaj współczynnik b różny od zera");
    Console.WriteLine("podaj współczynnik c różny od zera");

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    double delta = b * b - 4 * a * c;
    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("pierwiastki trójmianu kwadratowego to:");
        Console.WriteLine("x1 =" + x1);
        Console.WriteLine("x2 =" + x2);
    }
     else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("trójmian kwadratowy ma jeden pierwiastek podwójny");
            Console.WriteLine("x:" + x);
        }

        else
        {
            Console.WriteLine("trójmian kwadratowy nie ma pierwiastków rzeczywistych");
        }
    }
}