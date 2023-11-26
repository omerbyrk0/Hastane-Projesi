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
    public partial class Frm_HastaBilgiDüzenle : Form
    {
        public Frm_HastaBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string Tcno;
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_HastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = Tcno;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txt_sifre.Text = dr[5].ToString();
                combocinsiyet.Text = dr[6].ToString();
            }
            bgl.baglantı().Close();
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p3,HastaSıfre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglantı());
            komut2.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3",msktel.Text);
            komut2.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut2.Parameters.AddWithValue("@p5", combocinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Bilgileriniz Güncellendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
