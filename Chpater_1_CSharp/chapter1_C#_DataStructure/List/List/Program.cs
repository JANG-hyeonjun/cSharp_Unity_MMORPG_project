using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 리스트는 동적배열이다 -> 어떠한 칸의 개수가 미리 할당이 되어있고
            //그것의 자리수를 더늘려 할당한다고 하면 기존에 있는것을 복사하고 현재 그 변수에 연결

            //<자료형> -> c++ template 와 비슷 c#에선 제네릭 이라고 한다.
            List<int> list = new List<int>();
            for(int i = 0; i < 5; ++i)
            {
                list.Add(i);
            }

            for(int i = 0; i < list.Count; ++i)
            {
                Console.WriteLine(list[i]);
            }
            
            foreach(int num in list)
            {
                Console.WriteLine(num);
            }

            //list의 삽입 삭제 -> add는 맨 뒤에서만 집어 넣음
            //list.Insert(2, 999);
            //list.RemoveAt(0);
            //bool success = list.Remove(3); // first Occurance 같은 값이 많으면 처음으로 있는 값만 제거
            // 전체 삭제
            //list.Clear();

            //list는 어떠한 값을 중간에 넣을때는 시간복잡도 적으로 좋지 않다
            //1. 나머지들의 위치를 순차적으로 한번씩 뒤로 옮기고
            //2. 그런뒤에 생긴 자리에 넣는다.
        }
    }
}
