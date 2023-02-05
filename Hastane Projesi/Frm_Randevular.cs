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
    public partial class Frm_Randevular : Form
    {
        public Frm_Randevular()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void Frm_Randevular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular", bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

      
    }
}
