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
using System.Drawing;

namespace hayatagaci
{
    public partial class FrmHastaneGiris : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string userId;
        public FrmHastaneGiris()
        {
            InitializeComponent();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.FromArgb(255, 241, 242);
            textBox2.BackColor = Color.FromArgb(255, 241, 242);
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = Color.FromArgb(255, 241, 242);
            textBox1.BackColor = Color.FromArgb(255, 241, 242);
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string user = textBox1.Text, password = textBox2.Text;

            SqlCommand com = new SqlCommand();
            com.Connection = baglanti;
            com.CommandText = "Select * from Personel where Email = '" + user + "'and Sifre= '" + password + "'";
            SqlDataReader dr = com.ExecuteReader();

            try
            {
               
                
                if (dr.Read())
                {
                    userId = dr["PersonelId"].ToString();
                    FrmHastaneOtomasyon fhm = new FrmHastaneOtomasyon();
                    fhm.SetUserId(userId);
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
            if (user == "admin" && password == "12345" )
            {
                MessageBox.Show("Hosgeldiniz Admin");
                FrmHastaneAdmin fha = new FrmHastaneAdmin();
                fha.Show();
                this.Hide();
            }
            else
            {

            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.FromArgb(255, 241, 242);
            textBox2.BackColor = Color.FromArgb(255, 241, 242);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = Color.FromArgb(255, 241, 242);
            textBox1.BackColor = Color.FromArgb(255, 241, 242);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmPersonelYonlendirme frmpersonel = new FrmPersonelYonlendirme();
            frmpersonel.Show();

            this.Hide();
        }
    }
}
//Data Source=DESKTOP-MUGQQHN;Initial Catalog=hayatagaci;Integrated Security=True