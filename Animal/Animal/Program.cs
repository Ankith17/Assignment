using System;

namespace Animal
{
     abstract class Animals
    {
        public abstract void cats();
        public abstract void dogs();
    }
     class Cats:Animals
    {
        public override void cats()
        {
            Console.WriteLine("cats Meow");
        }
        public override void dogs() { }
    }
     class Dogs:Animals
    {
        public override void cats() { }
        override public void dogs()
        {
            Console.WriteLine("Dogs Bark");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cats C = new Cats();
            C.cats();
            Dogs D = new Dogs();
            D.dogs();

        }
    }

}
