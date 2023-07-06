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
    public partial class FrmKanMBagisAl : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        public FrmKanMBagisAl()
        {
            InitializeComponent();
        }
        string cinsiyet;
        string akanuserId;
        public void aSetUserId(string userId)
        {
            this.akanuserId = userId;
        }
        public void clear()
        {
            txtTC.Clear();
            txtIsim.Clear();
            txtSoyisim.Clear();
            dtpDogum.Value = DateTime.Now;
            dtpkayit.Value = DateTime.Now;
            rbErkek.Checked = false;
            rbKadin.Checked = false;
            cbKanG.Text = " ";
            mtCeptel.Clear();
            mtEvtel.Clear();
            txtBoy.Clear();
            txtKilo.Clear();
            txtYas.Clear();
            textBox7.Clear();
        }
        private void FrmKanMBagisAl_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KanmPersonel where PersonelId='" + akanuserId + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();

            label15.Text = reader["CalistigiYer"].ToString().Trim();



            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadin";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kanmDonor (TC,Isim,Soyisim,KayitTarihi,Cinsiyet,cepTel,evTel,DogumT,boy,kilo,yas,kanG,EvAdres,KanMerkezi) values('" + txtTC.Text + "','" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + dtpkayit.Value.ToString("yyyy-MM-dd") + "','" + cinsiyet + "','" + mtCeptel.Text + "','" + mtEvtel.Text + "','" + dtpDogum.Value.ToString("yyyy-MM-dd") + "','" + txtBoy.Text + "','" + txtKilo.Text + "','" + txtYas.Text + "','" + cbKanG.Text + "','" + textBox7.Text + "','" + label15.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Donor Kaydi Yapildi.");
            clear();
        }
    }
}
