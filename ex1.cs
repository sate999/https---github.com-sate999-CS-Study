using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex1
{
    class ex1{
        static void Main(string[] args)
        {
            int a = 81, b = 27;

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);  // 81 + 27 = 108
            Console.WriteLine("{0} + {1} = {2}", a, b, b - a);  // 27 = 81 = -54
        }
    }
}