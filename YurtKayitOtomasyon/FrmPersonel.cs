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
using static System.Net.Mime.MediaTypeNames;

namespace YurtKayitOtomasyon
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet16.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter1.Fill(this.yurtOtomasyonuDataSet16.Personel);



        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, gorev;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtPersonelID.Text = id;
            TxtPersonelAd.Text = ad;
            TxtGorev.Text = gorev;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
         
            try
            {
                if (string.IsNullOrEmpty(TxtPersonelAd.Text)|| string.IsNullOrEmpty(TxtGorev.Text))
                {
                    MessageBox.Show("Lütfen personel seçin.");
                    return;
                }
                SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad, PersonelGorev) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Eklendi");
                this.personelTableAdapter1.Fill(this.yurtOtomasyonuDataSet16.Personel);
                FrmPSIslem FR=new FrmPSIslem();
                FR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        
    }





        private void BtnGüncelle_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(TxtPersonelID.Text) || string.IsNullOrEmpty(TxtPersonelAd.Text) || string.IsNullOrEmpty(TxtGorev.Text))
                {
                    MessageBox.Show("Lütfen personel seçin.");
                    return;
                }
                SqlCommand guncelle = new SqlCommand("update personel set PersonelAdSoyad=@g3, PersonelGorev=@g1 where PersonelID=@g2", bgl.baglanti());
               guncelle.Parameters.AddWithValue("@g3",TxtPersonelAd.Text);
                guncelle.Parameters.AddWithValue("@g1", TxtGorev.Text);
                guncelle.Parameters.AddWithValue("@g2", TxtPersonelID.Text);
                guncelle.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Güncelleme Gerçekleştirildi");
                this.personelTableAdapter1.Fill(this.yurtOtomasyonuDataSet16.Personel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }


        private void BtnSil_Click_1(object sender, EventArgs e)
        {
          
            try
            {
                if (string.IsNullOrEmpty(TxtPersonelID.Text) || string.IsNullOrEmpty(TxtPersonelAd.Text)|| string.IsNullOrEmpty(TxtGorev.Text))
                {
                    MessageBox.Show("Lütfen personel seçin.");
                    return;
                }
                SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleştirildi");
                this.personelTableAdapter1.Fill(this.yurtOtomasyonuDataSet16.Personel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }

      
    }
}
