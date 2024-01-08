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
using YurtKayitSistemi;

namespace YurtKayitOtomasyon
{
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }

            SqlBaglantim bgl=new SqlBaglantim();

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }
 
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                int yıl = DateTime.Now.Year;

                if (string.IsNullOrWhiteSpace(TxtElektrik.Text) ||
                string.IsNullOrWhiteSpace(TxtSu.Text) ||
                string.IsNullOrWhiteSpace(TxtDogalGaz.Text) ||
                string.IsNullOrWhiteSpace(TxtInternet.Text) ||
                string.IsNullOrWhiteSpace(TxtGıda.Text) ||
                string.IsNullOrWhiteSpace(TxtPersonel.Text) ||
                string.IsNullOrWhiteSpace(TxtDiger.Text))
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz!.");
                    return; 
                }
              
                //daha önceden kaydedilmiş mi kontrol et
                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM giderler WHERE Tarih = @p8", bgl.baglanti());
                kontrol.Parameters.AddWithValue("@p8", mskgidertarih.Text + " " + yıl);
                int existingEntries = (int)kontrol.ExecuteScalar();

                if (existingEntries > 0)
                {
                    MessageBox.Show("Bu tarihin gideri zaten mevcut!");
                    return; 
                }

                SqlCommand komut = new SqlCommand("insert into giderler(Elektrik,Su,Dogalgaz,internet" +
                    ",Gıda,Personel,Diger,Tarih)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.Parameters.AddWithValue("@p8", mskgidertarih.Text + " " + yıl);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler Eklendi!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata,Yeniden Deneyiniz!", ex.Message);
            }
        }
    }
}
