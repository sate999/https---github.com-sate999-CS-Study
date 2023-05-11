// break문
// 말그대로 탈출하다의 의미 루프, switch문에서 사용

using System;

namespace ex16
{
    class ex16
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num < 100)   // num보다 100이 크면 계속 반복
            {
                if (num == 40) break;   // num이 40이면 break로 인해 반복 탈출
                Console.WriteLine("num : " + num);
                num++;  // num의 값 1 증가
            }
        }
    }
}