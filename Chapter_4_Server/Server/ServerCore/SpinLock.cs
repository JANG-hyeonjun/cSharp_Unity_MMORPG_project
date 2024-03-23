using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class SpinLock
    {
        volatile int _locked = 0;

        public void Acquire()
        {
            //while (_locked)
            //{
            //    //잠김이 풀리기를 기다린다.
            //}

            //_locked = true; //잠김이 풀렸고 내가 확보 했다.
            ////이렇게 하면 동작이 구분이 되어진다. 

            while(true)
            {
                //int original = Interlocked.Exchange(ref _locked, 1);
                //if (original == 0) //아무도 없는 상태에서 자원을 확보했다 
                //    break;
                //origianl은 한개의 스레드만 사용하고 있는 스택에만 있는거니까 값을 가지고 와서 써도 된다.
                //{
                //    int origial = _locked;
                //    _locked = 1;
                //    if (original == 0)
                //        break;
                //}
                // 싱글 스레드였으면 문제가 없지만 그걸 두줄로하면 구분이되어지는것이다.


                //CAS Compare-And_Swap
                int expected = 0;
                int desired = 1;
                if(Interlocked.CompareExchange(ref _locked, desired, expected) == expected)
                    break;
                //{
                //    if (_locked == 0)
                //        _locked = 1;
                //}
                //대부분 이렇게 쓰는게 좋다
            }
        }

        public void Release()
        {
            _locked = 0;
        }
    }


    class Program
    {
        static int _num = 0;
        static SpinLock _lock = new SpinLock();

        static void Thread_1()
        {
            for(int i = 0; i < 1000000; i++)
            {
                _lock.Acquire();
                _num++;
                _lock.Release();
            }

        }

        static void Thread_2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _lock.Acquire();
                _num--;
                _lock.Release();
            }
        }

        static void Main(string[] args)
        {
            Task t1 = new Task(Thread_1);
            Task t2 = new Task(Thread_2);

            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);

            Console.WriteLine(_num);
        }
    }
}
