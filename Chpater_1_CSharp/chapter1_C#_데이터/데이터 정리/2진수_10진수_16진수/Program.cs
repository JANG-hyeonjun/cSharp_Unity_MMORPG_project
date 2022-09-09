using System;

namespace _2진수_10진수_16진수
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. 바구니 크기가 다른 경우!
            int a = 0x0FFF;
            short b = (short)a;


            //상관없다.
            //short c = 100;
            //int d = c;

            //2. 바구니의 크기는 같긴 한데 부호가 다른 경우
            byte c = 255;
            sbyte sb = (sbyte)c;
            // 0xff = 0b 1111 1111 = -1

            //3.소수 변환 
            float f = 3.1414f;
            double d = f;
            //어느정도 오차를 두고 결과를 비교하는것이 좋다 

            //byte(1바이트 0 ~255), short(2바이트 -3만 ~ 3만), int(4바이트 -21억 ~ 21억 ),long(8바이트)
            //sbyte (1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트 0 ~ 43억 ) , ulong(8바이트)


            //// 1바이트 (참/거짓)
            //bool b;
            //b = true;
            //b = false;
            ////소수
            ////4바이트- 7자리 숫자까지 정밀 
            //float f = 3.14f;
            ////8바이트
            //double d = 3.14;


            ////2 Byte 
            //char c = 'a';

            ////char의 집합
            //string str = "가나다라";
            //Console.WriteLine(str);





            //Console.WriteLine("Hello World!");
        }
    }
}
