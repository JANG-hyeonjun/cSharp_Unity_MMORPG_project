using System;

namespace Static
{
    class Knight
    {
        /*
         Class 안에서 멤버변수 나 멤버함수를 Field(필드) 라고 불린다.
        이러한 필드들은 인스턴트(객체)가 생성 될 때 따로 그것을 객체마다 가지고 있다. 
         그러나 static은 각 인스턴스에 종속되는 것이 아니라 그 class에 종속되게 하는 키워드인 것이다.
         */
        static public int counter = 1; //오로지 한개만 존재 한다.
        //그럼이걸 어디가 쓰느냐 예를 들면 공통적으로 증가하는 숫자를 이렇게 저장 
        //이변수는 모든 인스턴스 들이 공유 
        public int id;
        public int hp;
        public int attack;

        static public void Test()
        {
            //그렇다면 이런 질문을 할수가 있다. static함수는 왜 사용하는 것인가?
            //답은 static함수에는 static변수만 초기화 연산등이 가능 
            counter++;
        }
        //그럼 static 함수는 그렇게 선언했다고 일반 인스턴스에 접근을 못하는것인가?
        //그건 또 아니다.
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        //Constructor
        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
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
            Knight knight = Knight.CreateKnight(); //static
            knight.Move(); //일반 
        }
    }

}
