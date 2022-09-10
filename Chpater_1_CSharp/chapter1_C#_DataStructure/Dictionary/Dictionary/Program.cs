using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        class Monster
        {
            public int id;

            public Monster(int id) { this.id = id; }
        
        }
       
        static void Main(string[] args)
        {
            //List의 단점 
            //ID 식별자
            // 10 공격명령 103 몬스터 ID 이러한 클라이언트 요청에 의해 서버가 이를 받아
            // 공격처리 우리가 몬스터의 리스트를 가지고 있다고 하면 리스트를 돌면서 ID가 103번?

            //key -> Value
            //Dictionary

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            
            for(int i = 0; i < 10000; ++i)
            {
                dic.Add(i, new Monster(i));
            }

            //id 5000에 해당하는 몬스터를 가져와 // 근데 딕녀서니에 키가 없으면 프로그램 크래쉬가 발생
            Monster mon;
            bool found = dic.TryGetValue(5000, out mon);

            dic.Remove(7777);
            dic.Clear();
        
            //dic은 해쉬테이블 기법을 사용 -> 박스에서 공을 찾는 문제
            //공이 [..............] 1만개 

            //박스를 여러개로 쪼개 놓는다. [1~10] [11~20] [] [] [] [] [] []  1천개
            //777번 공? -> 메모리를 많이 내어주고 성능을 챙기 겠다. 

        }
    }
}
