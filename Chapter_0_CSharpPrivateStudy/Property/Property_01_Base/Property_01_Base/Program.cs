using System;

namespace Property
{
    class BirthDayInfo
    {
        private string name;
        private DateTime birthDay;

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
        
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthDay).Ticks).Year; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BirthDayInfo birth = new BirthDayInfo();
            birth.Name = "서현";
            birth.BirthDay = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"BirthDay : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
