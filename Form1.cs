using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace protypeprototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2000591;User ID=mssql2000591;Password=kS7sPX426y";
            cnn = new SqlConnection(connetionString);
            cnn.Open();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * FROM Hardware";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - " + dataReader.GetValue(5) + " - " + dataReader.GetValue(6) + "\n";
                listBox1.Items.Add(Output);
                Output = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 whycodedodis = new Form3();
            whycodedodis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2000591;User ID=mssql2000591;Password=kS7sPX426y";
            cnn = new SqlConnection(connetionString);
            cnn.Open();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * FROM Hardware";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - " + dataReader.GetValue(5) + " - " + dataReader.GetValue(6) + "\n";
                listBox1.Items.Add(Output);
                Output = "";
            }
        }
    }
}
