using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public int id;
        public string name;
        public string Mname;
        public string dept;
        public double salary;

        public void DisplayDetails(List<Employee> employList)
        {
            Console.WriteLine("Id\tName\tManger Name\tDepartment\tSalary");
            foreach (var emp in employList)
                Console.WriteLine(emp.id + "\t" + emp.name + "\t" + emp.Mname + "\t" + emp.dept + "\t" + emp.salary);
        }
        public void MaxSalary(List<Employee> emplist)
        {
            var maxsalary = (from x in emplist select x.salary).Max();
            foreach (var emp in emplist)
            {
                if (maxsalary == emp.salary)
                    Console.WriteLine("Maximum salary of Employee " + emp.name + " is " + maxsalary);
            }
        }
        public void MinSalary(List<Employee> emplist)
        {
            var minsalary = (from x in emplist select x.salary).Min();
            foreach (var emp in emplist)
            {
                if (minsalary == emp.salary)
                    Console.WriteLine("Minum salary of Employee " + emp.name + " is " + minsalary);
            }
        }

        public void TotalSalary(List<Employee> emplist)
        {
            var sumsalary = (from x in emplist select x.salary).Sum();
             Console.WriteLine("Total salary of all Employee is " + sumsalary);
           
        }

        public void AverageSalary(List<Employee> emplist)
        {
            var Avgsalary = (from x in emplist select x.salary).Average();
            Console.WriteLine("Avarage salary is " + Avgsalary);

        }

        public void DisplayEmployee(List<Employee> employList)
        {
            Console.WriteLine("Id\tName\tDepartment");
            foreach (var emp in employList)
                Console.WriteLine(emp.id + "\t" + emp.name + "\t" + emp.dept);
        }
        public void NoOfDepartment(List<Employee> emplist)
        {
            var NoDept = (from x in emplist select x.dept).Count();
            Console.WriteLine("No of DepartMent is " + NoDept);

        }
        public void HrEmp(List<Employee> emplist)
        {
            Console.WriteLine("Employee in HR deparment");
            foreach (var x in emplist)
            {
                if(x.dept=="HR")
                Console.WriteLine(x.name);
            }

        }

        public void NameFinding(List<Employee> emplist)
        {
            var Name = from x in emplist where x.name == "Ankith" select x;
            foreach(var x in Name)
            Console.WriteLine("Name of Employee with name Ankith :"+x.name+" and Id no is:"+x.id);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){id=1,name="Ankith",Mname="Naga",dept="IT",salary=50000},
                new Employee(){id=2,name="Harshith",Mname="Deepa",dept="HR",salary=40000},
                new Employee(){id=3,name="Alok",Mname="Rohith",dept="Sales",salary=80000},
                new Employee(){id=4,name="Megha",Mname="Sudheer",dept="IT",salary=10000},
                new Employee(){id=5,name="Deeksha",Mname="Ayan",dept="IT",salary=8000},
                new Employee(){id=6,name="Arun",Mname="Mohith",dept="Account",salary=5000},
                new Employee(){id=7,name="Prasad",Mname="Naga",dept="IT",salary=70000},
                new Employee(){id=8,name="Tarun",Mname="Sudheer",dept="IT",salary=50000},
                new Employee(){id=9,name="Monish",Mname="Mohith",dept="Account",salary=60000},
                new Employee(){id=10,name="Kavya",Mname="Mohith",dept="Account",salary=50000},
            };
            Employee empl = new Employee();
            empl.DisplayDetails(employeeList);
            empl.MaxSalary(employeeList);
            empl.MinSalary(employeeList);
            empl.TotalSalary(employeeList);
            empl.AverageSalary(employeeList);
            empl.DisplayEmployee(employeeList);
            empl.NoOfDepartment(employeeList);
            empl.HrEmp(employeeList);
            empl.NameFinding(employeeList);
            Console.ReadKey();
        }
    }
}
