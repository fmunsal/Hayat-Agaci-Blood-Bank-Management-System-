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
    public partial class FrmKanIstek : Form
    {
        public FrmKanIstek()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string userId;
        
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        private void verilergoster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Hasta where Hastane like '%"+label2.Text+"%'", con);
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
            con.Close();

        }
        private void FrmKanIstek_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", con);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            lblyer.Text = reader["CalistigiYer"].ToString().Trim();
            con.Close();
            con.Open();
            SqlCommand komut1 = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", con);
            SqlDataReader reader1 = komut.ExecuteReader();
            reader1.Read();
            label2.Text = reader1["CalistigiYer"].ToString().Trim();
            con.Close();
            verilergoster();
             
            
        }

        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIlceler.Enabled = true;
            string sehir = cbIller.Text;
            string ilce = cbIlceler.Text;

            if (sehir == "Istanbul")
            {
  
                cbIlceler.Items.Clear();
                cbIlceler.Items.Add("Başakşehir");
                cbIlceler.Items.Add("Beşiktaş");
                cbIlceler.Items.Add("Beykoz");
                cbIlceler.Items.Add("Beylikdüzü");
                cbIlceler.Items.Add("Beyoğlu");

            }
            else if (sehir == "Ankara")
            {
               


                cbIlceler.Items.Clear();
                cbIlceler.Items.Add("Keçiören");
                cbIlceler.Items.Add("Sıhhıye");
                cbIlceler.Items.Add("Çankaya");
                cbIlceler.Items.Add("Mamak");

            }
            else if (sehir == "Izmir")
            {

                cbIlceler.Items.Clear();
                cbIlceler.Items.Add("Bornova");
                cbIlceler.Items.Add("Buca");
                

            }

        }

        private void btnKanIste_Click(object sender, EventArgs e)
        {
            con.Open();
            if (lblAd.Text == "ad"|| lblkang.Text == "kangrubu" || lblsoyad.Text == "soyad")
            {
                MessageBox.Show("Secim islemi gerceklesmedi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into AcilKan (HastaId,Sehir,Ilce,Isim,Soyisim,IstenilenKan,IslemTarihi,IstekDurumu,GonderilenYer) values('" + Hasta1Id.ToString() + "','" + cbIller.Text + "','" + cbIlceler.Text + "','" + lblAd.Text + "','" + lblsoyad.Text + "','" + lblkang.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + lblBekle.Text + "','" + lblyer.Text + "')", con);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kan Istegi Gonderildi");
            }
            
            con.Close();  
            
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        //private void listView1_DoubleClick(object sender, EventArgs e)
        //{
        //    Hasta1Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text.Trim());
        //    lblAd.Text = listView1.SelectedItems[0].SubItems[1].Text.Trim();
        //    lblkang.Text = listView1.SelectedItems[0].SubItems[2].Text.Trim();
        //    lblsoyad.Text = listView1.SelectedItems[0].SubItems[3].Text.Trim();

        //}

        //private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    Hasta1Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text.Trim());
        //    lblAd.Text = listView1.SelectedItems[0].SubItems[1].Text.Trim();
        //    lblkang.Text = listView1.SelectedItems[0].SubItems[2].Text.Trim();
        //    lblsoyad.Text = listView1.SelectedItems[0].SubItems[3].Text.Trim();

        //}
        int Hasta1Id = 0;
        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            Hasta1Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text.Trim());
            lblAd.Text = listView1.SelectedItems[0].SubItems[2].Text.Trim();
            lblsoyad.Text = listView1.SelectedItems[0].SubItems[3].Text.Trim();
            lblkang.Text = listView1.SelectedItems[0].SubItems[4].Text.Trim();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbIller_MouseClick(object sender, MouseEventArgs e)
        {
            cbIlceler.Text = "";
        }

        private void cbIlceler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
