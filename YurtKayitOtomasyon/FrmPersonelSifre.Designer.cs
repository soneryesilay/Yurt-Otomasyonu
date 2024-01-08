namespace YurtKayitOtomasyon
{
    partial class FrmPersonelSifre
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
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEskiSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.TxtYeniSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtKullaniciAd.Location = new System.Drawing.Point(191, 174);
            this.TxtKullaniciAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(158, 30);
            this.TxtKullaniciAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F);
            this.label2.Location = new System.Drawing.Point(33, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adınız:";
            // 
            // TxtEskiSifre
            // 
            this.TxtEskiSifre.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtEskiSifre.Location = new System.Drawing.Point(191, 225);
            this.TxtEskiSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEskiSifre.Name = "TxtEskiSifre";
            this.TxtEskiSifre.Size = new System.Drawing.Size(158, 30);
            this.TxtEskiSifre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.Location = new System.Drawing.Point(63, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eski Şifreniz:";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.Lavender;
            this.BtnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGüncelle.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnGüncelle.Location = new System.Drawing.Point(65, 362);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(284, 43);
            this.BtnGüncelle.TabIndex = 4;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtYeniSifre
            // 
            this.TxtYeniSifre.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtYeniSifre.Location = new System.Drawing.Point(191, 281);
            this.TxtYeniSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtYeniSifre.Name = "TxtYeniSifre";
            this.TxtYeniSifre.Size = new System.Drawing.Size(158, 30);
            this.TxtYeniSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F);
            this.label1.Location = new System.Drawing.Point(61, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Yeni Şifreniz:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YurtKayitOtomasyon.Properties.Resources.padlock;
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPersonelSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtYeniSifre);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.TxtEskiSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Değiştir";
            this.Load += new System.EventHandler(this.FrmPersonelSifre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEskiSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtYeniSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}