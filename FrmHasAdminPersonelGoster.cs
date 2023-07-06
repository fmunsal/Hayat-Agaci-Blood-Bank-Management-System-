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
    public partial class FrmHasAdminPersonelGoster : Form
    {
        public FrmHasAdminPersonelGoster()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridView1);
        }
        SqlConnection con = new SqlConnection(@"Data Source=MONSTER-YUSUF\SQLEXPRESS;Initial Catalog=HayatAgaci;Integrated Security=True");
        public void showveri(string veriler)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void FrmHasAdminPersonelGoster_Load(object sender, EventArgs e)
        {
            showveri("Select * from Personel");



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select * from Personel where TC like '%" + textBox1.Text + "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
