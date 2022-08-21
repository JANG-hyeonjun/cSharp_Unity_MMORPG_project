using System;

namespace 상속
{
    class Player
    {
        static public int counter = 1; //오로지 한개만 존재 한다.
        public int id;
        public int hp;
        public int attack;
        //public Player()
        //{
        //    Console.WriteLine("Player생성자 호출");
        //}
        //public Player(int hp)
        //{
        //    this.hp = hp;
        //    Console.WriteLine("Player hp 생성자 호출");
        //}

        public void Move()
        {
            Console.WriteLine("Player Move");
        }
        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }

    class Mage : Player
    {

    }
    class Archer  : Player
    {

    }

    class Knight : Player
    {
        //public Knight() : base(100)
        //{
        //    Console.WriteLine("Knight 생성자 호출");
        //}

        //static public void Test()
        //{
        //    counter++;
        //}

        //static public Knight CreateKnight()
        //{
        //    Knight knight = new Knight();
        //    knight.hp = 100;
        //    knight.attack = 1;
        //    return knight;
        //}

        //DeepCopy
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
        }
    }
}
