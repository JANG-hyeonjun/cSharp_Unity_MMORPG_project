using System;

namespace PracticeProblem
{
    class Program
    {
        static int GetHighestScore(int [] scores)
        {
            int max = scores[0];

            for(int i = 1; i < scores.Length; ++i)
            {
                if(scores[i] > max)
                {
                    max = scores[i];
                }
            }
            return max;
        }
        
        static double GetAverageScroe(int [] scores)
        {
            if (scores.Length == 0)
                return 0;

            int average = 0;
            for(int i =0; i < scores.Length; ++i)
            {
                average += scores[i];
            }

            return Convert.ToDouble((average) / scores.Length);
        }

        static int GetIndexOf(int [] scores,int value)
        {
            for(int idx = 0; idx < scores.Length; ++idx)
            {
                if (scores[idx] == value)
                    return idx;
            }
            return -1;
        }

        static void Sort(int [] scores)
        {
            //직접 구현
            for(int i = 0; i < scores.Length; i++)
            {
                int minIndex = i;
                for(int j = i; j < scores.Length; j++)
                {
                    if(scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Swap
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }

            //있는걸 사용
            //Array.Sort(scores);
        }

        static void Main(string[] args)
        {
            int [] scores = new int[5] {10,30,40,20,50};
            
            int highestScore = GetHighestScore(scores);
            Console.WriteLine(highestScore);
            
            double averageScore = GetAverageScroe(scores);
            Console.WriteLine(averageScore);
            
            int findIdx = GetIndexOf(scores, 15);
            Console.WriteLine(findIdx );

            Console.WriteLine("정렬 후");
            Sort(scores);
            for(int idx = 0; idx < scores.Length; ++idx)
            {
                Console.WriteLine(scores[idx]);
            }
        
        }
    }
}
