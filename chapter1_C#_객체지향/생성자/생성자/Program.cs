using System;

namespace 생성자
{
    // 기본적으로 참조 
    //클래스로 선언되어 있을경우 무조건 참조를 해서 변수를 넘기게 됨 
    class Knight
    {
        public int hp;
        public int attack;


        //Constructor
        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }
        
        //먼저 내자신의 빈생성자를 호출 시켜달라 -> this()
        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int  생성자 호출!");
        }

        //이런것도 가능 this(hp)
        public Knight(int hp,int attack)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출!");
        }

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

    

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(50,55);
           
       
        }
    }
}
