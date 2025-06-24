using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cafeotomasyonu
{
    public partial class SiparisVer : Form
    { public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;
        public Form7 frm7;
        public Form8 frm8;
        public Form9 frm9;
        public Form10 frm10;
        public Form11 frm11;
        public Form12 frm12;
        public Form13 frm13;
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();
        
        public void goster()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * From siparis", bag);
            adtr.Fill(dtst, "siparis");
            dataView1.Table = dtst.Tables[0];
            dataGrid1.DataSource = dataView1;
            bag.Close();
            dtst.Dispose();
        }
        
        public void corba1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from corba";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                frm3.comboBox1.Items.Add(oku[0].ToString());
                frm4.comboBox1.Items.Add(oku[0].ToString());
                frm5.comboBox1.Items.Add(oku[0].ToString());
                frm6.comboBox1.Items.Add(oku[0].ToString());
                frm7.comboBox1.Items.Add(oku[0].ToString());
                frm8.comboBox1.Items.Add(oku[0].ToString());
                frm9.comboBox1.Items.Add(oku[0].ToString());
                frm10.comboBox1.Items.Add(oku[0].ToString());
                frm11.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            frm3.comboBox1.Sorted = true;
        }
        public void tatli1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from pide";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                frm3.comboBox2.Items.Add(oku[0].ToString());
                frm4.comboBox2.Items.Add(oku[0].ToString());
                frm5.comboBox2.Items.Add(oku[0].ToString());
                frm6.comboBox2.Items.Add(oku[0].ToString());
                frm7.comboBox2.Items.Add(oku[0].ToString());
                frm8.comboBox2.Items.Add(oku[0].ToString());
                frm9.comboBox2.Items.Add(oku[0].ToString());
                frm10.comboBox2.Items.Add(oku[0].ToString());
                frm11.comboBox2.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            frm3.comboBox2.Sorted = true;
        }
        public void pide1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from kebap";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                frm3.comboBox3.Items.Add(oku[0].ToString());
                frm4.comboBox3.Items.Add(oku[0].ToString());
                frm5.comboBox3.Items.Add(oku[0].ToString());
                frm6.comboBox3.Items.Add(oku[0].ToString());
                frm7.comboBox3.Items.Add(oku[0].ToString());
                frm8.comboBox3.Items.Add(oku[0].ToString());
                frm9.comboBox3.Items.Add(oku[0].ToString());
                frm10.comboBox3.Items.Add(oku[0].ToString());
                frm11.comboBox3.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            frm3.comboBox3.Sorted = true;
        }
        public void kebap1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from tatlı";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                frm3.comboBox4.Items.Add(oku[0].ToString());
                frm4.comboBox4.Items.Add(oku[0].ToString());
                frm5.comboBox4.Items.Add(oku[0].ToString());
                frm6.comboBox4.Items.Add(oku[0].ToString());
                frm7.comboBox4.Items.Add(oku[0].ToString());
                frm8.comboBox4.Items.Add(oku[0].ToString());
                frm9.comboBox4.Items.Add(oku[0].ToString());
                frm10.comboBox4.Items.Add(oku[0].ToString());
                frm11.comboBox4.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            frm3.comboBox4.Sorted = true;
        }        
        public SiparisVer()
        {
            InitializeComponent();
            frm2 = new Form2();            
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();
            frm7 = new Form7();
            frm8 = new Form8();
            frm9 = new Form9();
            frm10 = new Form10();
            frm11 = new Form11();
            frm12 = new Form12();
            frm13 = new Form13();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;            
            frm5.frm1 = this;
            frm6.frm1 = this;            
            frm7.frm1 = this;
            frm8.frm1 = this;            
            frm9.frm1 = this;
            frm10.frm1 = this;            
            frm11.frm1 = this;
            frm12.frm1 = this;
            frm13.frm1 = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goster();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void SiparisVer_Load(object sender, EventArgs e)
        {
            
        }
    }
    }
        








































       



    


