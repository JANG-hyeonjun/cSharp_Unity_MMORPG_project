using System;

namespace MoreOnArray
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach(int score in scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number Of dimensions : {scores.Rank}");

            Console.WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch<int>(scores, 81));
            Console.WriteLine("Linear Search : 90 is at {0}", Array.IndexOf<int>(scores,90));

            Console.WriteLine("EveryOne Passed ? : {0}",Array.TrueForAll<int>(scores, CheckPassed));

            int index = Array.FindIndex<int>(scores, delegate (int score)
             {
                 if (score < 60)
                     return true;
                 else
                     return false;
             }); //C# 에서는 람다 함수를 익명 함수라고 하는듯

            scores[index] = 61;
            Console.WriteLine("EveryOne Passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));
        
            
        }
    }
}
