namespace zadanie3
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("podaj pierwszą liczbe");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj drugą liczbe");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj trzecią liczbe");
            c=Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                if (c>a) { Console.WriteLine(c); }
                else { Console.WriteLine(a); }


            }else { if (b > c) { Console.WriteLine(b); }
                else { Console.WriteLine(c); }
            }

        }
    }
}