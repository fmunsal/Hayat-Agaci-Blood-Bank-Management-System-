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
    public partial class FrmGecmis : Form
    {
        public FrmGecmis()
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
            SqlCommand komut = new SqlCommand("select * from AcilKan where GonderilenYer like '%"+label1.Text+"%'", con);
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
                

                listView1.Items.Add(ekle);
            }
            con.Close();

        }

        private void FrmGecmis_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", con);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            label1.Text = reader["CalistigiYer"].ToString().Trim();
            con.Close();
            verilergoster();
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
            con.Open();
            SqlCommand com = new SqlCommand("update AcilKan set IstekDurumu='" + lbliptal.Text.ToString() + "' where HastaId= " + lblHastaId.Text.ToString() + "", con);
            com.ExecuteNonQuery();
            con.Close();
            verilergoster();
            MessageBox.Show("Iptal edilme onaylandi");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
