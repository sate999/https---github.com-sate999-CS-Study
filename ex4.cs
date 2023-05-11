using System;

namespace ex4
{
    class ex4
    {
        static void Main(string[] args)
        {
            int a = 12345;

            Console.WriteLine("|{0,15}|", a);
            Console.WriteLine("|{0,-15}|", a);
            Console.WriteLine("|{0,15:N0}|", a);
            Console.WriteLine("|{0,-15:N0}|", a);
        }
    }
}