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
    public partial class Form3 : Form
    {
        public Form3()
        {
            outof();
        }
        private void outof()
        {
            InitializeComponent();
            List<number> ft = new List<number>();
            ft.Add(new number() { name = "SELECT OUT OFF" });
            ft.Add(new number() { show = 100, name = "Out of 100" });
            ft.Add(new number() { show = 50, name = "Out of 50" });
            ft.Add(new number() { show = 20, name = "Out of 20" });
            comboBox1.DataSource = ft;
            comboBox1.DisplayMember = "name";
            resetformcontrols();
        }
        public int percentage, total, outoftotal, result;
        public char Pass, Fail, Merit, Distinction, First, Second, Class;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void getstudentsrecord()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from firsta", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        
        private bool checkfa()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from firsta where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkfb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from firstb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksa()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from seconda where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from secondb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkta()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from thirda where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checktb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from thirdb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkfoura()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from fourtha where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkfourb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from fourthb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkfivea()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from fiftha where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkfiveb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from fifthb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksixa()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from sixtha where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksixb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from sixthb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksevena()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from seventha where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checksevenb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from seventhb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkeighta()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from eighta where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkeightb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from eightb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkninea()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from nintha where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checknineb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from ninthb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checktena()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from tentha where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checktenb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from tenthb where Rollno ='" + textBox1.Text + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (comboBox2.Text == "I")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checkfa())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            firsta();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from firsta", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkfb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            firstb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from firstb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "II")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checksa())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            seconda();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from seconda", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checksb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            secondb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from secondb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "III")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checkta())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            thirda();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from thirda", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checktb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            thirdb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from thirdb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "IV")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checkfoura())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            fourtha();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from fourtha", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkfourb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            fourthb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from fourthb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "V")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checkfivea())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            fiftha();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from fiftha", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkfiveb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            fifthb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from fifthb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "VI")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checksixa())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            sixtha();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from sixtha", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checksixb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            sixthb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from sixthb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "VII")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checksevena())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            seventha();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from seventha", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checksevenb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            seventhb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from seventhb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "VIII")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checkeighta())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            eighta();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from eighta", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checkeightb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            eightb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from eightb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "IX")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checkninea())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            nintha();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from nintha", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checknineb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ninthb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from ninthb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (comboBox2.Text == "X")
                {
                    if (comboBox3.Text == "A")
                    {
                        if (checktena())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tentha();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from tentha", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();    
                            dataGridView1.DataSource = dt;
                        }
                    }
                    else
                    {
                        if (checktenb())
                        {
                            MessageBox.Show("Student already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tenthb();
                            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand("Select * from tenthb", con);
                            DataTable dt = new DataTable();
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            dt.Load(sdr);
                            con.Close();
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
        }
        private void regular()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into studentdata values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text);
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if(textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20" )
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7 )
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
            }
            if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
            }
            if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
            {
                if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
            }
            if (percentage >= 35)
            {
                cmd.Parameters.AddWithValue("@Result", "Pass");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Result", "Fail");
            }

            if (percentage >= 0 && percentage < 35)
            {
                cmd.Parameters.AddWithValue("@Class", "Fail");
            }
            else if (percentage >= 35 && percentage < 45)
            {
                cmd.Parameters.AddWithValue("@Class", "Pass Class");
            }
            else if (percentage >= 45 && percentage < 60)
            {
                cmd.Parameters.AddWithValue("@Class", "Second Class");
            }
            else if (percentage >= 60 && percentage < 75)
            {
                cmd.Parameters.AddWithValue("@Class", "First Class");
            }
            else if (percentage >= 75 && percentage < 90)
            {
                cmd.Parameters.AddWithValue("@Class", "Distinction");
            }
            else
            {
                cmd.Parameters.AddWithValue("@Class", "Merit");
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void tenthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tenthb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void tentha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tentha values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void ninthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ninthb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void nintha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into nintha values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void eightb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into eightb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void eighta()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into eighta values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void seventhb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into seventhb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void seventha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into seventha values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void sixthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into studentdata values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void sixtha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into sixtha values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void fifthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into fifthb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void fiftha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into fiftha values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void fourthb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into fourthb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void fourtha()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into fourtha values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void thirdb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into thirdb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void thirda()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into thirda values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void secondb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into secondb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void seconda()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into seconda values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void firsta()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into firsta values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }
        private void firstb()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into firstb values (@Rollno,@Fullname,@Std,@Div,@English,@Maths,@Science,@History,@Geography,@Hindi,@Marathi,@Computer,@Outofenglish,@Outofmaths,@Outofscience,@Outofhistory,@Outofgeography,@Outofhindi,@Outofmarathi,@Outofcomputer,@Total,@Outoftotal,@Percentage,@Result,@Class)", con);
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Student is Successfully saved in the database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();
        }

        private bool IsValid()
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Student Roll No is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox2.Text == string.Empty)
            {

                MessageBox.Show("Student Name is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox2.Text == "")
            {

                MessageBox.Show("Student STD is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox3.Text == "")
            {

                MessageBox.Show("Student DIV is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox5.Text == "")
            {

                MessageBox.Show("English marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox6.Text == "")
            {

                MessageBox.Show("Maths marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox7.Text == "")
            {

                MessageBox.Show("Science marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox8.Text == "")
            {

                MessageBox.Show("History marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox9.Text == "")
            {

                MessageBox.Show("Geography marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox10.Text == "")
            {

                MessageBox.Show("Hindi marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox11.Text == "")
            {

                MessageBox.Show("Marathi marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox12.Text == "")
            {

                MessageBox.Show("Computer marks is required", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValid1()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "")
            {
                MessageBox.Show("Please select a student to update", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValid1())
            {
                if (comboBox2.Text == "I")
                {
                    if (comboBox3.Text == "A")
                    {
                        firsta1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from firsta", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        firstb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from firstb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "II")
                {
                    if (comboBox3.Text == "A")
                    {
                        seconda1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from seconda", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        secondb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from secondb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "III")
                {
                    if (comboBox3.Text == "A")
                    {
                        thirda1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from thirda", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        thirdb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from thirdb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "IV")
                {
                    if (comboBox3.Text == "A")
                    {
                        fourtha1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fourtha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        fourthb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fourthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "V")
                {
                    if (comboBox3.Text == "A")
                    {
                        fiftha1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fiftha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        fifthb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fifthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "VI")
                {
                    if (comboBox3.Text == "A")
                    {
                        sixtha1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from sixtha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        sixthb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from sixthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "VII")
                {
                    if (comboBox3.Text == "A")
                    {
                        seventha1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from seventha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        seventhb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from seventhb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "VIII")
                {
                    if (comboBox3.Text == "A")
                    {
                        eighta1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from eighta", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        eightb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from eightb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "IX")
                {
                    if (comboBox3.Text == "A")
                    {
                        nintha1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from nintha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        ninthb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from ninthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "X")
                {
                    if (comboBox3.Text == "A")
                    {
                        tentha1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from tentha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        tenthb1();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from tenthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }

            }
        }
        private void tenthb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update tenthb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void tentha1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update tentha set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void ninthb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update ninthb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void nintha1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update nintha set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void eightb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update eightb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void eighta1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update eighta set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void seventhb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update sevethb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void seventha1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update seventha set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void sixthb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update sixthb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString()); ;
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void sixtha1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update sixtha set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fifthb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update fifthb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fiftha1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update fiftha set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fourthb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update fourthb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fourtha1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update fourtha set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void thirdb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update thirdb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void thirda1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update thirda set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }
        private void secondb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update secondb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }
        private void seconda1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update seconda set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }
        private void firstb1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update firstb set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void firsta1()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            total = int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            outoftotal = int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text);
            percentage = (total * 100) / outoftotal;
            SqlCommand cmd = new SqlCommand("Update firsta set Fullname=@Fullname, Std=@Std, Div=@Div, English=@English, Maths=@Maths, Science=@Science, History=@History, Geography=@Geography, Hindi=@Hindi, Marathi=@Marathi, Computer=@Computer, Outofenglish=@Outofenglish, Outofmaths=@Outofmaths, Outofscience=@Outofscience, Outofhistory=@Outofhistory, Outofgeography=@outofgeography, Outofhindi=@Outofhindi, Outofmarathi=@Outofmarathi, Outofcomputer=@Outofcomputer, total=@total, Outoftotal=@Outoftotal, Percentage=@Percentage, Result=@Result, Class=@Class where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Fullname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Std", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Div", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@English", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Maths", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@Science", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@History", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@Geography", int.Parse(textBox9.Text));
            cmd.Parameters.AddWithValue("@Hindi", int.Parse(textBox10.Text));
            cmd.Parameters.AddWithValue("@Marathi", int.Parse(textBox11.Text));
            cmd.Parameters.AddWithValue("@Computer", int.Parse(textBox12.Text));
            cmd.Parameters.AddWithValue("@Outofenglish", int.Parse(textBox13.Text));
            cmd.Parameters.AddWithValue("@Outofmaths", int.Parse(textBox14.Text));
            cmd.Parameters.AddWithValue("@Outofscience", int.Parse(textBox15.Text));
            cmd.Parameters.AddWithValue("@Outofhistory", int.Parse(textBox16.Text));
            cmd.Parameters.AddWithValue("@Outofgeography", int.Parse(textBox17.Text));
            cmd.Parameters.AddWithValue("@Outofhindi", int.Parse(textBox18.Text));
            cmd.Parameters.AddWithValue("@Outofmarathi", int.Parse(textBox19.Text));
            cmd.Parameters.AddWithValue("@Outofcomputer", int.Parse(textBox20.Text));
            cmd.Parameters.AddWithValue("@Total", this.total);
            cmd.Parameters.AddWithValue("@Outoftotal", this.outoftotal);
            cmd.Parameters.AddWithValue("@Percentage", this.percentage);
            if (textBox13.Text == "20" && textBox14.Text == "20" && textBox15.Text == "20" && textBox16.Text == "20" && textBox17.Text == "20" && textBox18.Text == "20" && textBox19.Text == "20" && textBox20.Text == "20")
            {
                if (int.Parse(textBox5.Text) < 7 || int.Parse(textBox6.Text) < 7 || int.Parse(textBox7.Text) < 7 || int.Parse(textBox8.Text) < 7 || int.Parse(textBox9.Text) < 7 || int.Parse(textBox10.Text) < 7 || int.Parse(textBox11.Text) < 7 || int.Parse(textBox12.Text) < 7)
                {
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }

                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }

            }
            else if (textBox13.Text == "50" && textBox14.Text == "50" && textBox15.Text == "50" && textBox16.Text == "50" && textBox17.Text == "50" && textBox18.Text == "50" && textBox19.Text == "50" && textBox20.Text == "50")
            {
                if (int.Parse(textBox5.Text) < 18 || int.Parse(textBox6.Text) < 18 || int.Parse(textBox7.Text) < 18 || int.Parse(textBox8.Text) < 18 || int.Parse(textBox9.Text) < 18 || int.Parse(textBox10.Text) < 18 || int.Parse(textBox11.Text) < 18 || int.Parse(textBox12.Text) < 18)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 0 && percentage < 35)
                {
                    cmd.Parameters.AddWithValue("@Result", "Fail");
                    cmd.Parameters.AddWithValue("@Class", "Fail");
                }
                else if (percentage >= 35 && percentage < 45)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Pass Class");
                }
                else if (percentage >= 45 && percentage < 60)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Second Class");
                }
                else if (percentage >= 60 && percentage < 75)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "First Class");
                }
                else if (percentage >= 75 && percentage < 90)
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Distinction");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Result", "Pass");
                    cmd.Parameters.AddWithValue("@Class", "Merit");
                }
            }
            else
            {
                if (textBox13.Text == "100" && textBox14.Text == "100" && textBox15.Text == "100" && textBox16.Text == "100" && textBox17.Text == "100" && textBox18.Text == "100" && textBox19.Text == "100" && textBox20.Text == "100")
                {
                    if (int.Parse(textBox5.Text) < 35 || int.Parse(textBox6.Text) < 35 || int.Parse(textBox7.Text) < 35 || int.Parse(textBox8.Text) < 35 || int.Parse(textBox9.Text) < 35 || int.Parse(textBox10.Text) < 35 || int.Parse(textBox11.Text) < 35 || int.Parse(textBox12.Text) < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 0 && percentage < 35)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Fail");
                        cmd.Parameters.AddWithValue("@Class", "Fail");
                    }
                    else if (percentage >= 35 && percentage < 45)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Pass Class");
                    }
                    else if (percentage >= 45 && percentage < 60)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Second Class");
                    }
                    else if (percentage >= 60 && percentage < 75)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "First Class");
                    }
                    else if (percentage >= 75 && percentage < 90)
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Distinction");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Result", "Pass");
                        cmd.Parameters.AddWithValue("@Class", "Merit");
                    }

                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Updated Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            number ft1 = comboBox1.SelectedItem as number;
            textBox13.Text = Convert.ToString(ft1.show);
            textBox14.Text = Convert.ToString(ft1.show);
            textBox15.Text = Convert.ToString(ft1.show);
            textBox16.Text = Convert.ToString(ft1.show);
            textBox17.Text = Convert.ToString(ft1.show);
            textBox18.Text = Convert.ToString(ft1.show);
            textBox19.Text = Convert.ToString(ft1.show);
            textBox20.Text = Convert.ToString(ft1.show);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
        private bool IsValid2()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "")
            {
                MessageBox.Show("Please select a student to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid2())
            {
                if (comboBox2.Text == "I")
                {
                    if (comboBox3.Text == "A")
                    {
                        firsta2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from firsta", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        firstb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from firstb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "II")
                {
                    if (comboBox3.Text == "A")
                    {
                        seconda2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from seconda", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        secondb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from secondb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "III")
                {
                    if (comboBox3.Text == "A")
                    {
                        thirda2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from thirda", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        thirdb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from thirdb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "IV")
                {
                    if (comboBox3.Text == "A")
                    {
                        fourtha2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fourtha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        fourthb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fourthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "V")
                {
                    if (comboBox3.Text == "A")
                    {
                        fiftha2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fiftha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        fifthb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from fifthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "VI")
                {
                    if (comboBox3.Text == "A")
                    {
                        sixtha2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from sixtha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        sixthb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from sixthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "VII")
                {
                    if (comboBox3.Text == "A")
                    {
                        seventha2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from seventha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        seventhb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from seventhb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "VIII")
                {
                    if (comboBox3.Text == "A")
                    {
                        eighta2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from eighta", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        eightb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from eightb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "IX")
                {
                    if (comboBox3.Text == "A")
                    {
                        nintha2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from nintha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        ninthb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from ninthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }
                if (comboBox2.Text == "X")
                {
                    if (comboBox3.Text == "A")
                    {
                        tentha2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from tentha", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        tenthb2();
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("Select * from tenthb", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        dt.Load(sdr);
                        con.Close();
                        dataGridView1.DataSource = dt;
                    }
                }


            }

        }

        private void tenthb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tenthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void tentha2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tentha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void ninthb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete ninthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void nintha2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete nintha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void eightb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete eightb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void eighta2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete eighta where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();


        }

        private void seventhb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete seventhb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void seventha2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete seventha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();


        }

        private void sixthb2()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete sixthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void sixtha2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete sixtha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fifthb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete fifthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fiftha2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete fiftha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fourthb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete fourthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void fourtha2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete fourtha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void thirdb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete thirdb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void thirda2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete thirda where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }
        private void secondb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete secondb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }
        private void seconda2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete seconda where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }
        private void firstb2()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete firstb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void firsta2()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete firsta where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Information Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetformcontrols();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox1.Text, out box);
            if (comboBox2.Text == "I")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "II")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "III")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "IV")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "V")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "VI")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "VII")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "VIII")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 61 && textBox1.Text != "")
                    {
                        textBox1.Text = "60";
                        MessageBox.Show("Class strength is 60", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "IX")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 51 && textBox1.Text != "")
                    {
                        textBox1.Text = "50";
                        MessageBox.Show("Class strength is 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 51 && textBox1.Text != "")
                    {
                        textBox1.Text = "50";
                        MessageBox.Show("Class strength is 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            if (comboBox2.Text == "X")
            {
                if (comboBox3.Text == "A")
                {
                    if (box > 51 && textBox1.Text != "")
                    {
                        textBox1.Text = "50";
                        MessageBox.Show("Class strength is 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (box > 51 && textBox1.Text != "")
                    {
                        textBox1.Text = "50";
                        MessageBox.Show("Class strength is 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Character Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox11.Text, out box);
            if (textBox19.Text == "20")
            {
                if (box > 20 && textBox11.Text != "")
                {
                    textBox11.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox19.Text == "50")
            {
                if (box > 50 && textBox11.Text != "")
                {
                    textBox11.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox19.Text == "100")
            {
                if (box > 100 && textBox11.Text != "")
                {
                    textBox11.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Numbers or Digit Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dis = MessageBox.Show("Character Only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*number ft1 = comboBox2.SelectedItem as number;
            textBox3.Text = Convert.ToString(ft1.show);*/
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*number ft1 = comboBox3.SelectedItem as number;
            textBox4.Text = Convert.ToString(ft1.show);*/
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox5.Text, out box);
            if (textBox13.Text == "20")
            {
                if (box > 20 && textBox5.Text != "")
                {
                    textBox5.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox13.Text == "50")
            {
                if (box > 50 && textBox5.Text != "")
                {
                    textBox5.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }          
            if (textBox13.Text == "100")
                {
                    if (box > 100 && textBox5.Text != "")
                    {
                        textBox5.Text = "100";
                        MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }


        private void textBox5_Click(object sender, EventArgs e)
        {


        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private bool IsValid3()
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter rollno to search", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (IsValid3())
            {
                if (comboBox2.Text == "I")
                {
                    if (comboBox3.Text == "A")
                    {
                        firsta3();
                    }
                    else
                    {
                        firstb3();
                    }
                }
                if (comboBox2.Text == "II")
                {
                    if (comboBox3.Text == "A")
                    {
                        seconda3();
                    }
                    else
                    {
                        secondb3();
                    }
                }
                if (comboBox2.Text == "III")
                {
                    if (comboBox3.Text == "A")
                    {
                        thirda3();
                    }
                    else
                    {
                        thirdb3();
                    }
                }
                if (comboBox2.Text == "IV")
                {
                    if (comboBox3.Text == "A")
                    {
                        fourtha3();
                    }
                    else
                    {
                        fourthb3();
                    }
                }
                if (comboBox2.Text == "V")
                {
                    if (comboBox3.Text == "A")
                    {
                        fiftha3();
                    }
                    else
                    {
                        fifthb3();
                    }
                }
                if (comboBox2.Text == "VI")
                {
                    if (comboBox3.Text == "A")
                    {
                        sixtha3();
                    }
                    else
                    {
                        sixthb3();
                    }
                }
                if (comboBox2.Text == "VII")
                {
                    if (comboBox3.Text == "A")
                    {
                        seventha3();
                    }
                    else
                    {
                        seventhb3();
                    }
                }
                if (comboBox2.Text == "VIII")
                {
                    if (comboBox3.Text == "A")
                    {
                        eighta3();
                    }
                    else
                    {
                        eightb3();
                    }
                }
                if (comboBox2.Text == "IX")
                {
                    if (comboBox3.Text == "A")
                    {
                        nintha3();
                    }
                    else
                    {
                        ninthb3();
                    }
                }
                if (comboBox2.Text == "X")
                {
                    if (comboBox3.Text == "A")
                    {
                        tentha3();
                    }
                    else
                    {
                        tenthb3();
                    }
                }


            }
        }

        private void tenthb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tenthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void tentha3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tentha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void ninthb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ninthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void nintha3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from nintha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void eightb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from eightb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void eighta3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from eighta where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void seventhb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from seventhb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void seventha3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from seventha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void sixthb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from sixthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void sixtha3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from sixtha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void fifthb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fifthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void fiftha3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fiftha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void fourthb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fourthb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void fourtha3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from fourtha where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void thirdb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thirdb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void thirda3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from thirda where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void secondb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from secondb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void seconda3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from seconda where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox6.Text, out box);
            if (textBox14.Text == "20")
            {
                if (box > 20 && textBox6.Text != "")
                {
                    textBox6.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox14.Text == "50")
            {
                if (box > 50 && textBox6.Text != "")
                {
                    textBox6.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox14.Text == "100")
            {
                if (box > 100 && textBox6.Text != "")
                {
                    textBox6.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox7.Text, out box);
            if (textBox15.Text == "20")
            {
                if (box > 20 && textBox7.Text != "")
                {
                    textBox7.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox15.Text == "50")
            {
                if (box > 50 && textBox7.Text != "")
                {
                    textBox7.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox15.Text == "100")
            {
                if (box > 100 && textBox7.Text != "")
                {
                    textBox7.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox8.Text, out box);
            if (textBox16.Text == "20")
            {
                if (box > 20 && textBox8.Text != "")
                {
                    textBox8.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox16.Text == "50")
            {
                if (box > 50 && textBox8.Text != "")
                {
                    textBox8.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox16.Text == "100")
            {
                if (box > 100 && textBox8.Text != "")
                {
                    textBox8.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox9.Text, out box);
            if (textBox17.Text == "20")
            {
                if (box > 20 && textBox9.Text != "")
                {
                    textBox9.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox17.Text == "50")
            {
                if (box > 50 && textBox9.Text != "")
                {
                    textBox9.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox17.Text == "100")
            {
                if (box > 100 && textBox9.Text != "")
                {
                    textBox9.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox10.Text, out box);
            if (textBox18.Text == "20")
            {
                if (box > 20 && textBox10.Text != "")
                {
                    textBox10.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox18.Text == "50")
            {
                if (box > 50 && textBox10.Text != "")
                {
                    textBox10.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox18.Text == "100")
            {
                if (box > 100 && textBox10.Text != "")
                {
                    textBox10.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            int box = 0;
            Int32.TryParse(textBox12.Text, out box);
            if (textBox20.Text == "20")
            {
                if (box > 20 && textBox12.Text != "")
                {
                    textBox12.Text = "20";
                    MessageBox.Show("Entered marks cannot be greater than 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox20.Text == "50")
            {
                if (box > 50 && textBox12.Text != "")
                {
                    textBox12.Text = "50";
                    MessageBox.Show("Entered marks cannot be greater than 50", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (textBox20.Text == "100")
            {
                if (box > 100 && textBox12.Text != "")
                {
                    textBox12.Text = "100";
                    MessageBox.Show("Entered marks cannot be greater than 100", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstb3()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from firstb where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void firsta3()
        {

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-0UVSJLJS;Initial Catalog=MyTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from firsta where Rollno=@Rollno", con);
            cmd.Parameters.AddWithValue("@Rollno", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }


        private void button5_Click(object sender, EventArgs e)
        {
           // getstudentsrecord();  
            resetformcontrols();
        }

        private void resetformcontrols()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            dataGridView1.ClearSelection();
            comboBox1.Text = "SELECT OUT OFF";
            comboBox2.Text = "SELECT STD ";
            comboBox3.Text = "SELECT DIV";
            textBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            textBox14.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            textBox15.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            textBox16.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            textBox17.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            textBox18.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            textBox19.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
            textBox20.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
