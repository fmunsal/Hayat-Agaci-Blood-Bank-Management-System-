using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayatagaci
{
    public partial class FrmKanMerAdmin : Form
    {
        public FrmKanMerAdmin()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
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

        private void btnKanKanEkle_Click(object sender, EventArgs e)
        {
            FrmKanMerAdminPersonelGoster f = new FrmKanMerAdminPersonelGoster();
            loadform(f);
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKanDetaylar_Click(object sender, EventArgs e)
        {
            FrmKanMerAdminPersonel f = new FrmKanMerAdminPersonel();

            loadform(f);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKanMerkeziGiris merkezgisi = new FrmKanMerkeziGiris();
            merkezgisi.Show();

            this.Hide();
        }
    }
}
