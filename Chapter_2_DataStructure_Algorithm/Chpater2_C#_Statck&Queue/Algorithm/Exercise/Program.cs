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
            {1, 1, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 1 },
            {0, 0, 0, 0, 1, 0 }
         };

        //리스트 버전
        List<int>[] adj2 = new List<int>[]
        {
            new List<int>() { 1, 3 },
            new List<int>() { 0, 2, 3 },
            new List<int>() { 1 },
            new List<int>() { 0, 1},
            new List<int>() { 5},
            new List<int>() { 4 },
        };

        private bool[] visited = new bool[6];
        //1) 우선 now부터 방문 하고,
        //2) now와 연결된 정점들을 하나씩 확인해서, [아직 미발변(미방문)] 상태라면 방문한다.
        public void DFS(int now)
        {
            Console.WriteLine(now);
            visited[now] = true; //1) 우선 now부터 방문 하고,

            //행렬 그래프 가정
            for (int next = 0; next < adj.GetLength(0); next++)
            {
                if (adj[now, next] == 0) //연결 되어 있지 않으면 스킵
                    continue;

                if (visited[next] == true) //이미 방문했으면 스킵
                    continue;

                DFS(next);
            }
        }
        
        //인접 리스트 버전
        public void DFS2(int now)
        {
            Console.WriteLine(now);
            visited[now] = true; //1) 우선 now부터 방문 하고,

            foreach(int next in adj2[now])
            {
                if (visited[next] == true) //이미 방문했으면 스킵
                    continue;

                DFS2(next);
            }
        }
        //근데 길이 끊어져 있다면? 모든정점을 돌면서 방문이 되지 않은 정점이 있다면 
        //그 정점을 기준으로 또 DFS를 실행해야 한다. 
        public void SearchAll()
        {
            visited = new bool[6];
            for(int now = 0; now < 6; ++now)
            {
                if (visited[now] == false)
                    DFS(now);
            }
        }
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
            Graph graph = new Graph();
            //graph.DFS2(3);

            graph.SearchAll();

            #endregion

        }
    }
}
