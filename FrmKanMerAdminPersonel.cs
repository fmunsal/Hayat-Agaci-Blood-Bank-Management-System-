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
    public partial class FrmKanMerAdminPersonel : Form
    {
        public FrmKanMerAdminPersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into KanmPersonel (Email,Sifre,Isim,Soyisim,CalistigiYer,Sehir,CepTel,TC) values('" + txtEmail.Text + "','" + txtSifre.Text + "','" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + cbIlceler.Text + "','" + cbIller.Text + "','" + txtCep.Text + "','" + txtTC + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Kaydi Yapildi.");
            }

            else
            {
                MessageBox.Show("Gecerli Mail Adresi Girin");
            }
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

        private void cbIller_MouseClick(object sender, MouseEventArgs e)
        {
            cbIlceler.Text = "";
        }
    }
}
