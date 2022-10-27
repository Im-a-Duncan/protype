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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2000591;User ID=mssql2000591;Password=kS7sPX426y";
            cnn = new SqlConnection(connetionString);
            cnn.Open();



            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "INSERT INTO assets VALUES('" + modelin.Text + "', '" + manufacturerin.Text + "', '" + typein.Text + "', '" + ipin.Text + "', '" + purchasein.Text + "', '" + notesin.Text + "',); ";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }
    }
}
