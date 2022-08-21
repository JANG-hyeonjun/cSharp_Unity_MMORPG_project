using System;

namespace 복사_값_와참조
{
    
    // 기본적으로 참조 
    //클래스로 선언되어 있을경우 무조건 참조를 해서 변수를 넘기게 됨 
    class Knight
    {
        public int hp;
        public int attack;

        //DeepCopy
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    //기본적으로 복사 (기본적으로 카피를 해서 변수를 넘기기 때문)
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
            
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;

        }

        static void Main(string[] args)
        {
            //아무래도 절차 지향적인 프로그래밍은 함수에 호출 순서 인자에 매우 종속적
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage;
            mage2.hp = 0;
            //KillMage(mage);
            //기본행동은 복사본으로 처리해줘

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
            ////Knight knight2 = knight;
            //knight2.hp = knight.hp;
            //knight2.attack = knight.attack;

            //KillKnight(knight);
            //ref로 명시하지 않아도 그냥 참조가 되어서 호출 되는 함수인자로 넘아감 
        }
    }
}
