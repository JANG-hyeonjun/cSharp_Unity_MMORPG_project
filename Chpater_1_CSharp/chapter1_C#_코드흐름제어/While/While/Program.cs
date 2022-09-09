using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 5;
            //while(count > 0)
            //{
            //    Console.WriteLine("Hello World");
            //    count--;
            //}

            string answer;

            do
            {
                Console.WriteLine("~~님은 잘생기셨나요? (y/n): ");
                answer = Console.ReadLine();
            } while (answer != "y");


            Console.WriteLine("정답입니다.");
        }
    }
}
