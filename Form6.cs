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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        void firsta()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from firsta", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void firstb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from firstb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void seconda()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from seconda", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void secondb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from secondb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void thirda()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thirdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void thirdb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thirdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void fourtha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fourtha", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void fourthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fourthb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void fiftha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fifthb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void fifthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fifthb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void sixtha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from sixtha", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void sixthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from sixthb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void seventha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from seventha", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void seventhb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from seventhb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void eightha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from eighta", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void eighthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from eightb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void nintha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ninetha", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void ninthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ninethb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void tentha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tentha", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        void tenthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tenthb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = (@"C:\Users\altamash chandiwala\source\repos\reportcardgenerator\Report3.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "first")
            {
                if (comboBox2.Text == "A")
                {
                    firsta();
                }
                else
                {
                    firstb();
                }
            }
            else if (comboBox1.Text == "second")
            {
                if (comboBox2.Text == "A")
                {
                    seconda();
                }
                else
                {
                    secondb();
                }
            }
            else if (comboBox1.Text == "third")
            {
                if (comboBox2.Text == "A")
                {
                    thirda();
                }
                else
                {
                    thirdb();
                }
            }
            else if (comboBox1.Text == "fourth")
            {
                if (comboBox2.Text == "A")
                {
                    fourtha();
                }
                else
                {
                    fourthb();
                }
            }
            else if (comboBox1.Text == "fifth")
            {
                if (comboBox2.Text == "A")
                {
                    fiftha();
                }
                else
                {
                    fifthb();
                }
            }
            else if (comboBox1.Text == "sixtha")
            {
                if (comboBox2.Text == "A")
                {
                    sixtha();
                }
                else
                {
                    sixthb();
                }
            }
            else if (comboBox1.Text == "seventh")
            {
                if (comboBox2.Text == "A")
                {
                    seventha();
                }
                else
                {
                    seventhb();
                }
            }
            else if (comboBox1.Text == "eight")
            {
                if (comboBox2.Text == "A")
                {
                    eightha();
                }
                else
                {
                    eighthb();
                }
            }
            else if (comboBox1.Text == "ninth")
            {
                if (comboBox2.Text == "A")
                {
                    nintha();
                }
                else
                {
                    ninthb();
                }
            }
            else if (comboBox1.Text == "tenth")
            {
                if (comboBox2.Text == "A")
                {
                    tentha();
                }
                else
                {
                    tenthb();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
