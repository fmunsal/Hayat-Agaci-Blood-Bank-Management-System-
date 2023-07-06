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
    public partial class FrmKanMerkeziGiris : Form
    {
        public FrmKanMerkeziGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string kanuserId ;
        
        private void btnKapatma_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKanGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string user = textBox1.Text, password = textBox2.Text;

            SqlCommand com = new SqlCommand();
            com.Connection = baglanti;
            com.CommandText = "Select * from KanmPersonel where Email = '" + user + "'and Sifre= '" + password + "'";
            SqlDataReader dr = com.ExecuteReader();

            try
            {


                if (dr.Read())
                {
                    kanuserId = dr["PersonelId"].ToString();
                    FrmKanMerkeziOtomasyon fhm = new FrmKanMerkeziOtomasyon();
                    fhm.aSetUserId(kanuserId);
                    fhm.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Hatali giris yaptiniz");
                throw;
            }
            baglanti.Close();
            if (user == "admin" && password == "12345")
            {
                MessageBox.Show("Hosgeldiniz Admin");
                FrmKanMerAdmin fha = new FrmKanMerAdmin();
                fha.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.Azure;
            textBox2.BackColor = Color.Azure;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = Color.Azure;
            textBox1.BackColor = Color.Azure;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.Azure;
            textBox2.BackColor = Color.Azure;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = Color.Azure;
            textBox1.BackColor = Color.Azure;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmPersonelYonlendirme frmyonlendirme = new FrmPersonelYonlendirme();
            frmyonlendirme.Show();

            this.Hide();
        }
    }
}
