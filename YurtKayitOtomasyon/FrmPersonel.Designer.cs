namespace YurtKayitOtomasyon
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.TxtPersonelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.personelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet15 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet15();
            this.personelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet15TableAdapters.PersonelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet16 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet16();
            this.personelTableAdapter1 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet16TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPersonelID
            // 
            this.TxtPersonelID.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtPersonelID.Location = new System.Drawing.Point(226, 27);
            this.TxtPersonelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPersonelID.Name = "TxtPersonelID";
            this.TxtPersonelID.ReadOnly = true;
            this.TxtPersonelID.Size = new System.Drawing.Size(294, 30);
            this.TxtPersonelID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F);
            this.label1.Location = new System.Drawing.Point(106, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel ID:";
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtPersonelAd.Location = new System.Drawing.Point(226, 75);
            this.TxtPersonelAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(294, 30);
            this.TxtPersonelAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F);
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Adı Soyadı:";
            // 
            // TxtGorev
            // 
            this.TxtGorev.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtGorev.Location = new System.Drawing.Point(226, 126);
            this.TxtGorev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Size = new System.Drawing.Size(294, 30);
            this.TxtGorev.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.Location = new System.Drawing.Point(77, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Görev:";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.Lavender;
            this.BtnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGüncelle.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnGüncelle.Location = new System.Drawing.Point(386, 189);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(161, 43);
            this.BtnGüncelle.TabIndex = 44;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click_1);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Lavender;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnSil.Location = new System.Drawing.Point(226, 189);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(154, 43);
            this.BtnSil.TabIndex = 43;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Lavender;
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnKaydet.Location = new System.Drawing.Point(71, 189);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(149, 43);
            this.BtnKaydet.TabIndex = 42;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // personelBindingSource2
            // 
            this.personelBindingSource2.DataMember = "Personel";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            // 
            // yurtOtomasyonuDataSet15
            // 
            this.yurtOtomasyonuDataSet15.DataSetName = "YurtOtomasyonuDataSet15";
            this.yurtOtomasyonuDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource3
            // 
            this.personelBindingSource3.DataMember = "Personel";
            this.personelBindingSource3.DataSource = this.yurtOtomasyonuDataSet15;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.personelBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 266);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonelID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Personel ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonelAdSoyad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Personel Adı Soyadı";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersonelGorev";
            this.dataGridViewTextBoxColumn3.HeaderText = "Personelin Görevi";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // personelBindingSource4
            // 
            this.personelBindingSource4.DataMember = "Personel";
            this.personelBindingSource4.DataSource = this.yurtOtomasyonuDataSet16;
            // 
            // yurtOtomasyonuDataSet16
            // 
            this.yurtOtomasyonuDataSet16.DataSetName = "YurtOtomasyonuDataSet16";
            this.yurtOtomasyonuDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPersonelAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "Personel Düzenle";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPersonelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private System.Windows.Forms.BindingSource personelBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelGorevDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet15 yurtOtomasyonuDataSet15;
        private System.Windows.Forms.BindingSource personelBindingSource3;
        private YurtOtomasyonuDataSet15TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet16 yurtOtomasyonuDataSet16;
        private System.Windows.Forms.BindingSource personelBindingSource4;
        private YurtOtomasyonuDataSet16TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}