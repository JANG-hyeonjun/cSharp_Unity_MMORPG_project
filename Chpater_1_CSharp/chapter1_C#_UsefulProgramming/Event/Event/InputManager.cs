using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    //또한 이런식으로 원하는 이밴트를 보고 싶을때 아래와 같이 코딩하는 방식을
    //옵저버 패턴이라고 한다.
    
    class InputManager
    {
        //실제로 유니티도 이러한 매니저 클래스가 많다.
        //사용자 키보드나 마우스이벤트가 발생된것을 캐치 해서 그것을 다른 게임 프로그램에게 알려주는 
        //중간 매개 역할을 하는 class

        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            //사용자 입력을 감지를 하는데 만약 사용자가 A라는 키를 눌렀을 떄 이것을 알고싶어하는 모든 사람에게
            //뿌려주는 그런 역할을 만들겠다하면
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                if (InputKey == null)
                    return;
                
                //모두한테 A를 입력했다는 사실을 알려주고 싶다.
                InputKey();
                //이렇게 이벤트가 발생했다고 알려준다(호출한다).
                //그러면 이 이벤트 관심있는 사람들은 관심이 있다면 구독신청
            }

        }
    
    }
}
