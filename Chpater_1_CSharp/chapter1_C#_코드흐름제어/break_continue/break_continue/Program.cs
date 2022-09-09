using System;

namespace break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 97;

            //bool isPrime = true;
            //for(int i = 2; i < num; i++)
            //{
            //    //특정 조건 
            //    if((num % i) == 0)
            //    {
            //        isPrime = false;
            //        break; //while도 가능
            //    }
            //}
            //if(isPrime)
            //    Console.WriteLine("소수입니다.");
            //else
            //    Console.WriteLine("소수가 아닙니다.");    
        
        
            ////////////continue///////////
            for(int i = 1; i < 100; i++)
            {
                if ((i % 3) != 0)
                    continue;

                Console.WriteLine($"3으로나뉘는 숫자 발견 :{i}");
            
                //예를 들어 continue는 힐러가 버프를 주는데 우리파티원만 주어야한다.
                //주변에 있는 유저를 스캔 그후 우리파티원만 선별할때 (예시)

            }
        
        }
    }
}
