namespace YurtKayitOtomasyon
{
    partial class FrmYoneticiDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiDuzenleme));
            this.TxtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.TxtYoneticiID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYoneticiAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.adminBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet5 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet5();
            this.adminBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet5TableAdapters.AdminTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet23 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet23();
            this.girisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.girisTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet23TableAdapters.GirisTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtYoneticiSifre
            // 
            this.TxtYoneticiSifre.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtYoneticiSifre.Location = new System.Drawing.Point(197, 126);
            this.TxtYoneticiSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtYoneticiSifre.Name = "TxtYoneticiSifre";
            this.TxtYoneticiSifre.Size = new System.Drawing.Size(281, 30);
            this.TxtYoneticiSifre.TabIndex = 3;
            // 
            // TxtYoneticiID
            // 
            this.TxtYoneticiID.Enabled = false;
            this.TxtYoneticiID.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtYoneticiID.Location = new System.Drawing.Point(197, 31);
            this.TxtYoneticiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtYoneticiID.Name = "TxtYoneticiID";
            this.TxtYoneticiID.ReadOnly = true;
            this.TxtYoneticiID.Size = new System.Drawing.Size(281, 30);
            this.TxtYoneticiID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(131, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Yönetici ID:";
            // 
            // TxtYoneticiAd
            // 
            this.TxtYoneticiAd.Font = new System.Drawing.Font("Georgia", 12F);
            this.TxtYoneticiAd.Location = new System.Drawing.Point(197, 78);
            this.TxtYoneticiAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtYoneticiAd.Name = "TxtYoneticiAd";
            this.TxtYoneticiAd.Size = new System.Drawing.Size(281, 30);
            this.TxtYoneticiAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Lavender;
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnKaydet.Location = new System.Drawing.Point(56, 194);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(165, 43);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click_1);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Lavender;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnSil.Location = new System.Drawing.Point(227, 194);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(165, 43);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click_1);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.Lavender;
            this.BtnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGüncelle.Font = new System.Drawing.Font("Georgia", 12F);
            this.BtnGüncelle.Location = new System.Drawing.Point(399, 194);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(165, 43);
            this.BtnGüncelle.TabIndex = 6;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click_1);
            // 
            // adminBindingSource3
            // 
            this.adminBindingSource3.DataMember = "Admin";
            this.adminBindingSource3.DataSource = this.yurtOtomasyonuDataSet5;
            // 
            // yurtOtomasyonuDataSet5
            // 
            this.yurtOtomasyonuDataSet5.DataSetName = "YurtOtomasyonuDataSet5";
            this.yurtOtomasyonuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource2
            // 
            this.adminBindingSource2.DataMember = "Admin";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kullaniciAdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.girisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 307);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // yurtOtomasyonuDataSet23
            // 
            this.yurtOtomasyonuDataSet23.DataSetName = "YurtOtomasyonuDataSet23";
            this.yurtOtomasyonuDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // girisBindingSource
            // 
            this.girisBindingSource.DataMember = "Giris";
            this.girisBindingSource.DataSource = this.yurtOtomasyonuDataSet23;
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
            this.kullaniciAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sifre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Şifre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FrmYoneticiDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtYoneticiAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtYoneticiSifre);
            this.Controls.Add(this.TxtYoneticiID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYoneticiDuzenleme";
            this.Text = "Yönetici Düzenleme";
            this.Load += new System.EventHandler(this.FrmYoneticiDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYoneticiSifre;
        private System.Windows.Forms.TextBox TxtYoneticiID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYoneticiAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private System.Windows.Forms.BindingSource adminBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet5 yurtOtomasyonuDataSet5;
        private System.Windows.Forms.BindingSource adminBindingSource3;
        private YurtOtomasyonuDataSet5TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet23 yurtOtomasyonuDataSet23;
        private System.Windows.Forms.BindingSource girisBindingSource;
        private YurtOtomasyonuDataSet23TableAdapters.GirisTableAdapter girisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}