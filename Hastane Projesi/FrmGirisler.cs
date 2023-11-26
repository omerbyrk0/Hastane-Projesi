using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void btn_hastagiriş_Click(object sender, EventArgs e)
        {
            Frm_HastaGiris frm = new Frm_HastaGiris();
            frm.Show();
            this.Hide();
        }

        private void btn_doktorgiriş_Click(object sender, EventArgs e)
        {
            Frm_DoktorGiriş frm = new Frm_DoktorGiriş();
            frm.Show();
            this.Hide();
        }

        private void btn_sekretergiriş_Click(object sender, EventArgs e)
        {
            Frm_SekreterGiriş frm = new Frm_SekreterGiriş();
            frm.Show();
            this.Hide();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
