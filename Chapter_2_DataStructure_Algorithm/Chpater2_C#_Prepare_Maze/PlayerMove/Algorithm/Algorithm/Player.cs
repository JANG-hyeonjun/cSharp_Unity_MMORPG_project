using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Player
    {
        public int PosY { get; private set; }
        public int PosX { get; private set; }
        Random _random = new Random();
        Board _board;
        public void Initialize(int posY, int posX, int destY, int destX, Board board)
        {
            PosY = posY;
            PosX = posX;

            _board = board;
        }
        //이렇게하면 초기좌표에 대해서만 외부적으로 정해질수 있으며 
        //그 이외에 set은 class자체 내에서 한다.

        const int MOVE_TICK = 100;//0.1초의 개념
        int _sumTick = 0;
        public void Update(int deltaTick)
        {
            _sumTick += deltaTick;
            if(_sumTick >= MOVE_TICK)
            {
                _sumTick = 0;
                //여기에 0.1초 마다 실행될 로직을 넣어 준다.
                int randValue = _random.Next(0, 4);
                switch (randValue)
                {
                    case 0: //상
                        if (PosY - 1 >= 0 &&_board.Tile[PosY - 1, PosX] == Board.TileType.Empty)
                            PosY = PosY - 1;
                        break;
                    case 1: //하
                        if (PosY + 1 < _board.Size && _board.Tile[PosY + 1, PosX] == Board.TileType.Empty)
                            PosY = PosY + 1;
                        break;
                    case 2: //좌
                        if (PosX - 1 >= 0 && _board.Tile[PosY , PosX - 1] == Board.TileType.Empty)
                            PosX = PosX - 1;
                        break;
                    case 3: //우
                        if (PosY + 1 < _board.Size && _board.Tile[PosY, PosX + 1] == Board.TileType.Empty)
                            PosX = PosX + 1;
                        break;
                }
            }
        }
    }
}
