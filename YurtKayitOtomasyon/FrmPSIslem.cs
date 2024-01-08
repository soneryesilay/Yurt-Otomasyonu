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
    public partial class FrmPSIslem : Form
    {
        public FrmPSIslem()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();
        private void FrmPSIslem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet24.Giris' table. You can move, or remove it, as needed.
            this.girisTableAdapter.Fill(this.yurtOtomasyonuDataSet24.Giris);
            
            SqlDataAdapter da = new SqlDataAdapter("select * from Giris where KullaniciTur = 0", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public void veriyenile()
        {
            this.girisTableAdapter.Fill(this.yurtOtomasyonuDataSet24.Giris);
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, k_ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            k_ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtPersonelID.Text = id;
            TxtPersonelKAd.Text = k_ad;
            TxtSifre.Text = sifre;
        }



        private void BtnSil_Click(object sender, EventArgs e)
        {
            try {
                // 
                if (string.IsNullOrWhiteSpace(TxtPersonelID.Text) || string.IsNullOrWhiteSpace(TxtSifre.Text) || string.IsNullOrWhiteSpace(TxtPersonelKAd.Text) )
                {
                MessageBox.Show("Lütfen bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Silme işlemi gerçekleştirilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from Giris where ID=@p1 and KullaniciTur=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
                komut.Parameters.AddWithValue("@p2", 0);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi");
                    veriyenile();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }


        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtSifre.Text) || string.IsNullOrWhiteSpace(TxtPersonelKAd.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı seçiniz!.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //KULLANICI ADININ DAHA ÖNCE ALINIP ALINMADIĞINI KOTNROL ETTİR!
                SqlCommand kontrolKomut = new SqlCommand("select count (*) from Giris where kullaniciad = @s1", bgl.baglanti());
                kontrolKomut.Parameters.AddWithValue("@s1", TxtPersonelKAd.Text);
                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı ile daha önce kayıt yapılmış!");
                    return;
                }

                else
                {
                    DialogResult result = MessageBox.Show("Güncelleme işlemi gerçekleştirilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("update Giris set KullaniciAd=@p3,Sifre=@p2,KullaniciTur=@p4 where ID=@p1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
                        komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                        komut.Parameters.AddWithValue("@p3", TxtPersonelKAd.Text);
                        komut.Parameters.AddWithValue("@p4", 0);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Güncelleme Gerçekleştirildi");
                        veriyenile();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try { 
            if (string.IsNullOrWhiteSpace(TxtSifre.Text) || string.IsNullOrWhiteSpace(TxtPersonelKAd.Text))
            {
                MessageBox.Show("Lütfen kullanıcı seçiniz!.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



                //KULLANICI ADI VE ŞİFRENİN DAHA ÖNCE ALINIP ALINMADIĞINI KOTNROL ETTİR!
                SqlCommand kontrolKomut = new SqlCommand("select count (*) from Giris where kullaniciad = @s1", bgl.baglanti());
                kontrolKomut.Parameters.AddWithValue("@s1", TxtPersonelKAd.Text);
                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());


                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı ile daha önce kayıt yapılmış!");
                    return;
                }

                else
                {
                    DialogResult result = MessageBox.Show("Kaydetme işlemi gerçekleştirilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("insert into Giris (KullaniciAd,Sifre,KullaniciTur) values(@p1,@p2,@p3)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", TxtPersonelKAd.Text);
                        komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                        komut.Parameters.AddWithValue("@p3", 0);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Kaydetme Gerçekleştirildi");
                        veriyenile();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }
    }
}

