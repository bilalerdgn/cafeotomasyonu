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
    public partial class Gelirgider : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\kafeotomasyonu.mdb");

        DataTable gidertablo = new DataTable();
        public Gelirgider()
        {
            InitializeComponent();
        }

        private void Gelirgider_Load(object sender, EventArgs e)
        {
            //Gider Ekle Formu tab kontrol
            tboxsayi.TabIndex = 0;
            tboxgider.TabIndex = 1;
            tboxtutar.TabIndex = 2;
            mtboxtarih.TabIndex = 3;
            btngiderekle.TabIndex = 4;
            btnsil.TabIndex = 5;

            btngerii.TabIndex = 9;
            DataGridView1.TabIndex = 10;

            {
                gidertablo.Columns.Add("SIRA", typeof(int));
                gidertablo.Columns.Add("GİDER", typeof(string));
                gidertablo.Columns.Add("TUTAR", typeof(int));
                gidertablo.Columns.Add("TARİH", typeof(DateTime));
                DataGridView1.DataSource = gidertablo;

            }   
        }

        private void btngiderekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            gidertablo.Rows.Add(tboxsayi.Text, tboxgider.Text, tboxtutar.Text, mtboxtarih.Text);
            DataGridView1.DataSource = gidertablo;



            OleDbCommand komut = new OleDbCommand("Insert into Gider(Sira,Gider,Tutar,Tarih)values (@sira,@gider,@tutar,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@sira", tboxsayi.Text);
            komut.Parameters.AddWithValue("@gider", tboxgider.Text);
            komut.Parameters.AddWithValue("@tutar", tboxtutar.Text);
            komut.Parameters.AddWithValue("@tarih", mtboxtarih.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
          

            tboxsayi.Clear();
            tboxgider.Clear();
            tboxtutar.Clear();
            mtboxtarih.Clear();
                   
        }

        private void btngerii_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnharcamalarıgor_Click(object sender, EventArgs e)
        {
            Harcamalar fhg = new Harcamalar();
            fhg.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Satır Silmek için Lütfen Satırı Seçiniz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
