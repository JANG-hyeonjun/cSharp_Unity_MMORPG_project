using System;

namespace Nullable
{
    class Program
    {
        class Monster
        { 
            public int Id { get; set; }
        }

        //몬스터 클래스가 있고 id를 통해 몬스터를 찾아주는 함수
        static Monster FindMonster(int id)
        {
            //그러면 
            //for()
            //return monster
            return null;
        }

        static int Find()
        {
            //근데이건 null같이 없다라는 표시가 없다.
            return 0;
            //라고하면 이건 그냥 우리끼리 정한것이고 만약 모든 숫자를 이용해야 한다면?
            //그래서 문법에서 Nullable 타입을 정의하였음
        }

        static void Main(string[] args)
        {
            //Nullable -> Null + able
            //이건 왜 필요한가
            Monster monster = FindMonster(101);
            if(monster != null)
            {

            }
            //그런데 이러한 로직이 가능한 이유는 Monster가 class 즉 참조형으로 이용할 수 있기 때문이다.

            int? number = null;
            //이렇게 물음표를 추가하게 되면 null도 될수 있다는 의미이다.
            //number = 5;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }
            
            if(number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }
            //근데 널체크 매번하면 힘드니까 ??가 나오게됨

            int b = number ?? 0;
            Console.WriteLine(b);
            //이 문법의 의미는 number가 null이 아니면 .Value에 있는 값을 집어 넣어주고
            //null이면 0을 넣어준다.

            //마지막으로
            monster = null;

            //if(monster  != null)
            //{
            //    int monsterId = monster.Id;
            //}

            int? id = monster?.Id;
            //monster라는 변수가 null인지 아닌지 체크해서 널이 아니라면 그떄 아이디의 값을 뽑아와서 넣어주고
            //널이라면 null을 넣어주세요 라는 의미 아래와 동일 하다.

            if(monster == null)
            {
                id = null;
            }
            else
            {
                id = monster.Id;
            }
            //정리 Nullable 형식을 지원한다.
            // 사용하고 싶다면 변수명 뒤에 ?
            //그런데 널이 되어서 널 체크르 해줘야 하니까 
            // ?? 또는 ?. 을이용해서 체크한다.
        }
    }
}
