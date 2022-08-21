using System;

namespace 객체지향시작
{
    //객체

    //속성(data) , 기능(method)
    //Ex Knight
    //속성: hp,attack,pos
    //기능: Move, Attack, Die

    class Knight
    {
        public int hp;
        public int attack;
        
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //아무래도 절차 지향적인 프로그래밍은 함수에 호출 순서 인자에 매우 종속적
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}
