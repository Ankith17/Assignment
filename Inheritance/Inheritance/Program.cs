using System;

namespace Inheritance
{
    class Member
    {
        public string Name;
        public int Age;
        public string PhoneNo;
        public string Address;
        public double salary;
        public void printSalary()
        {
            Console.WriteLine("Salary: " + salary);
        }
        public void ChkTelephone()
        {
            char[] tele = PhoneNo.ToCharArray();
            if (tele.Length == 10)
            {
                for(int i = 0; i < tele.Length; i++)
                {
                    if (Char.IsDigit(tele[i]))
                    {
                        continue;
                    }
                    

                }
               
            }
            else
            {
                Console.WriteLine("Invalid Phone number");
                System.Environment.Exit(0);
            }
        }
    }
    class Employee:Member
    {
        public string specialization;
        
        public void getDetails()
        {
            Console.WriteLine("Enter  Employee Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter  Employee Age:");
            Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter  Employee Phone No:");
            PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter  Employee Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter  Employee salary:");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Specialization");
            specialization = Console.ReadLine();
            base.ChkTelephone();
        }
        public void DisplayDetails()
        {
            
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Age: " + Age);
            Console.WriteLine("Employee Address: " + Address);
            Console.WriteLine("Employee PhoneNO: " + PhoneNo);
            base.printSalary();
            Console.WriteLine("Employee Specialization: " + specialization);
        }
    }
    class Manger : Member
    {
        
        public string DepartMent;
         
        public void getDetails()
        {
            Console.WriteLine("Enter  Manager Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter  Manager Age:");
            Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter   Manager Phone No:");
            PhoneNo = Console.ReadLine();
            Console.WriteLine("Enter   Manager Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter   Manager salary:");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter DepartMent");
            DepartMent = Console.ReadLine();
            base.ChkTelephone();
        }
        public void DisplayDetails()
        {
            
            Console.WriteLine("Manager Name: "+Name);
            Console.WriteLine("Manager Age: " +Age );
            Console.WriteLine("Manager PhoneNO: " + PhoneNo);
            base.printSalary();
            Console.WriteLine("Manager Address: " + Address);
            Console.WriteLine("Manager Department: " + DepartMent);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Employee E = new Employee();
            E.getDetails();
            Manger M = new Manger();
            M.getDetails();
            E.DisplayDetails();
            M.DisplayDetails();

        }
    }
}
