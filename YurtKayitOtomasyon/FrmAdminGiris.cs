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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("select * from Admin where YoneticiAd=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
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
                MessageBox.Show("Hata Oluştu",ex.Message);
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAcilis fr=new FrmAcilis();
            fr.Show();
            this.Hide();
        }

        private void FrmAdminGiris_Load_1(object sender, EventArgs e)
        {

        }
    }
    
}
