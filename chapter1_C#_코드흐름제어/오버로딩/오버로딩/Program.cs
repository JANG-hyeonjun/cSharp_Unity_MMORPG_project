using System;

namespace 오버로딩
{
    class Program
    {
        
        //오버로딩 -> 함수이름의 재사용
        //오버로딩은 매개변수 형식 개수 함수이름을 본다 반환형식은 영향을 주지 않음
        static int Add(int a,int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }


        static int Add(int a,int b,int c = 0,float d = 1.0f,double e = 3.0)
        {
            return a + b + c;
        }

        static int Add(int a, int b,int c)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        static float Add(float a,float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }

        static void Main(string[] args)
        {
            int ret = Program.Add(2, 3);
            float ret2 = Program.Add(2.0f, 3.0f);

            //c++은 함수를호출할때 값을 다 넣어주어야하지만 c#은 지정해서 대입이 가능
            //Example 
            Program.Add(1, 2, d: 2.0f);
            Console.WriteLine(ret);
        }
    }
}
