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
    public partial class Frm_HastaDetay : Form
    {
        public Frm_HastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_HastaDetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglantı().Close();

            //randevu geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, bgl.baglantı());

            da.Fill(dt);
            dataGridView1.DataSource = dt;//sanal bir tablo oluşturduk

            //branşları cekme
            SqlCommand komut2 = new SqlCommand("Select BranşAd from Tbl_Branşlar", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                combobrans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();
        }

        private void combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combodoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBranş = @p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", combobrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combodoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglantı().Close();
        }

        private void combodoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBranş='" + combobrans.Text + "'"+"and RandevuDoktor ='" + combodoktor.Text + "' and RandevuDurum=0", bgl.baglantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnk_bilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_HastaBilgiDüzenle frm = new Frm_HastaBilgiDüzenle();
            frm.Tcno = lbl_tc.Text;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txt_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3", bgl.baglantı()) ;
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            komut.Parameters.AddWithValue("@p2", richsıkayet.Text);
            komut.Parameters.AddWithValue("@p3", txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Randevu Alındı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
        }
    }
}
