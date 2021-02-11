using System;

using System.Data.SqlClient;

namespace Sales
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("SalesId");
                int SalesId = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("CustomerName");
                string CustomerName = Console.ReadLine();
                Console.WriteLine("NoOfUnits");

                int NoOfUnit = Convert.ToByte(Console.ReadLine());
                if (NoOfUnit < 5)
                    throw new ArgumentOutOfRangeException("No Sales for units below 5");
                SalesDetails salesDetails = new SalesDetails()
                {
                    SalesId = SalesId,
                    CustomerName = CustomerName,
                    NoOfUnits = NoOfUnit,
                    NetAmount = 0
                };
                Metalapps metalapps = new Metalapps();
                metalapps.CalculateNetAmount(salesDetails);
                metalapps.AddSalesDetails(salesDetails);
            }
            catch (ArgumentOutOfRangeException obj)
            {
                Console.WriteLine(obj.Message);
            }

        }

    }

}
