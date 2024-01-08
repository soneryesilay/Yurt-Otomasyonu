namespace YurtKayitOtomasyon
{
    partial class FrmPSIslem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPSIslem));
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPersonelKAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet14 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet14();
            this.yurtOtomasyonuDataSet13 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet13();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet13TableAdapters.PersonelTableAdapter();
            this.personelTableAdapter1 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet14TableAdapters.PersonelTableAdapter();
            this.BtnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet24 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet24();
            this.girisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet24TableAdapters.GirisTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.Lavender;
            this.BtnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGüncelle.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnGüncelle.Location = new System.Drawing.Point(401, 221);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(181, 43);
            this.BtnGüncelle.TabIndex = 53;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtSifre.Location = new System.Drawing.Point(227, 151);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(294, 30);
            this.TxtSifre.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.Location = new System.Drawing.Point(85, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Personel Şifre:";
            // 
            // TxtPersonelKAd
            // 
            this.TxtPersonelKAd.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtPersonelKAd.Location = new System.Drawing.Point(227, 100);
            this.TxtPersonelKAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPersonelKAd.Name = "TxtPersonelKAd";
            this.TxtPersonelKAd.Size = new System.Drawing.Size(294, 30);
            this.TxtPersonelKAd.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F);
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Personel Kullanıcı Adı:";
            // 
            // TxtPersonelID
            // 
            this.TxtPersonelID.Enabled = false;
            this.TxtPersonelID.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtPersonelID.Location = new System.Drawing.Point(227, 51);
            this.TxtPersonelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPersonelID.Name = "TxtPersonelID";
            this.TxtPersonelID.ReadOnly = true;
            this.TxtPersonelID.Size = new System.Drawing.Size(294, 30);
            this.TxtPersonelID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F);
            this.label1.Location = new System.Drawing.Point(107, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Personel ID:";
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.yurtOtomasyonuDataSet14;
            // 
            // yurtOtomasyonuDataSet14
            // 
            this.yurtOtomasyonuDataSet14.DataSetName = "YurtOtomasyonuDataSet14";
            this.yurtOtomasyonuDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtOtomasyonuDataSet13
            // 
            this.yurtOtomasyonuDataSet13.DataSetName = "YurtOtomasyonuDataSet13";
            this.yurtOtomasyonuDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtOtomasyonuDataSet13;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Lavender;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnSil.Location = new System.Drawing.Point(210, 221);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(185, 43);
            this.BtnSil.TabIndex = 52;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kullaniciAdDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.girisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(600, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 252);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // yurtOtomasyonuDataSet24
            // 
            this.yurtOtomasyonuDataSet24.DataSetName = "YurtOtomasyonuDataSet24";
            this.yurtOtomasyonuDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girisBindingSource
            // 
            this.girisBindingSource.DataMember = "Giris";
            this.girisBindingSource.DataSource = this.yurtOtomasyonuDataSet24;
            // 
            // girisTableAdapter
            // 
            this.girisTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciAdDataGridViewTextBoxColumn
            // 
            this.kullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.kullaniciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdDataGridViewTextBoxColumn.Name = "kullaniciAdDataGridViewTextBoxColumn";
            this.kullaniciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Lavender;
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnKaydet.Location = new System.Drawing.Point(23, 221);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(181, 43);
            this.BtnKaydet.TabIndex = 51;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmPSIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 309);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPersonelKAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPSIslem";
            this.Text = "Personel Şifre İşlemleri";
            this.Load += new System.EventHandler(this.FrmPSIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPersonelKAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonelID;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonuDataSet13 yurtOtomasyonuDataSet13;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtOtomasyonuDataSet13TableAdapters.PersonelTableAdapter personelTableAdapter;
        private YurtOtomasyonuDataSet14 yurtOtomasyonuDataSet14;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private YurtOtomasyonuDataSet14TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet24 yurtOtomasyonuDataSet24;
        private System.Windows.Forms.BindingSource girisBindingSource;
        private YurtOtomasyonuDataSet24TableAdapters.GirisTableAdapter girisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnKaydet;
    }
}