using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class SqlInteraction
    {
        SqlConnection con = null;
        SqlCommand com = null;
        public SqlInteraction()
        {
            
            //"Data Source =.; Initial Catalog = TempDB; User Id = ; Password = ;MultipleActiveResultSets=true";

            con = new SqlConnection("Data Source =.; Initial Catalog = TempDB; Integrated Security = true; MultipleActiveResultSets=true");
            con.Open();
        }
        public List<DemoData> FetachData()
        {
            DemoData data = new DemoData();
            List<DemoData> liStD = new List<DemoData>();
          //  con.Open();
            com = new SqlCommand("Select * from ForSQL1", con);
            SqlDataReader rdr = com.ExecuteReader();

            while (rdr.Read())
            {
                data.ID = rdr.GetInt32(0);
                data.Age = rdr.GetInt32(1);
                data.NameP = rdr.GetString(2);
                data.LocationP = rdr.GetString(3);
                liStD.Add(data);
            }
           // con.Close();
            return liStD;

        }
        public string UpdateData(DemoData data)
        {
            string result = null;
          //  con.Open();
            com = new SqlCommand("update ForSQL1 set NameP=@name where ProductID=@id", con);
            com.Parameters.Add("@name", SqlDbType.VarChar).Value = data.NameP;
            com.Parameters.Add("@id", SqlDbType.Int).Value = data.ID;
            int val = com.ExecuteNonQuery();
            if(val > 0)
            {
                result = "Success";
            }
            else
            {
                result = "Fails !!";
            }
            return result;
          //  con.Close();
        }
        public string DeletData(DemoData data)
        {
            string result = null;
            com = new SqlCommand("delete from ForSQL1 where ProductID=@id", con);
            com.Parameters.Add("@id", SqlDbType.Int).Value = data.ID;
            int res = com.ExecuteNonQuery();
            if(res > 0)
            {
                result = "Success";
            }
            else
            {
                result = "fails";
            }
            //Console.WriteLine(data.Age);
            //Console.WriteLine(data.LocationP);
            return result;

        }
        public int InsertData(DemoData data)
        {
            // string val = "some value" 
            // Insert into ForSQL1 values ("+val+",'Leo','Japan')
           // con.Open();
            com = new SqlCommand("Insert into ForSQL1 values(@age,@name,@location)", con);
            com.Parameters.Add("@age", SqlDbType.Int).Value = data.Age;
            com.Parameters.Add("@name", SqlDbType.VarChar).Value = data.NameP;
            com.Parameters.Add("@location", SqlDbType.VarChar).Value = data.LocationP;
            int res = com.ExecuteNonQuery();
          //  con.Close();
            return res;
        }
        public void RunProc()
        {
            var proc = "Select_ForSQL1";

            com = new SqlCommand(proc, con);
            // com.CommandType = CommandType.StoredProcedure;
            com.CommandType = CommandType.StoredProcedure;

            SqlDataReader sdr = com.ExecuteReader();

            while (sdr.Read())
            {
                Console.WriteLine(sdr.GetInt32(0));
                Console.WriteLine(sdr.GetInt32(1));
                Console.WriteLine(sdr.GetString(2));
                Console.WriteLine(sdr.GetString(3));
            }

        }
        public void JoinQuery()
        {
           // SqlDataAdapter sda = new SqlDataAdapter("Select * from ForSQL1", con);

        }
        public void DisposeTheConnection()
        {
            con.Dispose();
        }
    }

    public class DemoData
    {
        public string NameP { get; set; }

        public int Age { get; set; }

        public int ID { get; set; }

        public string LocationP { get; set; }
    }
}
