using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while(count < 5)
            {
                Console.WriteLine("Hello world");
                count++;
            }
        
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello world2");
            }
        
        
        }
    }
}
