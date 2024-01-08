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
    public partial class FrmYoneticiDuzenleme : Form
    {
        public FrmYoneticiDuzenleme()
        {
            InitializeComponent();
        }

   
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmYoneticiDuzenleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet23.Giris' table. You can move, or remove it, as needed.
            this.girisTableAdapter.Fill(this.yurtOtomasyonuDataSet23.Giris);
            

            SqlDataAdapter da = new SqlDataAdapter("select * from Giris where KullaniciTur = 1", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        int secilen;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtYoneticiID.Text = id;
            TxtYoneticiAd.Text = ad;
            TxtYoneticiSifre.Text = sifre;

        }

        public void veriyenile()
        {
            this.girisTableAdapter.Fill(this.yurtOtomasyonuDataSet23.Giris);
            dataGridView1.Refresh();
        }
        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(TxtYoneticiAd.Text) || string.IsNullOrEmpty(TxtYoneticiSifre.Text))
                {
                    MessageBox.Show("Lütfen yönetici bilgilerini girin.");
                    return;
                }

                //KULLANICI ADININ DAHA ÖNCEDEN ALINIP ALINMADIĞINI KOTNROL ETTİR!
                SqlCommand kontrolKomut = new SqlCommand("select count (*) from giris where kullaniciad = @s1", bgl.baglanti());
                kontrolKomut.Parameters.AddWithValue("@s1", TxtYoneticiAd.Text);
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
                        SqlCommand komut = new SqlCommand("insert into giris (KullaniciAd,Sifre,KullaniciTur) values (@p1,@p2,@p3)", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", TxtYoneticiAd.Text);
                        komut.Parameters.AddWithValue("@p2", TxtYoneticiSifre.Text);
                        komut.Parameters.AddWithValue("@p3", 1);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Yonetici Eklendi");
                        veriyenile();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!", ex.Message);
            }

}

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            try {

                    if (string.IsNullOrEmpty(TxtYoneticiID.Text) || string.IsNullOrEmpty(TxtYoneticiAd.Text) || string.IsNullOrEmpty(TxtYoneticiSifre.Text))
                    {
                        MessageBox.Show("Lütfen yönetici bilgilerini girin.");
                        return;
                    }
                DialogResult result = MessageBox.Show("Silme işlemi gerçekleştirilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                { 
                    SqlCommand komut = new SqlCommand("delete from giris where kullaniciad=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtYoneticiID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi");
                    veriyenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!", ex.Message);
            }

}

        private void BtnGüncelle_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(TxtYoneticiID.Text) || string.IsNullOrEmpty(TxtYoneticiAd.Text) || string.IsNullOrEmpty(TxtYoneticiSifre.Text))
                {
                    MessageBox.Show("Lütfen yönetici bilgilerini girin.");
                    return;
                }
                DialogResult result = MessageBox.Show("Silme işlemi gerçekleştirilecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("update giris set KullaniciAd=@p1,Sifre=@p2 where ID=@p3", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtYoneticiAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtYoneticiSifre.Text);
                    komut.Parameters.AddWithValue("@p3", TxtYoneticiID.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Güncelleme Gerçekleştirildi");
                    veriyenile();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA!", ex.Message);
            }

        }

   
    }
}

