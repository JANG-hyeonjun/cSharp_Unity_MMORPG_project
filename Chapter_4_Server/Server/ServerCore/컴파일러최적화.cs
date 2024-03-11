using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        volatile static bool _stop = false; //휘발성 데이터 언제언제 바뀔지 모르니까 최적화 하지마라
        //그냥 이런애가 있고 최적화에의해 버그는 벌어질수 있다는 걸 기억할 것 

        static void ThreadMain()
        {
            Console.WriteLine("쓰레드 시작!");

            while (_stop == false)
            {
                //누군가가 stop 신호를 해주기를 기다린다.
            }

            //컴파일러는 위코드를 다음과 같이 최적화 한다. 릴리즈 모드에서 그러면 무한히 돌게 된다.
            //if(_stop == false)
            //{
            //    while(true)
            //    {

            //    }
            //}
            

            Console.WriteLine("쓰레드 종료!");
        }


        static void Main(string[] args)
        {
            Task t = new Task(ThreadMain);
            t.Start();

            Thread.Sleep(1000);

            _stop = true;

            Console.WriteLine("_Stop 호출");
            Console.WriteLine("종료 대기중");

            t.Wait();

            Console.WriteLine("종료 성공");
        }
    }
}
