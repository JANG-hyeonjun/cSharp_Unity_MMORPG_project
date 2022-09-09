using System;

namespace 디버깅기초
{
    class Program
    {
        //프로시저 -> 실행단위 메서드 
        //메소드 호출 => Inception
        //현실 -> 1차꿈 -> 2차꿈 

        //호출경로는 지금까지 불러와진 경로가 기록된것 
        //이 디버깅의 조건식을 언제쓰냐 하면 예를들어 수많은 몬스터들의 아이디가존재할텐데
        //그아이디를 가진 몬스터의 변화량을 좀 지켜보고 싶다 이런상황에 사용될수 있는것

        //또한 중단점을 왼클릭으로 끌어서 과거의 상황을 다시 볼수도 있다. -> 코드가 실행되던 위치를 변경(거기서 부터 다시 코드가 실행)
        //또한 어떤 조건을 넘기는 것도 가능하다.
        static void Print(int value)
        {
            Console.WriteLine(value);
        }

        static int AddAndPrint(int a,int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }
        
        static void Main(string[] args)
        {
            Program.AddAndPrint(5, 20);
            Program.AddAndPrint(6, 20);
            Program.AddAndPrint(3, 20);
            Program.AddAndPrint(12, 20);
            Program.AddAndPrint(10, 20);
            
        }
    }
}
