using System;

namespace ex5
{
    class ex5
    {
        static void Main(string[] args)
        {
            int a = 500;
            float b = a;

            Console.WriteLine("a = {0}, b = {1}", a, b);

            double c = 123.45;
            int d = (int)c;

            Console.WriteLine("c = {0}, d = {1}", c, d);
        }
    }
}