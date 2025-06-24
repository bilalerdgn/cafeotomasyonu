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
    public partial class Form13 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");

        Form6 frm = new Form6();

        public SiparisVer frm1;
        public Form13()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form13_Load(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm1.frm2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            

                    double fyt1, fyt2, fyt3, fyt4, tutar;
                    fyt1 = double.Parse(textBox1.Text);

                    fyt2 = double.Parse(textBox2.Text);

                    fyt3 = double.Parse(textBox3.Text);

                    fyt4 = double.Parse(textBox4.Text);

                    tutar = fyt1 + fyt2 + fyt3 + fyt4;

                    label9.Text = (tutar.ToString() + "TL");





                
            }
        }

      
    }

