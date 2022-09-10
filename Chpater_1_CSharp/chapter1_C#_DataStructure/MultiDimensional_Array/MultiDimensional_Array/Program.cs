using System;

namespace MultiDimensional_Array
{
    class Program
    {
        class Map
        {
            int[,] tiles =
            {
                {1,1,1,1,1 },
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,0,0,0,1},
                {1,1,1,1,1}
            };
            public void Render()
            {
                var defaultColor = Console.ForegroundColor;
                for(int y = 0; y < tiles.GetLength(1); ++y)
                {
                    for(int x = 0; x < tiles.GetLength(0); ++x)
                    {
                        if (tiles[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = defaultColor;
            }
        }
        
        static void Main(string[] args)
        {
            ////배열
            //int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            ////어떠한 2차원적인 공간을 표시해야할 상황이 생길수가 있다.
            ////그것은 보이는 화면이 2차원 적인 것을 컨트롤 하면 편리하다는 말과 동일

            //int[,] arr = new int[2,3] {{1,2,3}, {1,2,3}};

            ////문법은 이런식으로 사용
            //arr[0, 0] = 1;
            //arr[1, 0] = 1;

            //Map map = new Map();
            //map.Render();

            int[,] map = new int[2, 3];
            //그런데  
            //[...]
            //[.........] 같은 형태를 원할수도 있다,
            //[.....]
            
            //그러면 아래와 같이
            int[][] a = new int[3][];
            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[2];

            a[0][0] = 1;
        }
    }
}
