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
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }

        private void FrmAcilis_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr=new FrmAdminGiris();
            fr.Show();
            this.Hide();    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris fr= new FrmPersonelGiris();
            fr.Show();
            this.Hide();
        }

       
    }
}
