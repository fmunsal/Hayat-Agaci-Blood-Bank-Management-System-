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
    public partial class FrmHastaneAdmin : Form
    {
        public FrmHastaneAdmin()
        {
            InitializeComponent();
        }
        public void form(object Form)//son formu yuklemek icin c class bak
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

        private void btnKanEkle_Click(object sender, EventArgs e)
        {
            form(new FrmHasAdminPersonelGoster());
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            form(new FrmHasAdminPersonel());
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmHastaneGiris hastanegiris = new FrmHastaneGiris();
            hastanegiris.Show();
            this.Hide();
        }
    }
}
