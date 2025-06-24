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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGarson_Click(object sender, EventArgs e)
        {
            GarsonKullaniciGirisi grsn = new GarsonKullaniciGirisi();
            grsn.ShowDialog();            
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            YoneticiKullaniciGirisi yntc = new YoneticiKullaniciGirisi();
            yntc.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult dialog = MessageBox.Show("Programı Kapatmak İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            musterigiris mstr = new musterigiris();
            mstr.ShowDialog();
        }
    }
}
