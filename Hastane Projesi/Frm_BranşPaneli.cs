using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class Frm_BranşPaneli : Form
    {
        public Frm_BranşPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_BranşPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branşlar", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Branşlar (BranşAd)values(@p1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_bransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Eklendi...");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_bransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_bransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branşlar where Branşİd=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_bransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Silindi...");
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branşlar set BranşAd=@p1 where Branşİd=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txt_bransad.Text);
            komut.Parameters.AddWithValue("@p2", txt_bransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Kayıt Güncellendi...");
        }
    }
}
