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
    public partial class FrmGiderIstatistik : Form
    {
        public FrmGiderIstatistik()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGiderIstatistik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet22.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter1.Fill(this.yurtOtomasyonuDataSet22.Giderler);

            SqlCommand komut = new SqlCommand("SELECT SUM(Elektrik + Su + Dogalgaz + İnternet + Gıda + Personel + Diger) AS Toplam FROM Giderler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                LblKasa.Text = oku["Toplam"].ToString() + " TL";
            }

            bgl.baglanti().Close();


            //grafiklere veritabanından veri çekme
            SqlCommand komut3 = new SqlCommand("select Tarih, sum(Elektrik + Su + Dogalgaz + İnternet + Gıda + Personel + Diger) as ToplamGider from Giderler group by Tarih", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylar"].Points.AddXY(oku3["Tarih"], oku3["ToplamGider"]);
            }
            bgl.baglanti().Close();

        }
    }
}