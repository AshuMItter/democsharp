using System;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TempDB; Integrated Security=true");
            con.Open();
          //  SqlCommand com = new SqlCommand("Select * from ForSQL1", con);
           SqlCommand com = new SqlCommand("SELECT *FROM ForSQL1 inner JOIN ForSQL2 ON ForSQL1.ProductID = ForSQL2.ProductID", con);
            SqlDataReader sdr = com.ExecuteReader();
            //Console.WriteLine(sdr.HasRows);
            while (sdr.Read())
            {
                Console.WriteLine(sdr.GetInt32(0));
                Console.WriteLine(sdr.GetInt32(1));
                Console.WriteLine(sdr.GetString(2));
                Console.WriteLine(sdr.GetString(3));
                Console.WriteLine(sdr.GetInt32(4));
                Console.WriteLine(sdr.GetInt32(5));
                Console.WriteLine(sdr.GetString(6));
                Console.WriteLine(sdr.GetString(7));

            }
            con.Close();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ForSQL1 inner JOIN ForSQL2 ON ForSQL1.ProductID = ForSQL2.ProductID", con);
            DataSet setDs = new DataSet();

            sda.Fill(setDs);

            con.Close();



        }
    }
}
