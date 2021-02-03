using System;

namespace PerABstract
{
    abstract class Marks
    {
        public int M1, M2, M3, M4;
        public abstract void getPercentage();
    }
    class A : Marks
    {
        public void GetDetails()
        {
            Console.WriteLine("Enter 1st Mark: ");
            M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st Mark: ");
            M2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3st Mark: ");
            M3 = Convert.ToInt32(Console.ReadLine());

        }
        public override void getPercentage()
        {
            double per = ((M1 + M2 + M3) / 300) * 100;
            Console.WriteLine("Percentage Class A is :" + per);
        }
    }
    class B : Marks
    {
        public void GetDetails()
        {
            Console.WriteLine("Enter 1st Mark: ");
            M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2st Mark: ");
            M2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3st Mark: ");
            M3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4st Mark: ");
            M4 = Convert.ToInt32(Console.ReadLine());
        }
        public override void getPercentage()
        {
            double per = ((M1 + M2 + M3+M4) / 400) * 100;
            Console.WriteLine("Percentage Class B is :" + per);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A();
            a.GetDetails();
            b.GetDetails();
            a.getPercentage();
            b.getPercentage();
        }
    }
}
