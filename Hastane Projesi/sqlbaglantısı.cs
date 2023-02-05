using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    internal class sqlbaglantısı
    {

        public SqlConnection baglantı()
        {
            SqlConnection baglan = new SqlConnection("Data Source=OMER\\SQLEXPRESS;Initial Catalog=HastaneVeriTabani;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
