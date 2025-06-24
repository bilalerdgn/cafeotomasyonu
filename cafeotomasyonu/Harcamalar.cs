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
    public partial class Harcamalar : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");

        public Harcamalar()
        {
            InitializeComponent();
        }

        private void Harcamalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string bagcek = "Select * from Gider";
            OleDbCommand komut = new OleDbCommand(bagcek, baglanti);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable masa = new DataTable();
            adap.Fill(masa);
            harcama.DataSource = masa;
            baglanti.Close();

            int toplamtutar = 0;
            for (int i = 0; i < harcama.Rows.Count; ++i)
            {
                toplamtutar += Convert.ToInt32(harcama.Rows[i].Cells[2].Value);
            }
            labeltoptut.Text = toplamtutar.ToString() + "  ₺";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string arama = "Select * from Gider where Tarih=@tarih ";
            OleDbCommand komut = new OleDbCommand(arama, baglanti);
            komut.Parameters.AddWithValue("@tarih", mtboxtarihara.Text);
            OleDbDataAdapter adap = new OleDbDataAdapter(komut);
            DataTable masa = new DataTable();
            adap.Fill(masa);
            harcama.DataSource = masa;
            baglanti.Close();
        }
        

       
    }
}
