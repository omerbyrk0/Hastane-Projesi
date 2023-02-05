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
    public partial class Frm_Duyurular : Form
    {
        public Frm_Duyurular()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Duyurular", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
