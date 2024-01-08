using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitOtomasyon
{
    public partial class FrmPersonelAnaForm : Form
    {
        private bool isMainFormOpen = false;
        public FrmPersonelAnaForm()
        {
            InitializeComponent();
        }
        private void datagridyenile()
        {
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet12.Ogrenci);

        }
        private void FrmPersonelAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet12.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet12.Ogrenci);
            datagridyenile();

        }
        private void OpenForm(Form form)
        {
            if (!isMainFormOpen)
            {
                form.FormClosed += (s, args) => isMainFormOpen = false;
                form.ShowDialog();
            }
        }



        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelSifre fr=new FrmPersonelSifre();
            fr.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrKayit());
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrListcs());

        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrListcs());

        }

        private void öğrenciDevamDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOgrDevamsizlik());

        }

 
        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOdemeler());

        }

   

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SONER YEŞİLAY 1226829056", "TRAKYA ÜNİVERSİTESİ BPR", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void bölümİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBolumler());
        }

        private void odaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmOdalar());
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Uygulamyı kapatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                
                }
        }

       
        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                OpenForm(new FrmGiris());
            }
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRapor());
        }
    }
}
