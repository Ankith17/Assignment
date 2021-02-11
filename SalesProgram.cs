using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Sales
{
    
        public class DBHandler
        {
            public SqlConnection GetConnection()
            {
                string connectionString = ConfigurationManager.connectionStrings["SqlCon"].ToString();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                return sqlConnection;
            }
        }
        public class Metalapps
        {
            public SqlConnection SqlCon;
            public void AddSalesDetails(SalesDetails sd)
            {
                DBHandler dBHandler = new DBHandler();
                SqlCon = dBHandler.GetConnection();
                SqlCommand sqlCommand = new SqlCommand("Insert into SalesDetails values(@Sales_id, @Customer_name, @Noof_units, @Net_amount)", SqlCon);
                sqlCommand.Parameters.AddWithValue("@Sales_id", sd.SalesId);
                sqlCommand.Parameters.AddWithValue("@Customer_name", sd.CustomerName);
                sqlCommand.Parameters.AddWithValue("@Noof_units", sd.NoOfUnits);
                sqlCommand.Parameters.AddWithValue("@Net_amount", sd.NetAmount);

                SqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                SqlCon.Close();
                sqlCommand.Dispose();
                SqlCon.Dispose();

            }
            public void CalculateNetAmount(SalesDetails details)
            {

                float discount = 0;
                if (details.NoOfUnits <= 5)
                {
                    discount = 0;
                }
                else if (details.NoOfUnits > 5 && details.NoOfUnits <= 10)
                {
                    discount = .02f;
                }
                else if (details.NoOfUnits > 10 && details.NoOfUnits <= 15)
                {
                    discount = .05f;
                }
                else if (details.NoOfUnits > 15 && details.NoOfUnits <= 20)
                {
                    discount = .08f;
                }
                else
                {
                    discount = .1f;
                }
                details.NetAmount = (75350 * details.NoOfUnits)
                    - (75350 * details.NoOfUnits) * discount;

            }


        }
    }


    
