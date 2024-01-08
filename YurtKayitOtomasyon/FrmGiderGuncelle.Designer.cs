namespace YurtKayitOtomasyon
{
    partial class FrmGiderGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mskgidertarih = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgiderid = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDiger = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPersonel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtGida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDogalGaz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtElektrik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mskgidertarih);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtgiderid);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtDiger);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtPersonel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtGida);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtInternet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDogalGaz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtElektrik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 610);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİDER GÜNCELLE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F);
            this.button1.Location = new System.Drawing.Point(123, 525);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 63);
            this.button1.TabIndex = 50;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskgidertarih
            // 
            this.mskgidertarih.FormattingEnabled = true;
            this.mskgidertarih.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.mskgidertarih.Location = new System.Drawing.Point(239, 450);
            this.mskgidertarih.Name = "mskgidertarih";
            this.mskgidertarih.Size = new System.Drawing.Size(192, 32);
            this.mskgidertarih.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11F);
            this.label9.Location = new System.Drawing.Point(137, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Gider ID:";
            // 
            // txtgiderid
            // 
            this.txtgiderid.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtgiderid.Location = new System.Drawing.Point(239, 48);
            this.txtgiderid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgiderid.Name = "txtgiderid";
            this.txtgiderid.ReadOnly = true;
            this.txtgiderid.Size = new System.Drawing.Size(192, 30);
            this.txtgiderid.TabIndex = 1;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Lavender;
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnGuncelle.Location = new System.Drawing.Point(315, 525);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(166, 63);
            this.BtnGuncelle.TabIndex = 51;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11F);
            this.label8.Location = new System.Drawing.Point(164, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tarih:";
            // 
            // TxtDiger
            // 
            this.TxtDiger.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtDiger.Location = new System.Drawing.Point(239, 351);
            this.TxtDiger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDiger.Name = "TxtDiger";
            this.TxtDiger.Size = new System.Drawing.Size(192, 30);
            this.TxtDiger.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11F);
            this.label7.Location = new System.Drawing.Point(89, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Diğer Giderler:";
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtPersonel.Location = new System.Drawing.Point(239, 297);
            this.TxtPersonel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(192, 30);
            this.TxtPersonel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11F);
            this.label6.Location = new System.Drawing.Point(81, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Personel Ücreti:";
            // 
            // TxtGida
            // 
            this.TxtGida.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtGida.Location = new System.Drawing.Point(239, 402);
            this.TxtGida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtGida.Name = "TxtGida";
            this.TxtGida.Size = new System.Drawing.Size(192, 30);
            this.TxtGida.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11F);
            this.label5.Location = new System.Drawing.Point(72, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gıda Harcaması:";
            // 
            // TxtInternet
            // 
            this.TxtInternet.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtInternet.Location = new System.Drawing.Point(239, 242);
            this.TxtInternet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(192, 30);
            this.TxtInternet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11F);
            this.label4.Location = new System.Drawing.Point(72, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "İnternet Faturası:";
            // 
            // TxtDogalGaz
            // 
            this.TxtDogalGaz.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtDogalGaz.Location = new System.Drawing.Point(239, 189);
            this.TxtDogalGaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDogalGaz.Name = "TxtDogalGaz";
            this.TxtDogalGaz.Size = new System.Drawing.Size(192, 30);
            this.TxtDogalGaz.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.Location = new System.Drawing.Point(55, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Doğal Gaz Faturası:";
            // 
            // TxtSu
            // 
            this.TxtSu.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtSu.Location = new System.Drawing.Point(239, 139);
            this.TxtSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(192, 30);
            this.TxtSu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F);
            this.label2.Location = new System.Drawing.Point(119, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Su Faturası:";
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtElektrik.Location = new System.Drawing.Point(239, 91);
            this.TxtElektrik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Size = new System.Drawing.Size(192, 30);
            this.TxtElektrik.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F);
            this.label1.Location = new System.Drawing.Point(68, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Elektrik Faturası:";
            // 
            // FrmGiderGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(543, 634);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderGuncelle";
            this.Text = "Gider Güncelle";
            this.Load += new System.EventHandler(this.FrmGiderGuncelle_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDiger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPersonel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtGida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtElektrik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDogalGaz;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgiderid;
        private System.Windows.Forms.ComboBox mskgidertarih;
        private System.Windows.Forms.Button button1;
    }
}