using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SqlServerWithDataSet_001
{
    internal class DataSetClass
    {
        public void DemoDataSet()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            SqlConnection conn = new SqlConnection(); // create connection string
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString; // call connection string by connectionString property
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Customers; select * from Orders", conn);
                DataSet dataset = new DataSet(); //
                dataAdapter.Fill(dataset);

                WriteLine("Customers");
                foreach(DataRow select in dataset.Tables[0].Rows)
                {
                    WriteLine(select["ID"] + " | " + select["Name"] + " | " + select["Mobile"]);
                }
                WriteLine();
                WriteLine("Orders");
                foreach(DataRow select in dataset.Tables[1].Rows)
                {
                    WriteLine(select["ID"] + " | " + select["CustomerId"] + " | " + select["Amount"]);
                }
            }
            catch(Exception ex)
            {
                WriteLine("Đã xuất hiện lỗi!!! " + ex.Message);
            }
        }
    }
}
