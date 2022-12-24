using System;

namespace AutoImplementatedProperty
{   
    class BirthDatyInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime BirthDay { get; set; } = new DateTime(1, 1, 1);
        //자동 구현 프로퍼티를 사용하면 필드를 선언할 필요가 없다.
        //또한 위와 같이 자동구현 프로퍼티 선언과 동시에 초기화를 수행 할수가 있다.
        
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(BirthDay).Ticks).Year; }
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            BirthDatyInfo birth = new BirthDatyInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirthDay : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");

            birth.Name = "서현";
            birth.BirthDay = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirthDay : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");
        }
    }
}
