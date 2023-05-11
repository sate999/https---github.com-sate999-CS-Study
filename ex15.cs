/* 무한 루프를 이용하여 입력 받은 숫자를 모두 더하는 코드
예외 처리 에러가 나기 때문에 
TryParse()를 쓰거나 try-catch문을 사용하여 예외를 처리해야한다.
하지만 try-catch문을 사용하면 예외 처리에 비용이 들어가므로 
코드이 실행 속도가 더뎌질 수 있다.
따라서 try-catch문 보다는 int.TryParse() 메서드를 사용하는 것이 성능면에서 우수
하지만 지금 배우는 단계에서는 try-catch문을 써보도록 하자*/
using System;

namespace ex15
{
    class ex15
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                try
                {
                    string line = Console.ReadLine();
                    if(line == "end") break;

                    int number = int.Parse(line);
                    sum += number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("숫자를 입력해주세요 : ");
                }
            }

            Console.WriteLine("지금까지 입력된 수를 모두 더합니다 : " + sum);
        }
    }
}