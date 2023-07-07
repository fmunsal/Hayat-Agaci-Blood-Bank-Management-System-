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
    public partial class FrmKanBHastaneIstek : Form
    {
        public FrmKanBHastaneIstek()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string akanuserId;
        private void verilergoster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from AcilKan where Ilce like '%"+label2.Text+"%' ", con);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["HastaId"].ToString());

                
                ekle.SubItems.Add(oku["Isim"].ToString());
                ekle.SubItems.Add(oku["Soyisim"].ToString());
                ekle.SubItems.Add(oku["IstenilenKan"].ToString());
                ekle.SubItems.Add(oku["IslemTarihi"].ToString());
                ekle.SubItems.Add(oku["IstekDurumu"].ToString());
                ekle.SubItems.Add(oku["GonderilenYer"].ToString());
     
                listView1.Items.Add(ekle);
            }
            con.Close();

        }
        public void aSetUserId(string userId)
        {
            this.akanuserId = userId;
        }

        private void FrmKanBHastaneIstek_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut1 = new SqlCommand("select * from KanmPersonel where PersonelId='" + akanuserId + "'", con);
            SqlDataReader reader1 = komut1.ExecuteReader();
            reader1.Read();
            label2.Text = reader1["CalistigiYer"].ToString().Trim();
            con.Close();
            verilergoster();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from KanmPersonel where PersonelId='" + akanuserId + "'", con);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            lblkanmerkez.Text = reader["CalistigiYer"].ToString().Trim();
            con.Close();
        }
        int id = 0;


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            lblId.Text = listView1.SelectedItems[0].SubItems[0].Text.Trim();
            lblHastaId.Text = listView1.SelectedItems[0].SubItems[1].Text.Trim();
            lblIsim.Text = listView1.SelectedItems[0].SubItems[2].Text.Trim();
            lblSoyisim.Text = listView1.SelectedItems[0].SubItems[3].Text.Trim();
            lblKan.Text = listView1.SelectedItems[0].SubItems[4].Text.Trim();
            lblTarih.Text = listView1.SelectedItems[0].SubItems[5].Text.Trim();
            lblDurum.Text = listView1.SelectedItems[0].SubItems[6].Text.Trim();
            lblHastane.Text = listView1.SelectedItems[0].SubItems[7].Text.Trim();

            if (lblDurum.Text == "Iptal Edildi" || lblDurum.Text == "Gonderildi")
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("update AcilKan set IstekDurumu='" + lblgon.Text.ToString() + "' where HastaId= " + lblHastaId.Text.ToString() + "", con);
            com.ExecuteNonQuery();
            
            SqlCommand com2 = new SqlCommand("insert into KanMerkeziGecmis (HastaId,Isim,Soyisim,IstenilenKan,IslemTarihi,IslemDurumu,KanMerkezi) values ('" + lblHastaId.Text + "','" + lblIsim.Text + "','"+lblSoyisim.Text+ "','" + lblKan.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','"+lblgon.Text+ "','" + lblkanmerkez.Text + "')");
            
            com2.Connection = con;
            com2.ExecuteNonQuery();
            con.Close();
            verilergoster();
            MessageBox.Show("Gonderildi bilgisi kaydedildi.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
