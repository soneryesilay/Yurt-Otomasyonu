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
    public partial class FrmOgrIzin : Form
    {
        public FrmOgrIzin()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl =new SqlBaglantim();

        private void FrmOgrIzin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet10.İzinler' table. You can move, or remove it, as needed.
            this.İzinlerTableAdapter.Fill(this.yurtOtomasyonuDataSet10.İzinler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, izin, soyad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            izin = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtOgrId.Text = id;
            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtIzin.Text = izin;
        }

        private void BtnGunGir_Click(object sender, EventArgs e)
        {
            try { 
            if (string.IsNullOrEmpty(TxtOgrId.Text))
            {
                MessageBox.Show("Lütfen öğrenci seçin.");
                return;
            }

            int girilenIzin = string.IsNullOrEmpty(txtIzinGir.Text) ? 1 : Convert.ToInt32(txtIzinGir.Text);

            // Textboxa izin gününü çektik
            int mevcutIzin = Convert.ToInt32(TxtIzin.Text);

            // Girilen izin kadar azalt
            mevcutIzin -= girilenIzin;

            if (mevcutIzin < 0)
            {
                MessageBox.Show("Öğrencinin izin hakkı yetersiz!");
                return;
            }

            //veri tabanına kaydetme
            SqlCommand komutkaydet = new SqlCommand("UPDATE İzinler SET IzinGun=@p1 WHERE OgrID=@p2", bgl.baglanti());

            komutkaydet.Parameters.AddWithValue("@p1", mevcutIzin);
            komutkaydet.Parameters.AddWithValue("@p2", TxtOgrId.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            // Txt bx değeri güncelle
            TxtIzin.Text = mevcutIzin.ToString();

            MessageBox.Show("İzin Bilgisi Güncellendi!");

            // güncel verileri göster
            this.İzinlerTableAdapter.Fill(this.yurtOtomasyonuDataSet10.İzinler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu", ex.Message);
            }
        }


    }
}
