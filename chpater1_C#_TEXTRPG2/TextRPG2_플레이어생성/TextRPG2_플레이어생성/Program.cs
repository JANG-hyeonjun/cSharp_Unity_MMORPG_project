using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while(true)
            {
                game.Process();
            }

            //    //이름 공간이 같다는 전제하에 같은 파일에 있는 것 처럼 사용 가능
            //    Player player = new Knight();
            //    Player player2 = new Archer();
            //    Monster monster = new Orc();
            //    //게임 stage 나 로비를 관리해주는 객체가 있으면 좋지않을까 
            //    int damage = player.GetAttack();
            //    monster.OnDamaged(damage);
            //    //재 사용성이 용이
            //    //player2.OnDamaged(damage);
        }
    }
}
