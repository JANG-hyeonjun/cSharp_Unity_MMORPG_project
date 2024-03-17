using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        static int number = 0;

        static void Thread_1()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // all or nothing 시작 되거나 안되거나
                int afterValue = Interlocked.Increment(ref number); //이렇게 하면 성능에서 어마어마한 손해를 본다.
                //아무래도 원자성을 가진 연산에 의해 진행된 값을 받게 해야 하지 않을까 해서 설계를 
                //이렇게 한거 같다. 또 참조자를 하지 않으면 number를 복사해서 증가시키기 때문에
                //값의 동기화가 맞이 않아서 이렇게 한게 아닐까
                
                //number++;
            }
        }

        static void Thread_2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref number);
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
