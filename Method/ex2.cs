// Call by value & Call by reference
// 전자는 복사에 의한 함수 호출
// 후자는 참조에 의한 호출 
// 아래는 Call by value에 대한 이해를 돕기 위한 예제

using System;

namespace ex2
{
    class ex2
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 10;

            Console.WriteLine("Swap before : a = {0}, b = {1}", a, b);

            Swap(a, b);
            
            Console.WriteLine("Swap after : a = {0}, b = {1}", a, b);
        }

        static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}

// Swap 함수를 만들어서 값을 임시로 담아둘 변수 temp를 선언하고
// temp란 변수의 값을 b의 값으로 초기화 시킨다
// 그러고는 b에 a의 값을 담습니다.
// 그리고 a에는 temp(원래 b의 값)을 담는다.
// 즉, Swap 함수는 a와 b의 값을 서로 바꿔버리는 기능을 수행
// 여기서 이렇게 매개변수를 변수의 값으로 가져온 경우를 Call by value라고 한다.
// 그러므로 Swap 함수가 실행되지 않은것
// WHY??? 
// 그저 변수 a와 b의 값을, 매개변수 a와 b로 "복사"하는 것일 뿐
// 한마디로 말하자면, 매개변수 a와 b는 변수 a와 b랑은 서로 별개이며 다른 메모리 공간을 사용
// 바꾸려면 어떻게 해야할까요?
// Call by reference라면 가능
// WHY???
// Call by value와는 달리, 변수의 주소값을 매개변수로 보내기 때문에 ㅋ