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

namespace Hastane_Projesi
{
    public partial class Frm_DoktorGiriş : Form
    {
        public Frm_DoktorGiriş()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSıfre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Frm_DoktorDetay frm = new Frm_DoktorDetay();
                frm.tc = msktc.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglantı().Close();
        }
    }
}
