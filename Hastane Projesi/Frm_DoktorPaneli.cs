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
    public partial class Frm_DoktorPaneli : Form
    {
        public Frm_DoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut = new SqlCommand("select BranşAd from Tbl_Branşlar", bgl.baglantı());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_branş.Items.Add(dr[0].ToString());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (Doktorad,DoktorSoyad,DoktorBranş,DoktorTc,DoktorSıfre)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", cmb_branş.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Eklendi...");
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_branş.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktorlar where DoktorTc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Silindi...");
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBranş=@d3,DoktorSıfre=@d5 where DoktorTc=@d4", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1", txt_ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@d3", cmb_branş.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txt_sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi...");
        }

    }
}
