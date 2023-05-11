// out 키워드
// out 키워드는 ref 키워드와 비슷하게 인수를 참조로 전달할때 사용됩니다.
// 그러나 차이점이 존재, out 키워드를 사용하면 변수를 전달하기전 초기화해야하는
// ref 키워드와는 달리 초기화 하지 않고도 전달이 가능
// 아래는 out 키워드의 사용 예제입니다.

using System;

namespace ex6
{
    class ex6
    {
        static void Main(string[] args)
        {
            int a;

            Add(out a);
            Console.WriteLine("a = {0}", a);
            
        }

        static void Add(out int a)
        {
            a = 100;
        }
    }
}