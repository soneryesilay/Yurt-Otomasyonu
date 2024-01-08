using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using YurtKayitSistemi;

namespace YurtKayitOtomasyon
{
    public partial class FrmOgrKayit : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // Bölümleri listeledik
            SqlCommand komut = new SqlCommand("select BolumAd from Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbbolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            // Boş odaları listeleme
            SqlCommand komut2 = new SqlCommand("select OdaNo from Odalar where OdaKapasite != OdaAktifOgr", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtOgrAd.Text) ||
                               string.IsNullOrWhiteSpace(TxtOgrSoyad.Text) ||
                               string.IsNullOrWhiteSpace(MskTC.Text) ||
                               string.IsNullOrWhiteSpace(MskOgrTelefon.Text) ||
                               string.IsNullOrWhiteSpace(MskDogum.Text) ||
                               string.IsNullOrWhiteSpace(cmbbolum.Text) ||
                               string.IsNullOrWhiteSpace(CmbOdaNo.Text) ||
                               string.IsNullOrWhiteSpace(TxtVeliAdSoyad.Text) ||
                               string.IsNullOrWhiteSpace(MskVeliTelefon.Text) ||
                               string.IsNullOrWhiteSpace(RchAdres.Text))
                {
                    MessageBox.Show("Zorunlu Alanları Doldurun!");
                    return;
                }

                // TC'nin daha önce kaydedilip kaydedilmediğini kontrol et
                SqlCommand kontrolKomut = new SqlCommand("select count (*) from Ogrenci where OgrTc = @tc", bgl.baglanti());
                kontrolKomut.Parameters.AddWithValue("@tc", MskTC.Text);
                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu TC Kimlik Numarası ile daha önce kayıt yapılmış!");
                }
                else
                {
                    // TC numarasının daha önce kaydedilmediyse yeni kaydı ekle
                    SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci " +
                        "(OgrAd,OgrSoyad,OgrTc," +
                         "OgrTelefon,OgrDogum,OgrBolum," +
                         "OgrMail,OgrOdaNo,OgrKayitTarihi," +
                         "OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres)" +
                         "VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)",
                          bgl.baglanti());

                    komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", MskDogum.Text);
                    komutkaydet.Parameters.AddWithValue("@p6", cmbbolum.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                    komutkaydet.Parameters.AddWithValue("@p9", mskkayittarih.Text);
                    komutkaydet.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@p12", RchAdres.Text);

                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Öğrenci Kayıdı Oluşturuldu!");

                    // ID Yİ ÇEKTİK
                    SqlCommand idKomut = new SqlCommand("select OgrID from Ogrenci where OgrTc = @tc", bgl.baglanti());
                    idKomut.Parameters.AddWithValue("@tc", MskTC.Text);
                    OgrID.Text = idKomut.ExecuteScalar().ToString();
                    bgl.baglanti().Close();

                    // Odadaki Öğrenci sayısını arttırma
                    SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktifOgr = OdaAktifOgr + 1 where OdaNo = @oda1", bgl.baglanti());
                    komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
                    komutoda.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    // Ödemeler
                    SqlCommand komutodeme = new SqlCommand("insert into Odemeler(OgrID,OgrAd,OgrSoyad,OgrTelefon) values(@O1,@O2,@O3,@O4)",bgl.baglanti());
                    komutodeme.Parameters.AddWithValue("@O1", OgrID.Text);
                    komutodeme.Parameters.AddWithValue("@O2", TxtOgrAd.Text);
                    komutodeme.Parameters.AddWithValue("@O3", TxtOgrSoyad.Text);
                    komutodeme.Parameters.AddWithValue("@O4", MskOgrTelefon.Text);
                    komutodeme.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    // İzinler 
                    SqlCommand komutIzin = new SqlCommand("insert into İzinler(OgrID,OgrAd,OgrSoyad) values(@I1,@I2,@I3)",bgl.baglanti());
                    komutIzin.Parameters.AddWithValue("@I1", OgrID.Text);
                    komutIzin.Parameters.AddWithValue("@I2", TxtOgrAd.Text);
                    komutIzin.Parameters.AddWithValue("@I3", TxtOgrSoyad.Text);
                    komutIzin.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    // Devamsizlik
                    SqlCommand komutDevamsiz = new SqlCommand("insert into Devamsizlik(OgrID,OgrAd,OgrSoyad,OgrVeliAdSoyad,OgrVeliTelefon)values(@d1,@d2,@d3,@d4,@d5) ", bgl.baglanti());
                    komutDevamsiz.Parameters.AddWithValue("@d1", OgrID.Text);
                    komutDevamsiz.Parameters.AddWithValue("@d2", TxtOgrAd.Text);
                    komutDevamsiz.Parameters.AddWithValue("@d3", TxtOgrSoyad.Text);
                    komutDevamsiz.Parameters.AddWithValue("@d4", TxtVeliAdSoyad.Text);
                    komutDevamsiz.Parameters.AddWithValue("@d5",MskVeliTelefon.Text);
                    komutDevamsiz.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! Lütfen yeniden deneyiniz\n\nHata Detayı: " + ex.Message);
            }
        }
    }
}
