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
        
    public partial class Menu : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");
        DataTable tablo = new DataTable();  // tablo isiminde bir Datatable tanımladık.
        OleDbCommand komut = new OleDbCommand();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string tikla;

            if (rdcorba.Checked == true)
            {
                tikla = "Insert into corba(corbalar)values(@ad)";
                OleDbCommand komut = new OleDbCommand(tikla, baglanti);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);

                komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.           
                MessageBox.Show("Kaydedildi");
                textBox1.Clear();
            }

            if (rdtatlı.Checked == true)
            {
                tikla = "Insert into tatlı(tatli)values(@ad)";
                OleDbCommand komut = new OleDbCommand(tikla, baglanti);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);

                komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.           
                MessageBox.Show("Kaydedildi");
            }

            if (rdkebap.Checked == true)
            {
                tikla = "Insert into kebap(kebaplar)values(@ad)";
                OleDbCommand komut = new OleDbCommand(tikla, baglanti);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);

                komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.           
                MessageBox.Show("Kaydedildi");
                textBox1.Clear();
            }
            if(rdpide.Checked==true)
            {
                tikla = "Insert into pide(pide_lahmacun)values(@ad)";
                OleDbCommand komut = new OleDbCommand(tikla, baglanti);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.ExecuteNonQuery(); //değerleri geri döndürüp veri tabanına kaydeder.           
                MessageBox.Show("Kaydedildi");
                textBox1.Clear();
            }
            
            

            baglanti.Close();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
