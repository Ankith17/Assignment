using System;

namespace Area
{
    class Square
    {
        public double side;
        
        public void  Area(double side)
        {
            double area = side * side;
            Console.WriteLine("Area of Square:" + area);
        }
    }
    class Triangle
    {
       
        public double Base;
        public double height;
        public  void  Area(double height,double Base)
        {
            double area = height*Base*0.5;
            Console.WriteLine("Area of Triangle:" + area);
        }
    }
    class Rectangle
    {
        
        public double breath;
        public double length;

        public  void Area(double length,double breath)
        {
            double area = length * breath;
            Console.WriteLine("Area of Rectangle:" + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Square s = new Square();
            s.Area(10);
            Triangle Tri = new Triangle();
            Tri.Area(10, 20);
            Rectangle r = new Rectangle();
            r.Area(10, 20);
            
        }
    }
}
