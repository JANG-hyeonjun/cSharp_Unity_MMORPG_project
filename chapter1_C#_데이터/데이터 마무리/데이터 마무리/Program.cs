using System;

namespace 데이터_마무리
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;

            int b;
            b = a;

            a = a + 1;
            //a += 1
            a = a - 1;
            //a -= 1
            a = a * 1;
            //a *= 1
            a = a / 1;
            //a /= 1
            a = a % 1;
            //a %= 1
            a = a << 1;
            //a <<= 1
            a = a >> 1;
            //a >>= 1
            a = a & 1;
            //a &= 1
            a = a | 1;
            //a |= 1
            a = a ^ 1;
            //a ^= 1

            int c = (3 + 2) * 3;
            // 1. ++ --
            // 2. * /  %
            // 3. + -
            // 4. << >>
            // 5. > < 
            // 6. == !=
            // 7. &
            // 8. ^
            // 9. |
            //10 .... 

            //그냥 헷갈린다 싶으면 괄호를 쳐라 그래야 보는사람도 이해하기 쉽다.
            var num = 3;
            var num2 = "Hello World";

            //자동으로 자료형을 할당해주지만 C++ Auto 같은 느낌 
            //이런걸 남발하면 안된다. 코드가 길어질때 어지간 하면 자료형을 선언해라 
        }
    }
}
