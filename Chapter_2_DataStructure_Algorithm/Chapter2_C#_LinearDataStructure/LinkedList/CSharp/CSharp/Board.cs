using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next;
        public MyLinkedListNode<T> Prev;
    }

    class MyLinkedList<T>
    {
        public int Count = 0;
        //총 노드가 몇개
        public MyLinkedListNode<T> Head = null; //첫번쨰
        public MyLinkedListNode<T> Tail = null; //마지막    
        
        //O(1)
        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;
            //만약 방이 아예 없었다면, 새로 추가한 첫번째 방이 곧 Head이다.
            if (Head == null)
                Head = newRoom;

            // 101 102 103 104
            //기존에 [마지막 방] 과 [새로 추가되는 방]을 연결한다.
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            //[새로 추가되는 방]을 [마지막 방]으로 인정한다.
            Tail = newRoom;
            Count++;
            return newRoom;
        }
        
        //삭제를 요청한 방이 무조건 RoomList에 들어간다 가정
        // 101 102 103 104 105
        
        //O(1)
        public void Remove(MyLinkedListNode<T> room)
        {
            //[기존의 첫번째 방의 다음방] 을 [첫번째 방으로] 인정한다.
            if (Head == room)
                Head = Head.Next;

            // [기존의 마지막 방의 이전방 ] 을 [마지막 방으로] 인정한다.
            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    
    }



    class Board
    {
        // 사용할때 어떤식으로든 초기화를 해서 맵정보를 아래함수에서 불러와서 맵을 구성한다.
        // 정보를 1차원 배열이나 2차원 배열로 들고 있을 수도 있다.
        public int[] _data = new int[25];
        public MyLinkedList<int> _data3 = new MyLinkedList<int>();
        //결국 프로그래밍이란 데이터를 어떻게 저장하고 어떻게 불러와서 이를 어떻게 잘 활용할지가 
        // 정말 중요한 분야 

        //연결리스트 구현 연습
        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            //핵심은 링크드 리스트는 인덱스 access가 지원을 하지 않는다.
            //당연히 시간이 오래걸리기 때문 그래서 라이브러리 지원이 없다.

            _data3.Remove(node);

        }
    }
}
