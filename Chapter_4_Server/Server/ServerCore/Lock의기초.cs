using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        static int number = 0;
        static object _obj = new object();

        static void Thread_1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // 상호 배제 Mutual Exclusive
                
                // 3. 아래의 코드를 가지고 있다고 보면 된다. _obj가 좌물쇠 개념이 되며 열려 있으면 닫는다.
                lock (_obj) 
                {
                    number++;
                }
                
                // 2. 두번째 방법 데드락 해결 법
                //try
                //{
                //    Monitor.Enter(_obj);
                //    number++;
                //    return;
                //}
                //finally //이렇게 하는것도 여간 귀찮은게 아니다. 그래서 위와 같은 방법을 사용
                //{
                //    Monitor.Exit(_obj);
                //}


                // 1.
                //Critical Section c++경우 std::mutex
                //Monitor.Enter(_obj);  //이 순간 원자성이 보장되는 듯
                //여기서 부터 다른 스레드는 접근 할 수 없다. //싱글스레드로 가정하고 작업 하면 된다.
                //{
                //    number++;
                //    //return; //이렇게 되면 풀어주지 않고 실행 -> 정상적인 동작을 하지 못하게 된다.
                //    //이렇게 된 현상을 데드락 이라고 함
                //    // 이런 상황이 아니라 익셉션 처리가 벌어졌다면 exit를 챙길수 없다. 그래서 위와같이 Try Catch로 하면 되지만 
                //}
                //Monitor.Exit(_obj);
            }
        }

        static void Thread_2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (_obj) // 아래의 코드를 가지고 있다고 보면 된다. _obj가 좌물쇠 개념이 되며 열려 있으면 닫는다.
                {
                    number--;
                }
            }
        }

        static void Main(string[] args)
        {
            Task t1 = new Task(Thread_1);
            Task t2 = new Task(Thread_2);
            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);
            Console.WriteLine(number);
        
        }
    }
}
