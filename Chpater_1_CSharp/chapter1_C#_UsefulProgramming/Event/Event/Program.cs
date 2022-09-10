using System;

namespace Event
{
    class Program
    {

        static void OnInputTest()
        {
            Console.WriteLine("Input Received");
        }

        static void OnInputTest2()
        {
            Console.WriteLine("Input Received22");
        }

        static void Main(string[] args)
        {
            //OnClicked clicked = new OnClicked(TestDelegate);
            //clicked += TestDelegate2;
            //ButtonPressed(/**/clicked);
            //clicked();
            //하지만 Delegate에도 치명적인 단점이 존재 
            //설계적인 부분에서 볼때 객체를 만들어 놓으면 은닉이 되어 있지 않아서 아무나 아무떄에 호출 가능

            //위에 있는 clicked function이 중요해서 저 ButtonPressed 함수 안에서 만 호출 되어야만 하는 
            //함수 였다면 delegate를 만들고 맘대로 호출하는 함수면 이렇게 구현이 되면 안된다.

            //그래서 Delegate를 한번 래핑 하는 Event라는 문법이 존재
            InputManager inputManager = new InputManager();
            //구독신청 -= -> 취소
            inputManager.InputKey += OnInputTest;
            inputManager.InputKey += OnInputTest2;

            while (true)
            {
                inputManager.Update();
            }

            //Delegate처럼 외부에서 맘대로 사용불가
            //inputManager.InputKey(OnInputTest);
        }
    }
}
