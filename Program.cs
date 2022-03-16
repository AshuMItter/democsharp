using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace ConsoleAppAdoDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadDataFromDbaseConnected();
        }
        static void ReadDataFromDbaseConnected()
        {
          SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = TempDB;Integrated Security = true");
          con.Open();
          SqlCommand com = new SqlCommand("Select min(age) from ForSQL1", con);

SqlDataReader rdr = com.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr.GetInt32(0));
            }
        //  Console.WriteLine(val);
            //  //   SqlDataReader sdr = com2.ExecuteReader();

            //     SqlDataReader read = com.ExecuteReader();
            //     //com.ExecuteNonQuery();
            //      List<ForSQL1> items = new List<ForSQL1>();

            //    // Console.WriteLine(obj.);
            //     ForSQL1 sql1 = null;
            //     while (read.Read())
            //     {
            //       sql1 = new ForSQL1();
            //       sql1.ProductID =    read.GetInt32(0);
            //       sql1.Age =   read.GetInt32(1);
            //       sql1.NameP =   read.GetString(2);
            //       sql1.LocationP =   read.GetString(3);

            //         items.Add(sql1);

            //         //items.Add(sql1);
            //         //Console.WriteLine(read.GetInt32(0));
            //         //Console.WriteLine(read.GetInt32(1));
            //         //Console.WriteLine(read.GetString(2));
            //         //Console.WriteLine(read.GetString(3));

            //     }
            //     con.Close();
            //  //   con.Dispose();
            //     foreach (var item in items)
            //     {
            //         Console.WriteLine($"Hi {item.NameP} ! I found your ID was :{item.ProductID} while you are from {item.LocationP}. You seem to be grown up as your age is {item.Age}");
            //     }
            con.Close();
            con.Dispose();
           
            //SqlCommand com2 = new SqlCommand("Select * from ForSQL1", con);

            //SqlDataReader sdr1 = com2.ExecuteReader();

            //while (sdr1.Read())
            //{
            //    Console.WriteLine(sdr1.GetInt32(0));
            //    Console.WriteLine(sdr1.GetInt32(1));
            //    Console.WriteLine(sdr1.GetString(2));
            //    Console.WriteLine(sdr1.GetString(3));


            //}
            //con.Close();
            //con.Dispose();



            //foreach (var item in items)
            //{
            //    Console.WriteLine(item.NameP);
            //}
        }
        static void ReadDataFromDbaseDisConnected()
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = TempDB;Integrated Security = true");
            con.Open();
          //  SqlCommand com = new SqlCommand("Select * from ForSQL1", con);

            SqlDataAdapter sda = new SqlDataAdapter("Select * from ForSQL1", con);

            DataSet ds = new DataSet();
            sda.Fill(ds, "ForSQL1");

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.Rows[3];
            foreach (var item in dr.ItemArray)
            {
                Console.WriteLine(item);
            }

            DataColumn dc = dt.Columns[0];

            Console.WriteLine(dc.Caption);
            //Console.WriteLine(dt.);

            con.Close();
            con.Dispose();

        }
        class ForSQL1
        {
            public int ProductID { get; set; }
            public int Age { get; set; }

            public string NameP { get; set; }

            public string LocationP { get; set; }
        }
    }
}
