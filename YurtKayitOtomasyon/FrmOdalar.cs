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
    public partial class FrmOdalar : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public FrmOdalar()
        {
            InitializeComponent();

        }
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            try
            {


                Button[] buttons ={
                button101, button102, button103, button104, button105,
                button201, button202, button203, button204, button205,
                button301, button302, button303, button304, button305,
                button401, button402, button403, button404, button405
             };

                for (int i = 0; i < buttons.Length; i++)
                {
                    string odaNo = buttons[i].Text;
                    SqlCommand renkkomut = new SqlCommand("Select Count (*) from Odalar where OdaNo = @OdaNo and OdaKapasite = OdaAktifOgr", bgl.baglanti());
                    renkkomut.Parameters.AddWithValue("@OdaNo", odaNo);
                    int kisiSayisi = Convert.ToInt32(renkkomut.ExecuteScalar());

                    if (kisiSayisi > 0)
                    {
                        buttons[i].BackColor = Color.Red;
                    }
                    else
                    {
                        buttons[i].BackColor = Color.Green;
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

