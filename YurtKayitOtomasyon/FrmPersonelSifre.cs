using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtKayitSistemi;

namespace YurtKayitOtomasyon
{
    public partial class FrmPersonelSifre : Form
    {
        public FrmPersonelSifre()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Textbox boş  kontrol 
                if (string.IsNullOrWhiteSpace(TxtKullaniciAd.Text) || string.IsNullOrWhiteSpace(TxtEskiSifre.Text) || string.IsNullOrWhiteSpace(TxtYeniSifre.Text))
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                DialogResult result = MessageBox.Show("Güncelleme işlemi gerçekleştirilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Mevcut kullanıcı adı ve şifreyi kontrol 
                    SqlCommand kontrol = new SqlCommand("select * from Giris where KullaniciAd=@p1 and Sifre=@p2 and GirisTur=0", bgl.baglanti());
                    kontrol.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
                    kontrol.Parameters.AddWithValue("@p2", TxtEskiSifre.Text); 
                    SqlDataReader dr = kontrol.ExecuteReader();

                    if (dr.Read()) 
                    {
                        string kullaniciAdFromDb = dr["KullaniciAd"].ToString();
                        string sifreFromDb = dr["Sifre"].ToString();

                        if (kullaniciAdFromDb.Equals(TxtKullaniciAd.Text) && sifreFromDb.Equals(TxtEskiSifre.Text))
                        { 
                        dr.Close(); 

                
                        SqlCommand guncelle = new SqlCommand("update Giris set Sifre=@p1 where KullaniciAd=@p2", bgl.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", TxtYeniSifre.Text);
                        guncelle.Parameters.AddWithValue("@p2", TxtKullaniciAd.Text); 
                        guncelle.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Güncelleme Gerçekleştirildi");
                        }
                    }
                    else
                    {
                        dr.Close(); // SqlDataReader'ı kapat
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı. Güncelleme işlemi iptal edildi.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi iptal edildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }

        private void FrmPersonelSifre_Load(object sender, EventArgs e)
        {

        }
    }
}



 
    




