using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignment1
{
    class Customer
    {
        public int customerId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
    class Product
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public string desc { get; set; }
        public int qnty { get; set; }
    }
    class Order
    {
        public int Oid { get; set; }
        public DateTime odate { get; set; }
        public int cid { get; set; }
        public int pid { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Customer> customer = new List<Customer>()
       {
           new Customer(){customerId=5,name="Akash",address="Bangalore"},
            new Customer() { customerId = 1, name = "jithu", address = "Bangalore" },
            new Customer() { customerId = 2, name = "Anku", address = "Chennai" },
            new Customer() { customerId = 3, name = "Akshu", address = "Bangalore" },
            new Customer() { customerId = 4, name = "Moni", address = "Chennai" }

        };
            IList<Product> products= new List<Product>()
       {
           new Product(){pid=5,pname="bat",desc="good"},
            new Product() { pid = 1, pname = "ball",desc = "round",qnty=50 },
            new Product() { pid = 2, pname = "book", desc = "low",qnty=100 },
            new Product() { pid = 3, pname = "mobile", desc = "best",qnty=20},
            new Product() { pid = 4, pname = "key", desc = "bold",qnty=75}

        };
            IList<Order> order = new List<Order>()
            {
                new Order(){ Oid=1,odate=Convert.ToDateTime("12-08-2015"),cid=1 , pid=1 },
                new Order(){ Oid=1,odate=Convert.ToDateTime("11-08-2020"),cid=2 , pid=2 },
                new Order(){ Oid=1,odate=Convert.ToDateTime("12-08-2018"),cid=3 , pid=3 },
                new Order(){ Oid=1,odate=Convert.ToDateTime("12-01-2021"),cid=4 , pid=4 },

            };


            var p = from s in products select s;
            foreach (var x in p)
                Console.WriteLine(x.pid+" "+x.pname+" "+x.desc+" "+x.qnty);

            var c = from s in customer select s;
            foreach (var x in c)
                Console.WriteLine(x.customerId + " " + x.name + " " + x.address);

            var ord = from s in products where s.qnty >= 100 select s;
            foreach (var x in ord)
                Console.WriteLine(x.pid + " " + x.pname + " " + x.desc );

            var orde = from s in products where s.qnty > 10 && s.qnty<=50 select s;
            foreach (var x in orde)
                Console.WriteLine(x.pid + " " + x.pname + " " + x.desc);

            var pr = from s in products select s;
            foreach (var x in pr)
                Console.WriteLine( x.pname + " "+ x.qnty);

        }
    }
}
