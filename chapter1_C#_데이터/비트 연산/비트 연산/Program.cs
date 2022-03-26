using System;

namespace 비트_연산
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;

            // << >> &(and) |(or) ^(xor) ~(not)
            //num = num << 3;
            //3칸을 민것이다.
            num = num >> 1;

            //중요한건 음수가 있는 자료형에서 비트연산자를 사용하면 맨 앞자리의 부호는 유지된채 
            //비트가 밀린다는것이다. 그래서 비트연산자를 사용하는 변수는 왠만하면 unsigned를 넣자

            //그럼 저연산자들은 언제 쓰냐4

            //예를들어 Npc type 이 3이다. 그러면 비트연산으로 앞으로 미는것이다. 
            //그런식으로 id를 만든다. 

            //Xor은 암호화에 사용된다.
            int id = 123;
            //이 123을 네트워크 환경에 흘려 보낸다고 하자 구조는 아마
            //server Autority 겠지 그런데 이러면 해커들이 아이디를 파악하기 쉬워진다.
            //어떻게든 숨겨 보낸다. 

            int key = 401;

            int a = id ^ key;
            //그러면 key를 이용해 숨긴다.
            int b = a ^ key;
            //서버는 다시한번 xor연산을 한다. 그럼 해커는 키를 잡지 못하면 그 아이디의 진짜 숫자를 모르는것이다.

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
