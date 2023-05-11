// 반복문 while 
// 조건식이 참일때 계속해서 반복 실행
// C,C++과 동일하다

using System;

namespace ex10
{
    class ex10
    {
        static void Main(string[] args)
        {
            int num = 1;

            while(num<=10)
            Console.WriteLine("num : {0}", num++);
        }
    }
}