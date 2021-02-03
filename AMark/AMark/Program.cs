using System;

namespace AMark
{
    public class Student
    {

        public string IsEligible(int physScore, int chemScore, int mathScore)
        {
            int sumpm = physScore + mathScore;
            int sum = physScore + chemScore + mathScore;
            if (physScore >= 55 && chemScore >= 50 && mathScore >= 65)
            {
                return "The candidate is eligible for admission.";
            }
            else if (sum >= 180)
            {
                return "The candidate is eligible for admission.";
            }
            else if (sumpm >= 140)
            {
                return "The candidate is eligible for admission.";
            }
            else
            {
                return "The candidate is not eligible for admission.";
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the marks obtained in Physics :");
            int physScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry :");
            int chemScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Maths :");
            int mathScore = Convert.ToInt32(Console.ReadLine());
            Student S = new Student();
            string res = S.IsEligible(physScore, chemScore, mathScore);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
