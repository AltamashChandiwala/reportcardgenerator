using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportcardgenerator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }        

        private void Form4_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from studentdata",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report1.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
