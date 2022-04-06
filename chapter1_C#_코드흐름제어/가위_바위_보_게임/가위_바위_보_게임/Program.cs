using System;

namespace 가위_바위_보_게임
{
    class Program
    {
        static void Main(string[] args)
        {
            //0: 가위 1: 바위 2: 보
            Random rand = new Random();
            int aichoice = rand.Next(0,3); // 0 ~ 2의 랜덤 값 

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위 입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위 입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보 입니다.");
                    break;
            
            }


            switch (aichoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위 입니다.");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위 입니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보 입니다.");
                    break;
            }


            //승리 무승부 패배
            if(aichoice == choice)
            {
                Console.WriteLine("무승부 입니다.");
            }
            else if(choice == 0 && aichoice == 2)
            {
                Console.WriteLine("승리 입니다.");
            }
            else if (choice == 1 && aichoice == 0)
            {
                Console.WriteLine("승리 입니다.");
            }
            else if (choice == 2 && aichoice == 1)
            {
                Console.WriteLine("승리 입니다.");
            }
            else
            {
                Console.WriteLine("패배 입니다.");
            }
        }
    }
}
