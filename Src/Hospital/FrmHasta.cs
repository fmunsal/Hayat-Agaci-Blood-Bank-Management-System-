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
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string cinsiyet;
        private void FrmHasta_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", baglanti);
            SqlDataReader reader1 = komut1.ExecuteReader();
            reader1.Read();

            label14.Text = reader1["CalistigiYer"].ToString().Trim();
            baglanti.Close();
        }
        string userId;
        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string tc;
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

            
            try
            {
                baglanti.Open();
                //SqlCommand cmd = new SqlCommand("select * from Hasta where TC ='"+txtTC.Text+"'", baglanti);
                //SqlDataReader reader = cmd.ExecuteReader();
                //while(reader.Read())
                //{
                //    tc = reader["TC"].ToString().Trim();
                //    if (tc == txtTC.Text || tc == "NULL")
                //    {
                //        MessageBox.Show("Bu kimlik numarasina ait \nbir kayit mevcuttur");
                //    }
                //    else
                //    {
                        SqlCommand komut = new SqlCommand("insert into Hasta (TC,isim,soyisim,cinsiyet,DogumTarihi,DogumYeri,Cep,Hastalik,KanGrubu,boy,kilo,YatisTarihi,Hastane) values('" + txtTC.Text + "','" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + cinsiyet + "','" + dtpDogumT.Value.ToString("yyyy-MM-dd") + "','" + cbDogumY.Text + "','" + txtCep.Text + "','" + txtHastalik.Text + "','" + cbKanG.Text + "','" + txtBoy.Text + "','" + txtKilo.Text + "','" + dtpYatisT.Value.ToString("yyyy-MM-dd") + "','" + label14.Text + "')", baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Hasta Kaydedildi.");
                //    }
                //}
               
                baglanti.Close();
                
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
