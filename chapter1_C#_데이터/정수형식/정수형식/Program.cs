using System;

namespace 정수형식
{
    class Program
    {
        static void Main(string[] args)
        {

            //데이터 + 로직
            // 체력 0

            //byte(1바이트 0 ~255), short(2바이트 -3만 ~ 3만), int(4바이트 -21억 ~ 21억 ),long(8바이트)
            //sbyte (1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트 0 ~ 43억 ) , ulong(8바이트)
            int hp;
            hp = 100;

            short level = 100;

            long id;
            //아이템 의 고유 식별 번호로 사용 되기도 한다.

            byte attack = 0;
            attack--; 
            //이러면 공격성이 255되었다 언더 플로우

            Console.WriteLine("Hello Number ! {0}", attack);
        }
    }
}
