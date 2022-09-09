using System;

namespace 데이터_연산
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int level = 50;

            // + - * / %
            //hp = (1 + 2) * 100 ;
            Console.WriteLine(hp++);

            // < <= > >= == !=
            //bool b = hp < 100;
            //이건 언제쓰냐 예를들어 
            bool isAlive = hp > 0;
            bool isHighLevel = (level >= 40);

            //살아있는 고랩 유저?
            bool a = isAlive && isHighLevel;

            //살아 있거나 고렙 유저 이거나 , 둘중 하나인가요?
            bool b = isAlive || isHighLevel;

            //죽은 유저인가요?
            bool c = !isAlive;

            
            //if(isAlive)
            //{
            //    //살았다.
            //}
            //else
            //{
            //    //죽었다. 이런식으로 
            //}



        }
    }
}
