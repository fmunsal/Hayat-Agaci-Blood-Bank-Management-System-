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
    public partial class FrmKanMerkeziOtomasyon : Form
    {
        public FrmKanMerkeziOtomasyon()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string akanuserId;
        public void bloodloadform(object Form)//son formu yuklemek icin c class bak
        {
            if (this.mainpanel.Controls.Count > 0)
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
        public void aSetUserId(string userId)
        {
            this.akanuserId = userId;
        }
        private void btnKapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaneIstek_Click(object sender, EventArgs e)
        {
            FrmKanBHastaneIstek f = new FrmKanBHastaneIstek();
            f.aSetUserId(akanuserId);
            bloodloadform(f);
        }

        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            FrmKanmDetaylar f = new FrmKanmDetaylar();
            f.aSetUserId(akanuserId);
            bloodloadform(f);
        }

        private void btnKanEkle_Click(object sender, EventArgs e)
        {
            FrmKanMBagisAl f = new FrmKanMBagisAl();
            f.aSetUserId(akanuserId);
            bloodloadform(f);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
           // bloodloadform(new FrmKanAnasayfa());
        }

        private void btnKanGecmis_Click(object sender, EventArgs e)
        {
           // bloodloadform(new FrmKanGecmis());
        }

        private void FrmKanMerkeziOtomasyon_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KanmPersonel where PersonelId='" + akanuserId + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();
            label1.Text = "|" + reader["Sehir"].ToString().Trim();
            label2.Text = "|" + reader["CalistigiYer"].ToString().Trim();
            label3.Text = "|" + reader["Isim"].ToString().Trim() + " " + reader["Soyisim"].ToString().Trim();


            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKanMerkeziGiris frmkanmerkezigiris = new FrmKanMerkeziGiris();
            frmkanmerkezigiris.Show();

            this.Hide();

        }
    }
    }

