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
    public partial class FrmKanDetaylar : Form
    {
        public FrmKanDetaylar()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridView1);
        }
        SqlConnection con = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        
        string kang;
        
        int count0e,count0a, countAe,countAa,countBa, countBe, countABa, countABe = 0;
        string userId;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SetUserId(string userId)
        {
            this.userId = userId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select * from Donor where TC like '%" + textBox1.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        public void showveri(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }
        public void DatagridviewSetting(DataGridView datagridview)
        {
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(190, 37, 58);
            datagridview.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            datagridview.DefaultCellStyle.SelectionForeColor = Color.White;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(190, 37, 58);
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showveri("Select * from Donor where Hastane like '%" + label22.Text + "%'");
        }

        private void FrmKanDetaylar_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut1 = new SqlCommand("select * from Personel where PersonelId='" + userId + "'", con);
            SqlDataReader reader1 = komut1.ExecuteReader();
            reader1.Read();

            label22.Text = reader1["CalistigiYer"].ToString().Trim(); 
            con.Close();

            con.Open();
            SqlCommand komut = new SqlCommand("select * from Donor where Hastane like  '%"+label22.Text+"%'", con);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                kang = reader["kanG"].ToString().Trim();
                if (kang == "0 +")
                {
                    count0a++;
                    
                }
                else if(kang == "0 -")
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
                    count0a++;

                }
                else if (kann == "0 -")
                {
                    count0e++;
                }
                else if (kann == "A +")
                {
                    countAa++;
                }
                else if (kann == "A -")
                {
                    countAe++;
                }
                else if (kann == "B +")
                {
                    countBa++;
                }
                else if (kann == "B -")
                {
                    countBe++;
                }
                else if (kann == "AB +")
                {
                    countABa++;
                }
                else if (kann == "AB -")
                {
                    countABe++;
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
    }
}
