using System;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("podaj rok urodzin");
        {
            int data = int.Parse(Console.ReadLine());
         

            if (data == 2002)


                Console.WriteLine("Wszystkiego najlepszego!");

            else if (data < 2002)

                Console.WriteLine("niestety dzisiaj rózga");
            else if (data > 2002)


            Console.WriteLine("niestety dzisiaj rózga");
        }
    }
}
