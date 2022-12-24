using System;

namespace Quiz
{
    interface IRunnable
    {
        void Run();
    }
    
    interface IFlyable
    {
        void Fly();
    }

    class Plane : IFlyable
    { 
        public void Fly()
        {
            Console.WriteLine("Fly!! Fly!!");
        }
    }

    class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Run!! Run!!");
        }
    }

    class FlyingCar 
    {
        private Car car = new Car();
        private Plane plane = new Plane();

        public void Fly()
        {
            plane.Fly();
        }
        public void Run()
        {
            car.Run();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Run();
            flyingCar.Fly();
        }
    }
}
