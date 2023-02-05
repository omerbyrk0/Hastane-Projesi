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
    public partial class Frm__DokorBilgiDüzenle : Form
    {
        public Frm__DokorBilgiDüzenle()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();
        public string tc;

        private void Frm__DokorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tc;

            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where doktortc = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                cmb_branş.Text = dr[3].ToString();
                txt_sifre.Text = dr[5].ToString();
            }

        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBranş=@p3,DoktorSıfre=@p4 where DoktorTc=@p5", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_branş.Text);
            komut.Parameters.AddWithValue("@p4",txt_sifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
