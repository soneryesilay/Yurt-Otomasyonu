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
    public partial class FrmOgrDevamsizlik : Form
    {
        public FrmOgrDevamsizlik()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOgrTakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet11.Devamsizlik' table. You can move, or remove it, as needed.
            this.devamsizlikTableAdapter1.Fill(this.yurtOtomasyonuDataSet11.Devamsizlik);


        }

        private void BtnGunGir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtOgrId.Text))
                {
                    MessageBox.Show("Lütfen öğrenci seçin.");
                    return;
                }

                // TextBox'tan girilen devamsızlık değerini çek
                int girilenDevamsizlik = string.IsNullOrEmpty(txtdevamsizlikgir.Text) ? 1 : Convert.ToInt32(txtdevamsizlikgir.Text);

                // TextBox'tan mevcut devamsızlık değerini çek
                int mevcutDevamsizlik = Convert.ToInt32(TxtDevamsizlik.Text);

                // Girilen devamsızlık kadar artır
                mevcutDevamsizlik += girilenDevamsizlik;

                //veri tabanına kaydetme
                SqlCommand komutkaydet = new SqlCommand("UPDATE Devamsizlik SET Devamsizlik=@p2 WHERE OgrID=@p1", bgl.baglanti());

                komutkaydet.Parameters.AddWithValue("@p2", mevcutDevamsizlik);
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrId.Text);

                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();

                // TextBox'taki değeri güncelle
                TxtDevamsizlik.Text = mevcutDevamsizlik.ToString();

                // Devamsızlık değeri 10'dan fazlaysa uyarı ver
                if (mevcutDevamsizlik >= 10)
                {
                    MessageBox.Show("Uyarı: Öğrencinin devamsızlığı sınırda!");
                }


                MessageBox.Show("Devamsızlık Bilgisi Güncellendi!");

                // güncel verileri göster
                this.devamsizlikTableAdapter1.Fill(this.yurtOtomasyonuDataSet11.Devamsizlik);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message);
            }
        }



        int secilen;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
            string id, ad, soyad, devamsizlik;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            devamsizlik = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
           
            TxtOgrId.Text = id;
            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtDevamsizlik.Text = devamsizlik;
        }

     
    }
}
