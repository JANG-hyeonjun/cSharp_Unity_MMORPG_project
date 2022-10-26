using System;
using System.Collections.Generic;

namespace Exercise
{
    //트리 자료형의 경우 안에 데이터가 빠르게 변하고
    //삽입 삭제가 많이 일어남 -> 정적으로 만들수는 없다,
    class TreeNode<T>
    { 
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();

    }

    class PriorityQueue<T> where T : IComparable<T>
    {
        List<T> _heap = new List<T>();

        //O(logN)
        public void Push(T data)
        {
            //힙의 맨끝에 새로운 데이터를 삽입한다.
            _heap.Add(data);

            int now = _heap.Count - 1;
            //도장 깨기를 시작

            while(now > 0) //root가 된다면
            {
                //도장깨기를 시도
                int next = (now - 1) / 2; //부모 인덱스
                if (_heap[now].CompareTo(_heap[next]) < 0)
                    break;

                //두 값을 교제한다.
                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;

                //검사 위치를 이동한다.
                now = next;
            }
        }
        //O(logN)
        public T Pop()
        {
            //반환할 데이터를 따로 저장
            T ret = _heap[0];

            //마지막 데이터를 root로 이동
            int lastIndex = _heap.Count - 1;
            _heap[0] = _heap[lastIndex];
            //마지막꺼 삭제
            _heap.RemoveAt(lastIndex);
            lastIndex--;

            //역으로 내려가는 도장깨기 시작
            int now = 0;
            while(true)
            {
                int left = 2 * now + 1;
                int right = 2 * now + 2;

                int next = now;
                //왼쪽값이 현재값 보다 크면, 왼쪽으로 이동
                if (left <= lastIndex && _heap[next].CompareTo(_heap[left]) < 0)
                    next = left;
                //오른 값이 현재값(왼쪽 이동 포함)보다 크면, 오른쪽으로 이동
                if (right <= lastIndex && _heap[next].CompareTo(_heap[right]) < 0)
                    next = right;

                //왼쪽 /오른쪽 모두 현재값보다 작으면 종료
                if (next == now)
                    break;

                //두값을 교체한다.
                T temp = _heap[now];
                _heap[now] = _heap[next];
                _heap[next] = temp;
                //검사위치를 이동한다.
                now = next;
            }
            return ret;
        }
        public int Count()
        {
            return _heap.Count;
        }
}

    class Knight : IComparable<Knight>
    {
        public int Id { get; set; }

        public int CompareTo(Knight other)
        {
            if (Id == other.Id)
                return 0;
            return Id > other.Id ? 1 : -1;
            //당연히 이로직을 반대로하면 반대로 정렬된 결과가 출력
        }
    }

    class Program
    {
        #region Tree관련 코드
        static void PrintTree(TreeNode<string> root)
        {
            //접근을 해서 출력
            Console.WriteLine(root.Data);

            foreach (TreeNode<string> child in root.Children)
                PrintTree(child);
        }

        static int GetHeight(TreeNode<string> root)
        {
            int height = 0;

            foreach(TreeNode<string> child in root.Children)
            {
                int newHeight = GetHeight(child) + 1;
                //if(height < newHeight)
                //{
                //    height = newHeight;
                //}
                //이런 문법도 많이 쓴다.
                height = Math.Max(height, newHeight);
            }


            return height;
        }

        static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "R1 개발실" };
            {
                TreeNode<string> node = new TreeNode<string>() { Data = "디자인팀" };
                //node.Children.Add(new TreeNode<string>() { Data = "전투" });
                //node.Children.Add(new TreeNode<string>() { Data = "경제" });
                //node.Children.Add(new TreeNode<string>() { Data = "스토리" });
                root.Children.Add(node);
            }
            {
                TreeNode<string> node = new TreeNode<string>() { Data = "프로그래밍팀" };
                node.Children.Add(new TreeNode<string>() { Data = "서버" });
                node.Children.Add(new TreeNode<string>() { Data = "클라" });
                node.Children.Add(new TreeNode<string>() { Data = "엔진" });
                root.Children.Add(node);
            }
            {
                TreeNode<string> node = new TreeNode<string>() { Data = "아트팀" };
                //node.Children.Add(new TreeNode<string>() { Data = "배경" });
                //node.Children.Add(new TreeNode<string>() { Data = "캐릭터" });
                root.Children.Add(node);
            }
            return root;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Tree코드
            //TreeNode <string> root = MakeTree(); 
            //PrintTree(root);            
            //Console.WriteLine(GetHeight(root));
            #endregion

            #region priority Queue
            PriorityQueue<Knight> q = new PriorityQueue<Knight>();
            q.Push(new Knight() { Id = 20 });
            q.Push(new Knight() { Id = 10 });
            q.Push(new Knight() { Id = 30 });
            q.Push(new Knight() { Id = 90 });
            q.Push(new Knight() { Id = 40 });

            while(q.Count() > 0)
            {
                Console.WriteLine(q.Pop().Id);            
            }
            #endregion
        }
    }
}
