using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    //연습
    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count = 0; //실제로 사용중인 데이터 개수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 개수

        // O(1) // if(Count >= Capacity)는 무시한다. (이사비용은 무시한다.)
        public void Add(T item)
        {
            //1.공간이 충분히 남아 있는지 확인한다.
            if(Count >= Capacity)
            {
                //공간을 다시 늘려서 확보해야 한다.
                T[] newArray = new T[Count * 2];
                //2라는 숫자는 growth factor;
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;
            }

            //2. 공간에다가 데이터를 넣어준다. (여기 왔다는건 공간은 충분)
            _data[Count] = item;
            Count++;
        }
        //C#에서 이런걸 인덱서 라고 한다.
        //O(1)
        public T this[int index]
        {
            //for situation of int temp = _data2[2]; //index 안에는 2가
            get { return _data[index]; }
            //for situation of _data2[2] = 3; //value안에 3이 들어옴
            set { _data[index] = value; }
        }

        //O(N)
        public void RemoveAt(int index)
        {
            // 101 102 103 104 105
            for(int i = index; i < Count - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _data[Count - 1] = default(T);
            //어떤 자료형이 오든 그 형의 기본 초기값으로 해달라 클래스면 널 인트면 0

            Count--;
        }

    }

    class Board
    {
        // 사용할때 어떤식으로든 초기화를 해서 맵정보를 아래함수에서 불러와서 맵을 구성한다.
        // 정보를 1차원 배열이나 2차원 배열로 들고 있을 수도 있다.
        public int[] _data = new int[25];
        public MyList<int> _data2 = new MyList<int>();
        public LinkedList<int> _data3 = new LinkedList<int>();
        //결국 프로그래밍이란 데이터를 어떻게 저장하고 어떻게 불러와서 이를 어떻게 잘 활용할지가 
        // 정말 중요한 분야 

        //동적배열 구현 연습

        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);

        }
    }
}
