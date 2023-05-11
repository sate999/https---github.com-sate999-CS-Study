using System;

namespace ex9
{
    class ex9
    {
        static void Main(string[] args)
        {
           String day = "수" ;

           switch(day)
           {
            case "일":
                Console.WriteLine("일요일");
                break;
            
            case "월":
                Console.WriteLine("월요일");
                break;
            
            case "화":
                Console.WriteLine("화요일");
                break;
            
            case "수":
                Console.WriteLine("수요일");
                break;

            case "목":
                Console.WriteLine("목요일");
                break;
            
            case "금":
                Console.WriteLine("금요일");
                break;

            case "토":
                Console.WriteLine("토요일");
                break;
            
            default:
                Console.WriteLine("아무 요일에도 해당하지 않습니다.");
                break;

           }
        }
    }
}