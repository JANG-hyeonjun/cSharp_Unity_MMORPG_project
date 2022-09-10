using System;

namespace Property
{
    class Program
    {
        // 객체지향 -> 은닉성 : 불필요한 정보를 외부로 노출하지 않겠다.
        //이걸하지 않으면 아래와 같이 된다.
        class Knight
        {
            //public int hp;
            //protected int hp;

            public int Hp { get; set; } = 100;
            ////더나아가 자동구현 프로퍼티 라는것이 있다 이걸 하면

            //아래 과정이 유사하게 완성 된것 이 일을 컴파일러가 해준다.
            //protected int hp;
            //public void SetHp(int hp) { this.hp = hp; }
            //public int GetHp(int hp) { return hp; }

            //물론 이런식으로 해도됨
            //get { return hp; }
            //private set { hp = value;}

            //추가적으로 get은 외부적으로 접근할수 있는것을 허용하지만
            //set은 내부적으로 돌아가게 하고 싶다.




            void Test()
            {
                Hp = 100;
            }

            //public void SetHp(int hp) { this.hp = hp; }
            //public int GetHp(int hp) { return hp; }
            //이렇게 은닉을 해놓으면 얘가 무적이 아닌 상태일때만 Hp에 대해 접근할수 있다.
        }


        static void Main(string[] args)
        {
            //프로퍼티
            Knight knight = new Knight();
            //knight.SetHp(100);

            //프로퍼티를 선언하면
            //knight.Hp = 100;
            int hp = knight.Hp;
            //사용할때는 마치 멤버변수에 접근하듯이 즉 사용성이 올라갔고 내부적으로는 은닉성으로 
            //구현 되어짐
            Console.WriteLine(hp);
            //knight.hp = 40;
            //큰 규모의 프로젝트 에서는 이런일이 벌어지면 안된다.




        }
    }
}
