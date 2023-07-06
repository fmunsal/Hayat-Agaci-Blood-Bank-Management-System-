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
using System.Text.RegularExpressions;

namespace hayatagaci
{
    public partial class FrmHasAdminPersonel : Form
    {
        public FrmHasAdminPersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        public void Temizler()
        {
            txtEmail.Clear();
            txtSifre.Clear();
            txtIsim.Clear();
            txtSoyisim.Clear();
            cbIller.Text = "";
            cbHastane.Text = "";
            txtCep.Clear();
            txtTC.Clear();


        }
        private void FrmHasAdminPersonel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Personel (Email,Sifre,Isim,Soyisim,CalistigiYer,Sehir,CepTel,TC) values('" + txtEmail.Text + "','" + txtSifre.Text + "','" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + cbHastane.Text.ToString() + "','" + cbIller.Text.ToString() + "','" + txtCep.Text + "','" + txtTC.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Kaydi Yapildi.");
            }

            else
            {
                MessageBox.Show("Gecerli Mail Adresi Girin");
            }
            Temizler();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalistigiYer_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHastane.Enabled = true;
            string sehir = cbIller.Text;
            string ilce = cbHastane.Text;

            if (sehir == "Istanbul")
            {

                cbHastane.Items.Clear();
                cbHastane.Items.Add("Başakşehir Devlet Hastanesi");
                cbHastane.Items.Add("Beşiktaş Devlet Hastanesi");
                cbHastane.Items.Add("Beykoz Devlet Hastanesi");
                cbHastane.Items.Add("Beylikdüzü Devlet Hastanesi");
                cbHastane.Items.Add("Beyoğlu Devlet Hastanesi");

            }
            else if (sehir == "Ankara")
            {



                cbHastane.Items.Clear();
                cbHastane.Items.Add("Keçiören Devlet Hastanesi");
                cbHastane.Items.Add("Sıhhıye Devlet Hastanesi");
                cbHastane.Items.Add("Çankaya Devlet Hastanesi");
                cbHastane.Items.Add("Mamak Devlet Hastanesi");

            }
            else if (sehir == "Izmir")
            {

                cbHastane.Items.Clear();
                cbHastane.Items.Add("Bornova Devlet Hastanesi");
                cbHastane.Items.Add("Buca Devlet Hastanesi");


            }

        }

        private void cbIller_MouseClick(object sender, MouseEventArgs e)
        {
            cbHastane.Text = "";
        }
    }
}
