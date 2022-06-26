using System;

namespace ref_out
{
   class Program
    {
        static void Divide(int a,int b, out int result1,out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }
        //ref 와 달리 out으로 키워드를 명명하면 반드시 값을 넣어 주어야함 
        //중요한점은 out 도 결국 ref라는것을 기억해야한다.
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        static void AddOne(ref int number)
        {
            number = number + 1;
        }

        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Main(string[] args)
        {
            ////다만 이제 이걸진짜 실질적으로 적용해야하는 상황이 올수 있다. -> ex Swap(call by ref)
            //int a = 0;
            //Program.AddOne(ref a);
            //Console.WriteLine(a); 

            ////만약 테스트성으로 결과를 보고 싶었다면 이렇게 코딩을 하는것이 좋다
            //int b = Program.AddOne2(a);
            //a = b;
            //Console.WriteLine(a);
            int num1 = 10;
            int num2 = 3;

            //Program.Swap(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            int result1;
            int result2;
            Divide(num1, num2, out result1, out result2);
            //그래서 여기도  out
            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }
    }
}
