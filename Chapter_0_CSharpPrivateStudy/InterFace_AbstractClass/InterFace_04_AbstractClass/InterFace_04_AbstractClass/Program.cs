using System;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void privateMethodA()
        {
            Console.WriteLine("AbstractBase.privateMethodA");
        }
        
        public void publicMehtodA()
        {
            Console.WriteLine("AbstractBase.PublicMehtodA");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        { 
            Console.WriteLine("Derived.AbstractMethodA");
            privateMethodA();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.publicMehtodA();
        }
    }
}
