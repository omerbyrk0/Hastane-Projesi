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
    public partial class Frm_HastaGiris : Form
    {
        public Frm_HastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Hasta_Kayıt frm = new Frm_Hasta_Kayıt();
            frm.Show();
        }

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1 and HastaSıfre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Frm_HastaDetay frm = new Frm_HastaDetay();
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

        private void Frm_HastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
