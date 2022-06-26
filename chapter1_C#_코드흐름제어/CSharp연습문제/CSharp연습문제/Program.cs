using System;

namespace CSharp연습문제
{
    class Program
    {

        static int Factorial(int n)
        {
            //if (n == 1)
            //    return 1;
            //else
            //    return Factorial(n - 1) * n;

            int ret = 1;
            for(int num = 1; num <= n; ++num)
            {
                ret *= num;
            }
            return ret;
        }

        static void Main(string[] args)
        {
            //Problem1
            //for(int i = 2; i <= 9; ++i)
            //{
            //    for(int j = 1; j <= 9; ++j)
            //    {
            //        //Console.WriteLine("{0} X {1} = {2}",i,j,i * j);
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }    
            //}

            //Problem2
            //for(int i = 0; i < 5; ++i)
            //{
            //    for(int j = 0; j <= i; ++j)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Probelm3
            int ret = Factorial(5);
            Console.WriteLine(ret);
       
        }
    }
}
