using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
   public class SalesDetails
    {
        private int salesId;
        private string customerName;
        private int noOfUnits;
        private double netAmount;

        public int SalesId
        {
            get { return salesId; }
            set { salesId = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public int NoOfUnits
        {
            get { return noOfUnits; }
            set { noOfUnits = value; }
        }
        public double NetAmount
        {
            get { return netAmount; }
            set { netAmount = value; }
        }
    }
}
