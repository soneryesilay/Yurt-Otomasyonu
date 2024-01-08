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
    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "tr";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void picenglish_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Lang = "en";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            BtnGiris.Text = Properties.stirngs.S001;
            this.Text = Properties.stirngs.S002;
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("select * from Giris where KullaniciAd=@p1 and Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    string kullaniciAdFromDb = oku["KullaniciAd"].ToString();
                    string sifreFromDb = oku["Sifre"].ToString();
                    int kullaniciTur = Convert.ToInt32(oku["KullaniciTur"]);

                    if (kullaniciAdFromDb.Equals(TxtKullaniciAd.Text) && sifreFromDb.Equals(TxtSifre.Text))
                    {
                        if (kullaniciTur == 0)
                        {
                            FrmPersonelAnaForm frPersonel = new FrmPersonelAnaForm();
                            frPersonel.Show();
                        }
                        else if (kullaniciTur == 1)
                        {
                            FrmAnaForm frAna = new FrmAnaForm();
                            frAna.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(Properties.stirngs.ErrorMessage);
                        TxtKullaniciAd.Clear();
                        TxtSifre.Clear();
                        TxtKullaniciAd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(Properties.stirngs.ErrorMessage);
                    TxtKullaniciAd.Clear();
                    TxtSifre.Clear();
                    TxtKullaniciAd.Focus();
                }

                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.stirngs.Error + ex.Message);
            }
        }

    }
}
