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

    class PriorityQueue
    {
        List<int> _heap = new List<int>();
        public void Push(int data)
        {
            


        }
        public int Pop()
        {
            return 0;
        }
        public int Count()
        {
            return 0;
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
            PriorityQueue q = new PriorityQueue();
            q.Push(20);
            q.Push(10);
            q.Push(30);
            q.Push(90);
            q.Push(40);

            while(q.Count() > 0)
            {
                Console.WriteLine(q.Pop());            
            }
            #endregion
        }
    }
}
