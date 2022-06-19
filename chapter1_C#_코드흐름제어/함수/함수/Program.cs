using System;

namespace 함수
{
    class Program
    {
        //메소드 함수
        //한정자 반환형 이름 (매개변수 목록)
        //{
        //}

        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }



        //덧셈 함수
        static int Add(int a,int b)
        {
            return a + b;
        }

        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static void Main(string[] args)
        {
            int a_ = 0;
            int a = 4;
            int b = 5;
            
            Program.AddOne(ref a_);
            //참조값을 넘긴다. c++ &와 같다고 생각하면 된다.
            
            Program.HelloWorld(); //은 HelloWorld();
            
            int result = Program.Add(4, 5);
            
            Console.WriteLine(a_);
            Console.WriteLine(result);

        }
    }
}
