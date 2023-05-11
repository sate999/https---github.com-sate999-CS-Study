// 반복문 do~while 문
// while문과는 달리 do~while문은 먼저 한번 코드를 실행시키고 그다음에 조건식 검사
// C,C++과 동일함

using System;

namespace ex11
{
    class ex11
    {
        static void Main(string[] args)
        {
            int num = 1;

            do
            {
                Console.WriteLine("num: {0}", num++);
            }while(num <= 10);
        }
    }
}