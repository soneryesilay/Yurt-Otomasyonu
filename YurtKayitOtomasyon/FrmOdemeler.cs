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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet8.Odemeler' table. You can move, or remove it, as needed.
            this.odemelerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Odemeler);

        }


        private void btnodemeal_Click_1(object sender, EventArgs e)
        {

            try {

                if (string.IsNullOrEmpty(TxtOgrID.Text))
                {
                    MessageBox.Show("Lütfen öğrenci seçin.");
                    return;
                }

            int odenen = Convert.ToInt32(TxtOdenen.Text);
            int kalan = Convert.ToInt32(TxtKalan.Text);

            if (odenen <= 0 || odenen > kalan)
            {
                MessageBox.Show("Geçersiz ödeme miktarı!");
                return; // Ödeme geçersizse metoddan çık
            }


                int yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            //yeni tutarı veritabanına kaydetme
            SqlCommand komut = new SqlCommand("update Odemeler set OgrKalanBorc=@p1 where OgrId=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrID.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Güncellendi.");
            this.odemelerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Odemeler);

             // Şu anki yılı al ve Kasa tablosuna ekle
             int yıl = DateTime.Now.Year;

             SqlCommand komut2 = new SqlCommand("insert into Kasaa (OdemeAy, OdemeMiktar) values(@k1, @k2)", bgl.baglanti());
             komut2.Parameters.AddWithValue("@k1", TxtOdemeAy.Text + " " + yıl);
             komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
             komut2.ExecuteNonQuery();
             bgl.baglanti().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu"+ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            TxtKalan.Text = kalan;
            TxtOgrID.Text = id;
        }
    }
}
