using System;

namespace CSharp
{
    class Program
    {
        //당연히 우리가 custom한 예외처리도 만들 수 있다.
        class TestException : Exception
        {

        }
        
        //당연히 함수를 통해 던질 수 도 있다.
        static void TestFunc()
        {
            throw new TestException();
        }

        static void Main(string[] args)
        {
            //Exception 예외처리 - 게임에서는 주로 쓰지 않는다.
            //왜 자주 사용되지 않냐면 어차피 유저한명을 자르고 다른 유저를 살리면 되는게 아니라
            //이미 잘못 만들어진 코드에의해 모든 유저는 영향을 받을 것이다.
            //그래서 크래쉬가 나오는것을 잡는것이 더 현실적이다. 
            //근데 진짜 예외 상황 예를들면 네트워크 통신 접속 실패 로그 찍고 다시 할 수 있게
            //이런건 덜 크리티컬 하니까 잡아서 다시 처리할 수 도 있는것 이다.
            try
            {
                //대표적이 예외 상황
                //1. 0 으로 나눌 때
                //2. 잘못된 메모리를 참조 (null)
                //3. 복사를 하는데 오버플로우

                //int a = 10;
                //int b = 0;
                //int result = a / b;

                //try catch 문에서 예외가 발생하면 예외가 난부분이후는 발생되지 않는다.
                //그래서 무조건 실행해야 한다면 finally에다 넣으면 된다.
                //int c = 0;

                TestFunc();

                //throw new TestException();
            }

            //이 Exception Class는 예외처리 계의 제일 조상 class
            //그래서 일반적인게 아니라 해당 타입으로 보내준다.
            catch (DivideByZeroException e)
            {

            }

            catch (Exception e)
            {
                //일단 시도를 해보고 예외적인 일이 발생하면 처리 하겠다라는 의미 

            }
            finally
            {
                //이런건 언제 쓸까 하면 데이터 베이스를 접근하고 사용한 뒤 
                //접속을 했는데 실패했다 하더라고 정리를 위해 사용한다.
                //DB 파일 등등
            }
        }
    }
}
