using System;

namespace 은닉성
{
    class Program
    {
        //OOP(은닉성/상속성/다형성)
        //은닉성은 보안레벨에 관련이 있다.

        /*
         //자동차
         //핸들 페달 차문 -> 사용자
         //더 내부적으로는 전기장치 엔진 기름 <-> 외부노출할 필요가 없다.
        */

        class Knight
        {
            //접근 한정자
            //public protected private //알면 좋다 internal protectd internal
            protected int hp;

            public void Sethp(int hp)
            {
                this.hp = hp;
            }
        }

        class SuperKnight : Knight
        {
            void Test()
            {
                hp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Sethp(100);
        }
    }
}
