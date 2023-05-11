// 메서드 오버로딩(Method Overloading)
// 오버로딩이란 메서드명을 중복하여 다르게 구현하는 것
// C언어에서는 불가능했지만 C#에서는 가능~!
// 아래는 메서드 오버로딩의 이해를 돕기위한 예제입니다

using System;

namespace ex4
{
    class ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Add(50, 10));
            Console.WriteLine("{0}", Add(544.2, 63.2));
            Console.WriteLine("{0}", Add(4, 7, 9));
        }

        static int Add(int a, int b)
        {
            Console.WriteLine("두 int형 끼리의 덧셈");
            return a + b;
        }

        static double Add(double a, double b)
        {
            Console.WriteLine("두 double형 끼리의 덧셈");
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            Console.WriteLine("세 int형 끼리의 덧셈");
            return a + b + c;
        }
    }
}

// Add 메서드로 세 번이나 다른 형태의 값들을 전달하였음에도 불구하고
// 결과를 보면 제대로 출력됨을 확인함
// 이처럼, 매개변수의 형식과 수에 따라 호출되는 메서드가 다름을 알 수 있다.