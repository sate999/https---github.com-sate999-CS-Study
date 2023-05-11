using System;

namespace ex2
{
    class ex2{
        static void Main(string[] args)
        {
            int a = 12345678;
            double b = 12.345678;

            Console.WriteLine("통화 (C) . . . : {0:C}", a);
            Console.WriteLine("10진법 (D) . . . : {0:D}", a);
            Console.WriteLine("지수 표기법 (E) . . . : {0:E}", b);
            Console.WriteLine("고정 소수점 (F) . . . : {0:F}", b);
            Console.WriteLine("일반 (G) . . . : {0:G}", a);
            Console.WriteLine("숫자 (N) . . . : {0:N}", a);
            Console.WriteLine("16진법 (X) . . . : {0:X}", a);
            Console.WriteLine("백분율 (P) . . . : {0:P}", b);
        }
    }
}