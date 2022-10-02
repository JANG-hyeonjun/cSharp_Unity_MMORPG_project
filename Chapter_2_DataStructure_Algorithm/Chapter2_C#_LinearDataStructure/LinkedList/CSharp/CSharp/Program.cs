using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int lastTick = 0; //마지막으로 측정한 시간
            while (true)
            {

                #region 프레임 관리
                int currentTick = System.Environment.TickCount;
                //int elapsedTick = currentTick - lastTick;
                //만약에 걍과한 시간이 1/30초보다 작다면 continue
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                #endregion
                //구현을 했는데 보기 싫다면 이렇게 하면 된다.


                lastTick = currentTick;

                //현재시간을 이렇게 가지고 있는다. 엄밀히 말하면 정확한 시간의 느낌이 아니라
                //시스템이 시작한 이후에 경과된 밀리 세컨드를 준다.

                //프레임관리 FPS 60 프레임 Ok 30프레임 이하로 끊긴다.
                //프레임 간단하게 얘기해서 현재 이 루프가 1초에 얼마나 실행 되는가 

                //입력

                //로직

                //렌더링

                //즉 부드럽게 보인다는 것은 아주 짧은 시간내 연산을 마치고 화면에 바로 보여주는 것
                //그래서 프레임 관리를 하기 위해서는 시간을 계속 측정하고 있어야 한다.


                //우리는 이제 이 이맵에 텍스처 벽인지 물인지 불인지 관리를 해야하며 
                //관리하는 클래스가 당연히 필요 하다. 즉 아래 있는것을 클래스화 할필요가 있다.
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
    }
}
