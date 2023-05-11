// continue문
// 조건을 검사하는 부분으로 넘어가 반복을 계속 수행하는 역할
// continue문을 만나면 바로 조건 검사부분으로 넘어간다
// 아래는 for문에 continue문을 사용한 예제

using System;

namespace ex17
{
    class ex17
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 1) continue;
                Console.WriteLine("i : " + i);
            }
        }
    }
}