using System;

namespace ClassTypeCast
{
    //OOP (은닉성/상속성/다형성)

    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }
    
    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static Player FindPlayerByID(int id)
        {
            // id에 해당하는 플레이어를 탐색
            
            //못찾았으면
            return null;
        }
        
        static void EnterGame(Player player)
        {
            //첫번째 방법
            //bool isMage = player is Mage;
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}
            //두번째 방법
            Mage mage  = (player as Mage);
            //만약 Player가 Knight type이였다면 null을 반환한다.
            if(mage != null)
            {
                mage.mp = 10;
            }
            
            //null의 개념 -> '없음'내가 참조하는 타입이 아무것도 없다.

            //잊지말자 연구소에서 제일 부족한 사람은 나다. 많이 부족한 난 그 누구보다 노력해야한다.
        }
        
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            //Mage 타입 -> Player 타입
            //Player 타입 -> Mage 타입 ? 확정지을수 없다.
            //왜냐면 Player 가 Player를 참조하고 있는지 다른 직업을 참조 하고 있는지 모르니까
            //Player magePlayer = mage;
            //Mage mage2 = (Mage)magePlayer;
            //이렇게 하는 cast는 유효성 검사를 하지 않고 캐스팅을 진행한다.

            ///EnterGame(knight);
            EnterGame(mage);
        }
    }
}
