// ref 키워드가 사용된 예제 입니다.

using System;

namespace ex5
{
    class ex5
    {
        static void Main(string[] args)
        {
            int a = 40;

            Add(ref a, 100);
            Console.WriteLine("a = {0}", a);

            Add(ref a, 200);
            Console.WriteLine("a = {0}", a);

            Add(ref a, 300);
            Console.WriteLine("a = {0}", a);

        }
        
        static void Add(ref int a, int b)
        {
            a += b; // a = a + b;
        }
    }
}

// 코드를 보시면, ref 키워드가 메서드를 호출할때도 쓰였고 매개변수에서도 사용됨
// Add 메서드의 매개변수에 변수 a의 주소값을 넘겨주는 셈
// 실제 a의 주소를 안 Add 메서드는 a에다 매개변수 b의 값을 a에다 더합니다.
// ref 매개변수를 사용하려면 메서드를 호출할때나, 메서드를 정의할때도 ref 키워드를 명시적으로 사용해주어야한다.
