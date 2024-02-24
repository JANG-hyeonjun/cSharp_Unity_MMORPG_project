using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        static void MainThread(object state)
        {
           
          for (int i = 0; i < 5; i++) 
                Console.WriteLine("Hello Thread!");
        }
        
        
        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(1, 1);
            ThreadPool.SetMaxThreads(5, 5);

            for (int i = 0; i < 5; i++)
            {
                Task t = new Task(() => { while (true) { } }, TaskCreationOptions.LongRunning); //직원이할 일감 단위를 지정
                t.Start();
                //Thread pool에 들어가기는 하나 굉장히 오래걸린다는걸 알려줘 별도 처리를 진행 한다.
                // -> 그렇다면 LongRunning 옵션을 제외하면 Thread Pool과 똑같이 동작한다는 점 
            }

            //for (int i = 0; i < 4; i++)
               // ThreadPool.QueueUserWorkItem((obj) => { while (true) { } });

            ThreadPool.QueueUserWorkItem(MainThread);

            //for(int i = 0; i < 1000; i++)
            //{
            //    Thread t = new Thread(MainThread); //굉장히 큰 작업이다.
            //    //t.Name = "Test Thread";
            //    t.IsBackground = true;
            //    t.Start();
            //}
            

            //Console.WriteLine("Waiting for Thread!");
            //t.Join(); //끝날때 까지 여기서 기다린다.
            //Console.WriteLine("Hello World!");

            while (true)
            {

            }
        
        }
    }
}
