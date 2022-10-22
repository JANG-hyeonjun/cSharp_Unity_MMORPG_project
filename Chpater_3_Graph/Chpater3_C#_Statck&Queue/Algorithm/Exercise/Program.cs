using System;
using System.Collections.Generic;

namespace Exercise
{
    class Graph
    {
        //행렬 버전
        int[,] adj = new int[6, 6]
        {
            {0, 1, 0, 1, 0, 0 },
            {1, 0, 1, 1, 0, 0 },
            {0, 1, 0, 0, 0, 0 },
            {1, 1, 0, 0, 1, 0 },
            {0, 0, 0, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0 }
         };

        //리스트 버전
        List<int>[] adj2 = new List<int>[]
        {
            new List<int>() { 1, 3 },
            new List<int>() { 0, 2, 3 },
            new List<int>() { 1 },
            new List<int>() { 0, 1, 4},
            new List<int>() { 3, 5},
            new List<int>() { 4 },
        };


    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Stack_Queue
            // [1] [2] [3] [4] 

            //스택: LIFO(후입 선출 Last in First Out)
            // 큐 : FIFO(선입 선출 First in First Out)

            //중요한 점은 Stack 과 Queue는 마지막 이나 처음 자료구조를 건드리는 것이지
            //가운데 있는 자료를 건드리는 것이 아니다. 
            Stack<int> stack = new Stack<int>();
            //Csharp Stack의 경우 Push Pop Peek을 많이 사용 한다.
            //stack.Push(101);
            //stack.Push(102);
            //stack.Push(103);
            //stack.Push(104);
            //stack.Push(105);

            if(stack.Count > 0)
            {
                int data = stack.Pop();
                int data2 = stack.Peek();
            }
            //stack의 같은 경우에 안에 아무것도 없을 때 팝 또는 픽을 하게 되면
            //프로그램 크래쉬가 생긴다. 따라서 그것을 처리해주는 로직이 필요

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(101);
            queue.Enqueue(102);
            queue.Enqueue(103);
            queue.Enqueue(104);
            queue.Enqueue(105);

            int data3 = queue.Dequeue();
            int data4 = queue.Peek();

            //근데 이자료구조를 통해 이런궁금중이 생길 수 있다.
            //이거 Stack Queue 기능 다 되는데 위에 선형 자료구조는 굳이 왜 만듯것인가?
            //자료구조를 정함에 있어 굳이 연결리스트를 선입선출로 짜겠다 하는것 보다.
            //그냥 큐를 쓰는 것이 더 낫기 때문이다.
            // *실제 stack  Queue는 순환버퍼로 만들어짐
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(101);
            list.AddLast(102);
            list.AddLast(103);

            //FIFO
            int value1 = list.First.Value;
            list.RemoveFirst();

            //Lifo
            int value2 = list.Last.Value;
            list.RemoveLast();

            //그럼 Stack 과 Queue는 게임을 만들때 쓰는가? 
            //Stack: pop up UI
            //Queue: network Packet을 순차적으로 받을 떼
            #endregion

            #region Graph
            //우리가 생각하는 리스트는 순차적으로 돌면 순회가 가능
            //하지만 그래프는 비선형 구조이기 탐색 기법이 매우 다양하다.
            //DFS (Depth First Search 깊이 우선 탐색)
            //BFS (Breadth First Search 너비 우선 탐색)



            #endregion

        }
    }
}
