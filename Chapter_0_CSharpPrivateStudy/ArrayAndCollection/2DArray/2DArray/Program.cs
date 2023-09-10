using System;

namespace _2DArray
{

    class MainApp
    {
        static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write($"[{i}, {j}] : {arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //For Each를 사용해 다음과 같이 출력하는 방식이 있다. 
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                int[] row = new int[arr2.GetLength(1)];
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    row[j] = arr2[i, j];
                }
                Array.ForEach<int>(row, new Action<int>(Print));
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < arr3.GetLength(0); ++i)
            {
                for (int j = 0; j < arr3.GetLength(1); ++j)
                {
                    Console.Write($"[{i}, {j}] : {arr3[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
