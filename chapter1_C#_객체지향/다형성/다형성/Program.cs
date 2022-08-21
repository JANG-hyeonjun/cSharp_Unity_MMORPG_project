using System;

namespace 다형성
{
    //OOP (은닉성/상속성/다형성)
    class Player
    {
        protected int hp;
        protected int attack;
  
        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    class Knight : Player
    {
        //위가 만약 public void Move()라면 여기는 public new void Move()
        //또 C#에는 있는데 C++ 에는 없는 public sealed override void Move() 라는 것이 있다.
        /// sealed를 사용하면 현재 이 클래스로 부터 유도 되어진 클래스는 override할 수 없다
        /// 
        public override void Move() 
        {
            base.Move();
            //부모의 기능을 사용하지만 추가적인 로직을 이렇게 추가
            Console.WriteLine("Knight 이동!");
        }
    }

    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            
            
            Console.WriteLine("SuperKnight 이동!");
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            //Mage mage = (player as Mage);
            //if (mage != null)
            //{
            //    mage.mp = 10;
            //    mage.Move();
            //}

            //Knight knight = (player as Knight);
            //if (knight != null)
            //{
            //    knight.Move();
            //}
            //굳이 이렇게 형변환을 계속해야할까? ->효율적이지 않다.
            //이럴 때 다형성(polymorphism)이 필요하다.

            player.Move();

            //오버로딩 -> 함수이름의 재사용
            //오버라이딩 -> 다형성을 이용하는 것 (어떤 함수를 타입에 따라 다양하게 동작하게 하겠다.)
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            //mage.Move();
            
            //EnterGame(knight);
            //EnterGame(mage);
        }
    }
}
