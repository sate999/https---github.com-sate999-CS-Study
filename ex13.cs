// foreach문
// 배열에 순회하며 차례차례 접근하는 반복문
// 개념은 C, C++과 동일함

using System;

namespace ex13
{
    class ex13
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,5,7,4,9,8,10,4,7,11};

            foreach(int i in arr)
                Console.WriteLine("i : {0}", i);
        }
    }
}
