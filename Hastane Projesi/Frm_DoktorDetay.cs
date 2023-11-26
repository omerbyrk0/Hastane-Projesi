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
    public partial class Frm_DoktorDetay : Form
    {
        public Frm_DoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();
        public string tc;

        private void Frm_DoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;

            //doktor adı soyadı çekme

            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where doktortc=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }


            //randevuları çekme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor = '" + lbl_adsoyad.Text + "'", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btn_bilgiguncelle_Click(object sender, EventArgs e)
        {
            Frm__DokorBilgiDüzenle fr = new Frm__DokorBilgiDüzenle();
            fr.tc = lbl_tc.Text;
            fr.Show();
        }

        private void btn_duyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();
        }

        private void bt_cıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
