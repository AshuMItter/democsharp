using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Console.WriteLine("Hello World!");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TempDB; Integrated Security=true");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ForSQL1 inner JOIN ForSQL2 ON ForSQL1.ProductID = ForSQL2.ProductID", con);
            DataSet setDs = new DataSet();

            sda.Fill(setDs);
            dataGridView1.DataSource = setDs.Tables[0];

            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TempDB; Integrated Security=true");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ForSQL1 inner JOIN ForSQL2 ON ForSQL1.ProductID = ForSQL2.ProductID", con);
            DataSet setDs = new DataSet();

            sda.Fill(setDs);
            dataGridView1.DataSource = setDs.Tables[0];

            con.Close();
        }
    }
}
