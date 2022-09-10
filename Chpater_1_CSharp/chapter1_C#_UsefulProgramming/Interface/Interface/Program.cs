using System;

namespace Interface
{
    class Program
    {
        abstract class Monster
        {
            public abstract void Shout();
        }
        interface IFlyable //나의 기능을 가지고 있는 얘라면 반드시 Fly라는 인터페이스 함수를 제공해야해
        {
            void Fly(); //이런 모양이다 이런 설계다
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");   
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("펄럭펄럭");
            }
        }
        //C#은 다중상속이 안되는데 이는 죽음의 다이아몬드 구조문제
        //예륻들어 Orc 와 Skelton class를 상속받는 어떠한 경우가 있었다 하면
        //base의 shout()을 호출하면 어떠한 클래스의 멤버함수가 호출되는지 알수가 없다.
        //그래서 막아놓음 그래서 인터페이스는 물려주지만 구현부는 너가 알아서 해 하는 문법이 있으면 된다.

        //그래서 CSharp은 interface 키워드를 제공 인터페이스는 여러개를 받아도 상관 없다.

        class Skleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("꾸에에엑!");
            }
        }
        //근데 지금 이상태는 shout을 선언을 해줘도 되고 안해도 되는것이다.
        //그래서 스켈레톤을 구현을 안하면 Monster class의 shout이 구현이 될것이다.

        static void DoFly(IFlyable flyable)
        {
            //왜 받는 매개변수를 IFlyable로 했는지를 생각해보면 범용적으로 static을 사용해야 하니까
            //또 하나 발견한 사실은 C++은 업캐스팅 되어 있는것을 다운 캐스팅을 해서 그 함수를 사용할 수 있지만
            //인터페이스는 왼쪽의 자료형을 따르는것이 아닌거 같다. (애초에 인터페이스 생성자를 통해 인스턴스를 할당 할수도 없다)
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            //추상 클래스와 인터페이스
            //Monster monster = new Monster();
            FlyableOrc orc = new FlyableOrc();
            Orc orc2 = new FlyableOrc();
            //orc2.Fly();
            DoFly(orc);
        }
    }
}
