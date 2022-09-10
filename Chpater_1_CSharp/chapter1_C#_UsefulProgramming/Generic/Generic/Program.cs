using System;

namespace Generic
{
    class Program
    {
        //우리만의 자료구조 근데이게 정수로 쓸지 실수로 쓸지 문자열로 쓸지 정해야한다
        //class MyintList
        //{
        //    int[] arr = new int[10];
        //    object objArr = new object[10]
        //}

        //class MyShortList
        //{
        //    short[] arr = new short[10];
        //}

        //class MyfloatList
        //{
        //    float[] arr = new float[10];
        //}

        //또한 C#에는 있지만 C++에는 없는 문법이 있다.
        // class MyList<T> where T : struct
        //이는 T가 어떠한 형식에는 상관없지만 값 형식이어야 한다. 
        //where T : class
        //참조형식이어야 한다.
        // where T : new()
        //반드시 어떠한 인자를 받지 않는 기본 생성자가 있어야한다
        // where T : Monster

        class MyList<T>  
        {
            T[] arr = new T[10];
        
            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class Monster
        {

        }

        static void Test<T>(T input)
        {

        }

        static void Main(string[] args)
        {
            //이렇게하면 불편하다. 그래서 C#은 어떤 타입이든 소화할수 있는 object를 제공한다
            object obj = 3;
            object obj2 = "hello world";

            int num = (int)obj;
            string str = (string)obj2;

            //그러면 obj랑 var이 똑같은거 아니냐 할수 있는데 
            //var은 뒤에 있는 자료를 보고 컴파일러가 판단 그래서 알아서 변환 
            //object는 타입이 진짜 object 그런 자료형이라는 것이다.

            //그러면 모든 자료형을 선언할 필요 없이 obj를 쓰면 되는것 아니냐 할 수 있는데
            //object는 힙에 저장이 되어지는 참조형 -> 따라서 힙에서 스택에 가지고 오고 캐스팅연산을
            //해야 비로소 우리가 그냥 쓰는것과 동일한 단계까지 온것이다. 결론적으로 시간이 걸리게 된다.

            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);
            
            MyList<short> mySHortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();

            //Test<float>(3.0f);
        }
    }
}
