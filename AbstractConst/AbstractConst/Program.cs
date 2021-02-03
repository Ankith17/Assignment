using System;

namespace AbstractConst
{
    public abstract class Abstract{
        public Abstract()
        {
            Console.WriteLine("Abstract Constructor");
        }
        public abstract void abmethod();
        public void nonabmethod()
        {
            Console.WriteLine("Normal Method");
        }
    }
    public class subclass : Abstract
    {
       
        public override void abmethod()
        {
            base.nonabmethod();
            Console.WriteLine("Abstract Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            subclass sb = new subclass();
            sb.abmethod();
        }
    }
}
