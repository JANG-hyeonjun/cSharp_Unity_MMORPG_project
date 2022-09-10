using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }
        
        class Monster
        {
            //hp 입니다 중요한 정보 입니다. 라고하면 컴퓨터는 전혀 알지 못하고 
            //그냥 컴파일 할때 지나친다 그런데 우리가 Attribute라는 것을 이용하면
            //표시해줄수 있다. -> 즉 컴퓨터가 런타임중에 체크할수 있는 주석
            [Important("Very Important")]
            public int hp;
            
            protected int attack;
            private float speed;

            void Attack() { }
        }
        
        static void Main(string[] args)
        {
            //리플랙션은 일상 코딩에서 많이 사용하는것은 아니지만
            // 개념적으로 유용하다.
            // X-Ray를 찍는것이다. 위에 있는 Monster Class를 Reflection을 사용하면
            // 런타임 도중에 다 뜯어보고 분석해 볼 수 있다. 

            Monster monster = new Monster();
            Type Type = monster.GetType();

            var fields = Type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                string access = "protected";

                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();


                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }


        }
    }
}
