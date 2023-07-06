using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace hayatagaci
{
    public partial class FrmHastaneOtomasyon : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string userId;
        public FrmHastaneOtomasyon()
        {
            InitializeComponent();

        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count>0)
            {
                this.mainpanel.Controls.RemoveAt(0);

            }
            Form f = Form as Form;
         
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmHastaneOtomasyon_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            label1.Text = "|"+reader["Sehir"].ToString().Trim();
            label2.Text = "|" + reader["CalistigiYer"].ToString().Trim();
            label3.Text = "|" + reader["Isim"].ToString().Trim() + " " + reader["Soyisim"].ToString().Trim();


            baglanti.Close();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            //loadform(new FrmAnasayfa());
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKanEkle_Click(object sender, EventArgs e)
        {
            FrmKanEklemeCikarma f =new FrmKanEklemeCikarma();
            f.SetUserId(userId);
            loadform(f);
        }

        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            FrmKanDetaylar f = new FrmKanDetaylar();
            f.SetUserId(userId);
            loadform(f);
        }

        private void btnKanIstek_Click(object sender, EventArgs e)
        {
            FrmKanIstek f = new FrmKanIstek();
            f.SetUserId(userId);
            loadform(f) ;
           
        }

        private void btnKanKontrol_Click(object sender, EventArgs e)
        {

            loadform(new FrmHasta());
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            FrmGecmis f = new FrmGecmis();
            f.SetUserId(userId);
            loadform(f);
            
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHasta f = new FrmHasta();
            f.SetUserId(userId);
            loadform(f);
            
        }

        private void btnHastaListesi_Click(object sender, EventArgs e)
        {
            FrmHastaListesi f = new FrmHastaListesi();
            f.SetUserId(userId);
            loadform(f);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmHastaneGiris frmhastanegiris = new FrmHastaneGiris();
            frmhastanegiris.Show();

            this.Hide();
        }
    }
}
