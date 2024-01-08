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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();
        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAcilis fr = new FrmAcilis();
            fr.Show();
            this.Hide();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("select * from Personel where KullaniciAd=@p1 and Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmPersonelAnaForm fr = new FrmPersonelAnaForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı Ve Şifre ");
                    TxtKullaniciAd.Clear();
                    TxtSifre.Clear();
                    TxtKullaniciAd.Focus();

                }
                bgl.baglanti().Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }
    }
}
    