using System;

namespace Delegate
{
    class Program
    {
        delegate int OnClicked();
        //얘는 함수가 아니고 형식 delgate -> 형식은 형식인데, 함수자체를 인자로 넘겨주는 그런 형식 
        //반환: int 입력: void
        //Onclicked 는 delegate형식의 이름
        
        //유니티는 이런 형식을 우리한테 제공한다. 우리는 그 형식을 보고 함수를 만들어 넘겨준다.
        static void ButtonPressed(OnClicked clickedFunction/*함수 자체를 인자로 넘겨주고*/)
        {
            //필요로 할때 함수를 호출(); -> 여기를 콜백이라고 함
            clickedFunction();
        }

        //게임로직을 만드는 부분은 여기 우리가
        static int TestDelegate()
        {
            Console.WriteLine("HelloDelegate");
            return 0;
        }
        //하나의 함수에서 다향한방식으로 규칙으로 동작을하는 하나의 함수를 만들고자 했을때
        //delegate를 상당히 유용하게 사용하면 된다.
        //Ex) sort를 만들때 어떤 함수를 인자로 넘겨주냐에 따라 내림차순 오름차순 혹은 자체 설계 차순으로 만들어 지게 하고 싶을수 있다.
        static int TestDelegate2()
        {
            Console.WriteLine("HelloDelegate 22");
            return 0;
        }

        static void Main(string[] args)
        {
            //delegate (대리자) - 굉장히 중요한 문법
            //지금 까지 우리의 코딩은 굉장히 순차적이고 직관적이 였다.

            //예를들어 업체 사장 - 사장님의 비서
            //비서에게 사장님이 시간이 없다면 우리의 연락처 거꾸로 연락을 달라고 콜백 요청
            //프로그램도 마찬가지로 이런일이 정말 많다.

            //EX) UI - Game에서 메뉴버튼을 누르면 관련 메뉴가 보이고 공격을 하면 공격처리
            //먼저 제일 간단한 생각으로 
            //static void ButtonPressed()
            //{
                //PlayerAttack();
            //}
            //근데 상황에 따라 이렇게만 구현하기 어렵. 현실적인 벽 설계적인 벽
            //버튼에 따라 모든 함수를 여기다가 넣으면 UI 관련된 로직과 게임로직이 섞임 그래서 분리해서 관리하는것이 좋다.
            //그리고 유니티엔진의 코어한 부분을 수정할수 있는것이 아니다.

            //어떻게 보면 c++에서 함수포인터라고 생각하면 된다.

            //원래는 아래와 같이 사용
            OnClicked clicked = new OnClicked(TestDelegate);
            //clicked();
            //ButtonPressed(/**/clicked);
            //이렇게 Delegate객체를 만들어 놓으면 바로 호출 과 인자로 넘겨줄수가 있다.


            //근데 굳이 왜 이렇게 하나면 Delegate Chainning이란게 가능하기 떄문이다.  
            clicked += TestDelegate2;
            //이렇게하면 연결
            ButtonPressed(/**/clicked);
        }
    }
}
