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
    public partial class FrmKanmDetaylar : Form
    {
        public FrmKanmDetaylar()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        string kang;
        int count0e, count0a, countAe, countAa, countBa, countBe, countABa, countABe = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string akanuserId;
        public void aSetUserId(string userId)
        {
            this.akanuserId = userId;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand komut = new SqlCommand("Select * from kanmDonor where TC like '%" + textBox1.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showveri("Select * from kanmDonor where KanMerkezi like '%" + label22.Text + "%' ");
        }

        private void FrmKanmDetaylar_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut1 = new SqlCommand("select * from KanmPersonel where PersonelId='" + akanuserId + "'", con);
            SqlDataReader reader1 = komut1.ExecuteReader();
            reader1.Read();

            label22.Text = reader1["CalistigiYer"].ToString().Trim();
            con.Close();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from KanmDonor where KanMerkezi like '%"+label22.Text+"%'", con);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                kang = reader["kanG"].ToString().Trim();
                if (kang == "0 +")
                {
                    count0a++;

                }
                else if (kang == "0 -")
                {
                    count0e++;
                }
                else if (kang == "A +")
                {
                    countAa++;
                }
                else if (kang == "A -")
                {
                    countAe++;
                }
                else if (kang == "B +")
                {
                    countBa++;
                }
                else if (kang == "B -")
                {
                    countBe++;
                }
                else if (kang == "AB +")
                {
                    countABa++;
                }
                else if (kang == "AB -")
                {
                    countABe++;
                }
            }
            con.Close();
            con.Open();
            string kann = "";

            SqlCommand cmd = new SqlCommand("select * from AcilKan where IstekDurumu='Gonderildi'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                kann = read["IstenilenKan"].ToString().Trim();
                if (kann == "0 +")
                {
                    if (count0a>0)
                    {
                        count0a--;
                    }
                   
                }
                else if (kann == "0 -")
                {
                    if (count0e > 0)
                    {
                        count0e--;
                    }
                }
                else if (kann == "A +")
                {
                    if (countAa > 0)
                    {
                        countAa--;
                    }
                }
                else if (kann == "A -")
                {
                    if (countAe > 0)
                    {
                        countAe--;
                    }
                }
                else if (kann == "B +")
                {
                    if (countBa > 0)
                    {
                        countBa--;
                    }
                }
                else if (kann == "B -")
                {
                    if (countBe > 0)
                    {
                        countBe--;
                    }
                }
                else if (kann == "AB +")
                {
                    if (countABa > 0)
                    {
                        countABa--;
                    }
                }
                else if (kann == "AB -")
                {
                    if (countABe > 0)
                    {
                        countABe--;
                    }
                }
            }


            con.Close();
            label14.Text = count0a.ToString();
            label15.Text = count0e.ToString();
            label17.Text = countAa.ToString();
            label16.Text = countAe.ToString();
            label19.Text = countBa.ToString();
            label18.Text = countBe.ToString();
            label21.Text = countABa.ToString();
            label20.Text = countABe.ToString();

            
        }

        public void showveri(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
