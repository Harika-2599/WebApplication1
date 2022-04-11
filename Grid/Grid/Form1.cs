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
using System.Configuration;
namespace Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data source=US-637KZH3;Initial Catalog=demoprojects;Integrated Security = true";
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tblEmployees", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);



            //datagridview1
            dataGridView1.DataSource = dtb1;
        }
    }
}