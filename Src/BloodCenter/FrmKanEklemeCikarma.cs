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
    public partial class FrmKanEklemeCikarma : Form
    {
        string cinsiyet;
        string userId;
        public FrmKanEklemeCikarma()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        public void clear()
        {
            txtTC.Clear();
            txtIsim.Clear();
            txtSoyisim.Clear();
            dtpDogum.Value=DateTime.Now;
            dtpkayit.Value =DateTime.Now;
            rbErkek.Checked = false;
            rbKadin.Checked = false;
            cbKanG.Items.Clear();
            mtCeptel.Clear();
            mtEvtel.Clear();
            txtBoy.Clear();
            txtKilo.Clear();
            txtYas.Clear();
            textBox7.Clear();
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
            con.Open();
            SqlCommand komut = new SqlCommand("insert into Donor (TC,Isim,Soyisim,KayitTarihi,Cinsiyet,cepTel,evTel,DogumT,boy,kilo,yas,kanG,EvAdres,Hastane) values('" + txtTC.Text + "','" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + dtpkayit.Value.ToString("yyyy-MM-dd")+ "','" + cinsiyet + "','" + mtCeptel.Text + "','" + mtEvtel.Text + "','" + dtpDogum.Value.ToString("yyyy-MM-dd") + "','" + txtBoy.Text + "','" + txtKilo.Text + "','" + txtYas.Text + "','"+cbKanG.Text+"','"+textBox7.Text+ "','" + label15.Text + "')", con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Donor Kaydi Yapildi.");
            clear();
            
            
        }

        private void FrmKanEklemeCikarma_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", con);
            SqlDataReader reader = komut.ExecuteReader();
            reader.Read();

            label15.Text = reader["CalistigiYer"].ToString().Trim();



            con.Close();
        }
    }
}
