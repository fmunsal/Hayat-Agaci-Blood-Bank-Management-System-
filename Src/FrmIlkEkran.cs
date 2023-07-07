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
    public partial class FrmIlkEkran : Form
    {
        
        public FrmIlkEkran()
        {
            InitializeComponent();
        }

        private void pbPersonel_Click(object sender, EventArgs e)
        {
            //FrmHastaneGiris fo = new FrmHastaneGiris();
            //fo.Show();
            //this.Hide();
        }

        private void btnKapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPersonel_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pbPersonel_MouseClick(object sender, MouseEventArgs e)
        {
            FrmPersonelYonlendirme fo = new FrmPersonelYonlendirme();
            fo.Show();
            this.Hide();
        }
    }
}
