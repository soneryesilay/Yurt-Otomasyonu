using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace YurtKayitSistemi
{

   
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            try
            { 
            SqlConnection baglan = new SqlConnection(@"Data Source=SONER;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:",ex.Message);
                return null;
            }
    }
  }
}
