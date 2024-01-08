using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Forms;
using YurtKayitSistemi;

namespace YurtKayitOtomasyon
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            
            try
            {
            
                dataGridView1.Columns.Add("OgrAd", "Öğrenci Adı");
                dataGridView1.Columns.Add("OgrSoyad", "Öğrenci Soyadı");
                dataGridView1.Columns.Add("Devamsizlik", "Devamsızlık");
                dataGridView1.Columns.Add("OgrVeliAdSoyad", "Veli Adı Soyadı");
                dataGridView1.Columns.Add("OgrVeliTelefon", "Veli Telefon");



                dataGridView2.Columns.Add("OgrAd", "Öğrenci Adı");
                dataGridView2.Columns.Add("OgrSoyad", "Öğrenci Soyadı");
                dataGridView2.Columns.Add("OgrKalanBorc", "Kalan Borç");
                dataGridView2.Columns.Add("OgrTelefon", "Öğrenci Telefon");
                borc();
                devamsizlik();          

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata!", ex.Message);
            }
            
        }


        private void devamsizlik()
        {
            try
            {
                SqlCommand devamsizlik = new SqlCommand("SELECT TOP 10 OgrAd, OgrSoyad, Devamsizlik, OgrVeliAdSoyad, OgrVeliTelefon FROM Devamsizlik WHERE Devamsizlik > 0 ORDER BY Devamsizlik DESC", bgl.baglanti());

                dataGridView1.Rows.Clear();

                // Verileri dataGridView1'e ekle
                using (SqlDataReader reader = devamsizlik.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["OgrAd"].ToString(), reader["OgrSoyad"].ToString(), reader["Devamsizlik"].ToString(), reader["OgrVeliAdSoyad"].ToString(), reader["OgrVeliTelefon"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!", ex.Message);
            }
        }

        private void borc()
        {
            try
            {
                SqlCommand odeme = new SqlCommand("SELECT TOP 10 OgrAd, OgrSoyad,OgrTelefon, OgrKalanBorc FROM odemeler WHERE OgrKalanBorc > 0 ORDER BY OgrKalanBorc DESC", bgl.baglanti());

                dataGridView2.Rows.Clear();

                // Verileri DataGridView'e ekle
                using (SqlDataReader reader = odeme.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGridView2.Rows.Add(reader["OgrAd"].ToString(), reader["OgrSoyad"].ToString(), reader["OgrKalanBorc"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!", ex.Message);
            }
        }

      
    }
}
