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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet4.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Personel);



        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad, PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Personel);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleştirildi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Personel);

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p3,PersonelDepartman=@p2 where PersonelID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
            komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonelAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme Gerçekleştirildi");

        }


      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

 
    }
    }

