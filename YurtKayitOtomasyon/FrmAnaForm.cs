using System;
using System.Windows.Forms;
using YurtKayitOtomasyon;

namespace YurtKayitOtomasyon
{
    public partial class FrmAnaForm : Form
    {
        private bool isMainFormOpen = false;

        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void datagridyenile()
        {
            // DataGridView'i güncelle
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet.Ogrenci);
        }
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = Properties.stirngs.OGRAD;
            dataGridView1.Columns[1].HeaderText = Properties.stirngs.OGRSOYAD;
            dataGridView1.Columns[2].HeaderText = Properties.stirngs.OGRTC;
            dataGridView1.Columns[3].HeaderText = Properties.stirngs.OGRTEL;
            dataGridView1.Columns[4].HeaderText = Properties.stirngs.OGRDOGUM;
            dataGridView1.Columns[5].HeaderText = Properties.stirngs.OGRODA;
            dataGridView1.Columns[6].HeaderText = Properties.stirngs.OGRKAYIT;
            dataGridView1.Columns[7].HeaderText = Properties.stirngs.OGRVELİ;
            dataGridView1.Columns[8].HeaderText = Properties.stirngs.VELTEL;
            dataGridView1.Columns[9].HeaderText = Properties.stirngs.VELADRES;



            this.Text = Properties.stirngs.S003;
            öğrencilerToolStripMenuItem.Text = Properties.stirngs.LangOGR;
            öğrenciEkleToolStripMenuItem.Text = Properties.stirngs.LangOGREK;
            öğrenciDüzenleToolStripMenuItem.Text = Properties.stirngs.LangOGRDUZ;
            öğrenciListesiToolStripMenuItem.Text = Properties.stirngs.LangOGRLIST;
            öğrenciDevamDurumuToolStripMenuItem.Text = Properties.stirngs.LangOGRDEVAM;
            öğrenciİzinToolStripMenuItem.Text = Properties.stirngs.LangOGRIZIN;
            odalarToolStripMenuItem.Text = Properties.stirngs.LangODA;
            odaBilgileriToolStripMenuItem.Text = Properties.stirngs.LangODAB;
            ödemeAlToolStripMenuItem.Text = Properties.stirngs.LangODAL;
            bölümlerToolStripMenuItem.Text = Properties.stirngs.LangOGBOL;
            bölümİşlemleriToolStripMenuItem.Text = Properties.stirngs.LangBOLISL;
            ödemelerToolStripMenuItem.Text = Properties.stirngs.LangODE;
            giderlerToolStripMenuItem.Text = Properties.stirngs.LangGIDER;
            giderEkleToolStripMenuItem.Text = Properties.stirngs.LangGIDEK;
            giderListesiToolStripMenuItem.Text = Properties.stirngs.LangGIDLIST;
            istatistiklerToolStripMenuItem.Text = Properties.stirngs.LangISTATIK;
            gelirlerToolStripMenuItem.Text = Properties.stirngs.LangGRAP;
            giderlerToolStripMenuItem1.Text = Properties.stirngs.LangGIDRAP;
            raporToolStripMenuItem1.Text = Properties.stirngs.LangSTRAP;
            yöneticiToolStripMenuItem.Text = Properties.stirngs.LangYON;
            şifreİşlemleriToolStripMenuItem.Text = Properties.stirngs.LangSIFRE;
            personelDüzenlemeToolStripMenuItem.Text = Properties.stirngs.LangPSLEM;
            personelŞifreİşlemleriToolStripMenuItem.Text = Properties.stirngs.LangPSIFRE;
            erişimKolaylığıToolStripMenuItem.Text = Properties.stirngs.LangErişim;
            hesapMakinesiToolStripMenuItem.Text = Properties.stirngs.LangHESAPM;
            oturumuKapatToolStripMenuItem.Text = Properties.stirngs.LangOturum;
            çıkışToolStripMenuItem.Text = Properties.stirngs.LangCIK;

            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet.Ogrenci);
            datagridyenile();
        }

        private void OpenForm(Form form)
        {
            if(!isMainFormOpen)
                {
                form.FormClosed += (s, args) => isMainFormOpen = false;
                form.ShowDialog();
            }
        }



        private void OpenCalculator()
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void ShowAboutInfo()
        {
            MessageBox.Show("SONER YEŞİLAY 1226829056", "TRAKYA ÜNİVERSİTESİ BPR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCalculator();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrKayit());
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrListcs());
        }

        // ... (Repeat the pattern for other menu items)

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutInfo();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet.Ogrenci);
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrListcs());
        }

        private void öğrenciDevamDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrDevamsizlik());
        }

        private void öğrenciİzinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrIzin());

        }

        private void odaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOdalar());
        }

        private void bölümİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBolumler());
        }
        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOdemeler());

        }


        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmGider());

        }

        private void giderlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmGiderIstatistik());
        }

        private void gelirlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmGelirIstatistik());
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmYoneticiDuzenleme());
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPersonel());


        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmGiderListesi());
        }

        private void raporToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRapor());
        }

        private void personelŞifreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPSIslem());
        }

        private void personelŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPSIslem());
        }

        private void ExitApplication()
        {
            DialogResult result = MessageBox.Show(Properties.stirngs.uygulamasoru, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.stirngs.oturumsoru, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;

            if (result == DialogResult.Yes)
            {
                this.Hide(); 
                OpenForm(new FrmGiris());
            }
        }

        private void bölümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrKayit());

        }
    }
}
