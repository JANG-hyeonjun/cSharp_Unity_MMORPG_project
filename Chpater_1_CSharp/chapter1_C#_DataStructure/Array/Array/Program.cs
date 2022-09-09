using System;

namespace Array
{
    class Player
    {
    
    }

    class Monster
    {

    }

    class Program
    {
        //Player player;
        //Monster monster;

        //근데 MMorpg에서 몬스터를 필드에 셀수 없는 만큼 두는데 변수를 그만큼 설정하면 답이 없다
        static void Main(string[] args)
        {
            //자료에 대한 구조 데이터를 어떤식으로 저장해서 어떤식으로 꺼낼것인가
            // 알고리즘 과 단짝을 이룰수 밖에 없다

            //배열 {}에 미리할당하면 개수를 초기화 필요할 필요 없다
            int[] scores = new int[5] {10,20,30,40,50};
            //동적할당이라 참조 타입
            int[] score2 = scores;
            scores[0] = 9999;

            //혹은 반복문을 돌리면서 채워도 된다.
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            //배열의 인덱스를 사용하면서 쓰기 용이
            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
            //값만 빠르게 뽑아쓸때 용이 인덱스검출도 가능
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }

        }
    }
}
