// 배열이란 동일한 타입의 변수를 모아놓은 데이터 집합
// 배열에 접근할 때는 첨자값(index)
// 첨자값은 항상 0부터 시작한다
// 자료형[] 배열명 = new 자료형[크기];
// 아래는 C#에서의 배열을 이해하기 위한 예제입니다.

using System;

namespace ex1
{
    class ex1
    {
        static void Main(string[] args)
        {
            //int[] reading = new int[6] {4, 9, 1, 0, 21, 12};
            int[] reading = {4, 9, 1, 0, 21, 12};

            for(int i = 0; i < reading.Length; i++)
                Console.WriteLine("reading[" + i + "] = {0}", reading[i]);
        }
    }
}