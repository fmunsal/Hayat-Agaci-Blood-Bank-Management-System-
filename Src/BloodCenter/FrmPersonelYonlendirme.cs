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
    public partial class FrmPersonelYonlendirme : Form
    {
        public FrmPersonelYonlendirme()
        {
            InitializeComponent();
        }

        private void pbHastane_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            
        }

        private void pbKanMerkezi_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pbHastane_MouseClick(object sender, MouseEventArgs e)
        {
            FrmHastaneGiris fo = new FrmHastaneGiris();
            fo.Show();
            this.Hide();
        }

        private void pbKanMerkezi_MouseClick(object sender, MouseEventArgs e)
        {
            FrmKanMerkeziGiris f = new FrmKanMerkeziGiris();
            f.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmIlkEkran fo = new FrmIlkEkran();
            fo.Show();
            this.Hide();
        }
    }
}
