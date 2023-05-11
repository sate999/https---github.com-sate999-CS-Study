// 아래의 예제는 Call by reference의 이해를 돕기위한 예제입니다.

using System;

namespace ex3
{
    class ex3
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 10;

            Console.WriteLine("Swap before : a = {0}, b = {1}", a, b);

            Swap(ref a, ref b);

            Console.WriteLine("Swap after : a = {0}, b = {1}", a, b);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}

// ex2와 비교해보면 ref 라는 놈이 새로 등장
// ref 키워드는 매개변수를 참조형식으로 사용할 때 사용되는 키워드
// 메서드의 선언, 호출 부분에 ref 키워드를 달아주면
// 그게 곧 Call by reference로 넘겨주는 방법입니다.