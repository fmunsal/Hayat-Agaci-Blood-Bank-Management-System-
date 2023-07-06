using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hayatagaci
{
    public partial class FrmHastaListesi : Form
    {
        public FrmHastaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string userId;
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Hasta where Hastane like  '%"+label8.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["HastaId"].ToString();
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["soyisim"].ToString());
                ekle.SubItems.Add(oku["KanGrubu"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Cep"].ToString());
                ekle.SubItems.Add(oku["DogumTarihi"].ToString());
                ekle.SubItems.Add(oku["YatisTarihi"].ToString());
                ekle.SubItems.Add(oku["Hastalik"].ToString());
                ekle.SubItems.Add(oku["DogumYeri"].ToString());             
                ekle.SubItems.Add(oku["boy"].ToString());
                ekle.SubItems.Add(oku["kilo"].ToString());
                
                
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            
        }

        private void btnListeyiGoster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void FrmHastaListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Personel where PersonelId='" + userId + "'",baglanti);
            SqlDataReader reader1 = komut1.ExecuteReader();
            reader1.Read();

            label8.Text = reader1["CalistigiYer"].ToString().Trim();
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Hasta where TC like '%" + textBox4.Text + "' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["HastaId"].ToString();
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["soyisim"].ToString());
                ekle.SubItems.Add(oku["KanGrubu"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Cep"].ToString());
                ekle.SubItems.Add(oku["DogumTarihi"].ToString());
                ekle.SubItems.Add(oku["YatisTarihi"].ToString());
                ekle.SubItems.Add(oku["Hastalik"].ToString());
                ekle.SubItems.Add(oku["DogumYeri"].ToString());
                ekle.SubItems.Add(oku["boy"].ToString());
                ekle.SubItems.Add(oku["kilo"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;
        private void btnCikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Hasta where HastaId = (" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            label24.Text = listView1.SelectedItems[0].SubItems[0].Text;
            label25.Text = listView1.SelectedItems[0].SubItems[1].Text;
            label26.Text = listView1.SelectedItems[0].SubItems[2].Text;
            label27.Text = listView1.SelectedItems[0].SubItems[3].Text;
            label28.Text = listView1.SelectedItems[0].SubItems[4].Text;
            label29.Text = listView1.SelectedItems[0].SubItems[5].Text;
            label30.Text = listView1.SelectedItems[0].SubItems[6].Text;
            label31.Text = listView1.SelectedItems[0].SubItems[7].Text;
            label32.Text = listView1.SelectedItems[0].SubItems[8].Text;
            label33.Text = listView1.SelectedItems[0].SubItems[9].Text;
            label34.Text = listView1.SelectedItems[0].SubItems[10].Text;
            label35.Text = listView1.SelectedItems[0].SubItems[11].Text;
            label36.Text = listView1.SelectedItems[0].SubItems[12].Text;
        }
    }
}
