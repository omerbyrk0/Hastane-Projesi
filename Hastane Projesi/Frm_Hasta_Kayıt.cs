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
    public partial class Frm_Hasta_Kayıt : Form
    {
        public Frm_Hasta_Kayıt()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTc,HastaTel,HastaSıfre,HastaCinsiyet)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktel.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p6", combocinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz : " + txt_sifre.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
