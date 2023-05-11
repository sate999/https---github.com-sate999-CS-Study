// for문 중첩
// 반복문 중첩을 이용하여 구구단을 출력해보자

using System;

namespace ex14
{
    class ex14
    {
        static void Main(string[] args)
        {
            for(int a = 2;a<10;a++)
            {
                for(int b = 1; b < 10; b++)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, a*b);
                }
            }
        }
    }
}