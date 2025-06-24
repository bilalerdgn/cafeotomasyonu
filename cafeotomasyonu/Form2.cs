using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeotomasyonu
{
    public partial class Form2 : Form
    {
        public SiparisVer frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         frm1.frm2.button2.BackColor = System.Drawing.Color.Green;//butonun arkaplan renginin yeşil olmasını sağlıyoruz
         frm1.frm2.button3.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button4.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button5.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button6.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button7.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button8.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button9.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button10.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button11.BackColor = System.Drawing.Color.Green;
         frm1.frm2.button1.BackColor = System.Drawing.Color.DarkOrange;

            frm1.corba1();
            frm1.tatli1();
            frm1.pide1();
            frm1.kebap1();

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm1.dtst.Clear();//bilgilerin sürekli tekrarlanmaması için dataseti temizliyoruz.            
            frm1.Show();
            this.Hide();
            frm1.goster();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm1.frm3.Show();//form3'ün gösterilmesini sağlıyoruz

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frm1.frm4.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm1.frm5.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frm1.frm6.Show();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frm1.frm7.Show();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frm1.frm8.Show();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frm1.frm9.Show();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            frm1.frm10.Show();

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            frm1.frm11.Show();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            frm1.frm12.Show();

        }

        
    }
}
