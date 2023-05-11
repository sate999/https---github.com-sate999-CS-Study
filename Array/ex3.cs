// 다차원 배열(Multidimensional array)
// 말 그대로 여러 개의 차원을 다루는 배열이다.
// 자료형[,] 배열명 = new 자료형[행, 열];
// 아래는 2차원 배열을 이해하기 위한 예제입니다.

using System;

namespace ex3
{
    class ex3
    {
        static void Main(string[] args)
        {
            int[,] reading = new int[3, 6]{{4, 9, 1, 0, 21, 12}, {1, 4, 6, 0, 9, 5}, {4, 4, 2, 4, 0, 0}};

        for(int i = 0; i < reading.GetLength(0); i++)
            for(int j = 0; j<reading.GetLength(1); j++)
                Console.WriteLine("reading[" + i + ", " + j + "] = {0}", reading[i, j]);
        }
    }
}