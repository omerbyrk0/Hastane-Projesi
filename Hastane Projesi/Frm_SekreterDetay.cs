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
using System.Runtime.InteropServices;

namespace Hastane_Projesi
{
    public partial class Frm_SekreterDetay : Form
    {
        public Frm_SekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btn_brnşpanel_Click(object sender, EventArgs e)
        {
            Frm_BranşPaneli fr = new Frm_BranşPaneli();
            fr.Show();
        }

        private void Frm_SekreterDetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;
            SqlCommand komut1 = new SqlCommand("Select SekreterAdsoyad from Tbl_Sekreter where sekretertc =@p1", bgl.baglantı());
            komut1.Parameters.AddWithValue("@p1", lbl_tc.Text);

            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbl_adsoyad.Text = dr1[0].ToString();
            }
            bgl.baglantı().Close();

            //branşları çekme

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Branşlar", bgl.baglantı());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktorları çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' '+DoktorSoyad) as 'Doktorlar',DoktorBranş from Tbl_Doktorlar",bgl.baglantı());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşları combolara çekme
            SqlCommand komut = new SqlCommand("select BranşAd from Tbl_Branşlar", bgl.baglantı());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_branş.Items.Add(dr[0].ToString());
            }

            bgl.baglantı().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor)values (@r1,@r2,@r3,@r4)",bgl.baglantı());
            komutkaydet.Parameters.AddWithValue("@r1",msk_tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msk_saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmb_branş.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmb_doktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu Oluşturuldu...");

        }

        private void cmb_branş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBranş= @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", cmb_branş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_doktor.Items.Add(dr[0] + " " + dr[1]);
            }
        }

        private void btn_oluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@p1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Duyuru Oluşturuldu...");
        }

        private void btn_dktpanel_Click(object sender, EventArgs e)
        {
            Frm_DoktorPaneli fr = new Frm_DoktorPaneli();
            fr.Show();
        }

        private void btn_randevuliste_Click(object sender, EventArgs e)
        {
            Frm_Randevular fr = new Frm_Randevular();
            fr.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();
        }
    }
}
