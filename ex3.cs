using System;

namespace ex3
{
    class ex3
    {
        static void Main(string[] args)
        {
            int a = 1234;
            double b = 12.345678;

            Console.WriteLine("0 자리 표시 (0) . . . : {0:00000}", a);
            Console.WriteLine("10진수 자리 표시 (#) . . . : {0:#####}", a);
            Console.WriteLine("소수점 (.) . . . : {0:0.00000}", b);
            Console.WriteLine("천 단위 자릿수 표시 (,) . . . : {0:0,0}", a);
            Console.WriteLine("백분율 자리 표시 (%) . . . : {0:0%}", a);
            Console.WriteLine("지수 표기법 (e) . . . : {0:0.000e+0}", b);
        }
    }
}