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
using YurtKayitSistemi;

namespace YurtKayitOtomasyon
{
    public partial class FrmGiderGuncelle : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }

        public string id, elektrik, su, dogalgaz, gıda, diger, internet, personel, gidertarih;

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtgiderid.Text))
            {
                MessageBox.Show("Lütfen gider seçin.");
                return;
            }


            DialogResult result = MessageBox.Show("Gideri silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                try
                {

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM giderler WHERE GiderID=@p1", bgl.baglanti());
                    deleteCommand.Parameters.AddWithValue("@p1", txtgiderid.Text);

                    deleteCommand.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Gider silme işlemi gerçekleştirildi!");
                }
                catch
                {
                    MessageBox.Show("Hata, yeniden deneyiniz!");
                }
            }
        
        }

        private void FrmGiderGuncelle_Load_1(object sender, EventArgs e)
        {

            txtgiderid.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDogalGaz.Text = dogalgaz;
            TxtInternet.Text = internet;
            TxtGida.Text = gıda;
            TxtPersonel.Text = personel;
            TxtDiger.Text = diger;
            mskgidertarih.Text = gidertarih;
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtgiderid.Text))
                {
                    MessageBox.Show("Lütfen gider seçin.");
                    return;
                }

                // Şu anki yılı al
                int yıl = DateTime.Now.Year;

                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM giderler WHERE Tarih = @p8", bgl.baglanti());
                kontrol.Parameters.AddWithValue("@p8", mskgidertarih.Text + " " + yıl);
                int existingEntries = (int)kontrol.ExecuteScalar();

                if (existingEntries > 0)
                {
                    MessageBox.Show("Bu tarihin gideri zaten mevcut!");
                    return;
                }

                SqlCommand komut = new SqlCommand("update giderler set " +
                    "Elektrik=@p1, su=@p2, DogalGaz=@p3, " +
                    "internet=@p4, Gıda=@p5, personel=@p6, diger=@p7, Tarih=@p8 " +
                    "where GiderID=@p9", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.Parameters.AddWithValue("@p8", mskgidertarih.Text + " " + yıl);
                komut.Parameters.AddWithValue("@p9", txtgiderid.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Gerçekleştirildi!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata, Yeniden Deneyiniz!",ex.Message);
            }

        }

    }
}

       
    

