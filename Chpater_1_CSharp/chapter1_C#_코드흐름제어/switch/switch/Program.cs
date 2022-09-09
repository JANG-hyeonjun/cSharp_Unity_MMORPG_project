using System;

namespace if와else
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hp = 10;
            //bool isDead = (hp <= 0);
            //if (isDead)
            //{
            //    Console.WriteLine("Your are dead!");
            //    Console.WriteLine("Your are dead!");
            //    Console.WriteLine("Your are dead!");
            //    //범위를 지정해서 아이템을 떨군 다거나 경험치를 줄인다거나 
            //    // 마을로 리스폰 
            //}
            //else
            //{
            //    Console.WriteLine("Your are Alive!");
            //}
            int choice = 0; // 0.가위 1.바위 2.보 3.치트키


            //    switch(choice) //정수랑 문자열 최근엔 객체도 넣을 수 있다.
            //    {
            //        case 0:
            //            Console.WriteLine("가위 입니다.");
            //            break;
            //        case 1:
            //            Console.WriteLine("바위 입니다.");
            //            break;
            //        case 2:
            //            Console.WriteLine("보 입니다.");
            //            break;
            //        case 3:
            //            Console.WriteLine("치트키 입니다.");
            //            break;
            //        default:
            //            Console.WriteLine("다 실패했습니다.");
            //            break;
            //    }

            //    if (choice == 0)
            //    {
            //        Console.WriteLine("가위 입니다.");
            //    }
            //    else if (choice == 1)
            //    {
            //        Console.WriteLine("바위 입니다.");
            //    }
            //    else if (choice == 2)
            //    {
            //        Console.WriteLine("보 입니다.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("치트키 입니다.");
            //    }

            ///삼항 연산자 ////////////////

            int number = 25;
            bool isPair = ((number % 2) == 0 ? true : false);
            
            if ((number % 2) == 0)
                isPair = true;
            else
                isPair = false;



        }
     }
}
