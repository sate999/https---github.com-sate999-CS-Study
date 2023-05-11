// goto문
// 해당 레이블로 뛰어넘어버리는 기능
// 레이블(Label)이란? 코드 내의 위치를 나타내주는 역할
// 아래는 goto문을 이용하여 작성한 예제
using System;

namespace ex18
{
    class ex18
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num < 100)   // num 보다 100이 크면 계속 반복
            {
                if (num == 40) goto EXIT;   // num이 40이면 break로 인해 반복 탈출
                Console.WriteLine("num : " + num);
                num++;  // num의 값 1 증가
            }

            EXIT: // EXIT 레이블
            Console.WriteLine("탈출!");
        }
    }
}