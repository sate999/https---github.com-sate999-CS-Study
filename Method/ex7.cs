// params 키워드
// 우리가 만약, 길이에 제한받지 않고 수를 넘겨주어
// 그 수의 총 합을 구하고 싶을때는 어떻게 하면 될까요?
// params 키워드를 사용하면 메서드에 여러개의 값을 전달할 수 있도록 도와준다.
// 아래는 params 키워드가 사용된 예제입니다.

using System;

namespace ex7
{
    class ex7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum = {0}", total(20, 10, 40 ,4, 7, 6, 44, 55, 2));
            Console.WriteLine("sum = {0}", total(30, 4, 5));
        }
        static int total(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
                sum += list[i];

            return sum;

        }
    }
}