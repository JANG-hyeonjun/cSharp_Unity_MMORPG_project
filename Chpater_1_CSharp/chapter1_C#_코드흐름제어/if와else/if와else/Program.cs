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
            int choice = 1; // 0.가위 1.바위 2.보 3.치트키

            if (choice == 0)
            {
                Console.WriteLine("가위 입니다.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("바위 입니다.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("보 입니다.");
            }
            else
            {
                Console.WriteLine("치트키 입니다.");
            }
        }
    }
}
