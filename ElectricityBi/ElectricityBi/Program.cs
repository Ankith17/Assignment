using System;

namespace ElectricityBi
{
    class Bill{
        public int customerID;
        public string CustomerName;
        public int units;
        public double amount;
        public double netAmount;
        public double sCharge;
        public void GetDetails()
        {
            customerID = Convert.ToInt32(Console.ReadLine());
            CustomerName = Console.ReadLine();
            units= Convert.ToInt32(Console.ReadLine());
        }
        public void Amount()
        {
            if (units < 200)
            {
                amount = units * 1.20;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit : "+amount);
            }
            else if (units >= 200 && units < 400)
            {
                amount = units * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit : " + amount);
            }
            else if (units >= 400 && units < 600)
            {
                amount = units * 1.80;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit : " + amount);
            }
            else if (units >= 600)
            {
                amount = units * 2.0;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit : " + amount);
            }
        }

        public void GetseCharge()
        {
            if (amount > 400)
            {
                sCharge = (amount * 15) / 100;
            }
            else
            {
                sCharge = 200;
            }
            Console.WriteLine("Surchage Amount : "+sCharge);
        }

        public void GetnetAmount()
        {
            netAmount = sCharge + amount;
            Console.WriteLine("Net Amount Paid By the Customer : "+netAmount);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Customer ID NO: "+customerID);
            Console.WriteLine("Customer Name : "+CustomerName);
            Console.WriteLine("unit Consumed : "+units);
            
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.GetDetails();
            bill.DisplayDetails();
            bill.Amount();
            bill.GetseCharge();
            bill.GetnetAmount();
            Console.ReadKey();
        }
    }
}
