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
    public partial class FrmGiderListesi : Form

    {
        private void datagridyenile()
        {
            this.giderlerTableAdapter2.Fill(this.yurtOtomasyonuDataSet18.Giderler);

        }
        public FrmGiderListesi()
        {
            InitializeComponent();
            datagridyenile();
        }
     
        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet18.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter2.Fill(this.yurtOtomasyonuDataSet18.Giderler);
            datagridyenile();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen;
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            this.Hide();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.gidertarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.elektrik = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.su = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.gıda = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frg.diger = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frg.Show();
            this.giderlerTableAdapter2.Fill(this.yurtOtomasyonuDataSet18.Giderler);
        }
    }
}
