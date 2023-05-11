// 메서드(Method)
// C와 C++의 함수(Function)과 비슷한 기능을 한다
// 메서드를 간단히 나타내자면 이어지는 코드들을 묶어놓은 코드 블록
// 접근 지정자(Access Modifier)
// 종류는 private / public / protected 등이 있다
// 메서드의 반환형식은 메서드의 결과에 따라 다르다
// 반환되는 데이터의 형식이 int형이라면 int를 쓰고 double형이라면 double을 
// 반환형식에 적어주어야한다.
// 리턴값이 없다면 void를 적으면 된다.
// 매개변수 목록은 메서드 호출 시 값을 넘길 수 있도록 하는 '매개변수'가 1개 이상 등장한다.

// 아래의 예제는 반환형식의 이해를 돕기위한 예제

using System;

namespace ex1
{
    class ex1 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Division(40,10));
        }

        static int Division(int a, int b)
        {
            return a / b;
        }
    }
}