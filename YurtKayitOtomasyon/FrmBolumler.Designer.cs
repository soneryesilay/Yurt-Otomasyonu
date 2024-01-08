namespace YurtKayitOtomasyon
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bolumlerBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet1 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet1();
            this.bolumlerTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet1TableAdapters.BolumlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcbBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.PcbBolumSil = new System.Windows.Forms.PictureBox();
            this.PcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.bolumlerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID:";
            // 
            // TxtBolumID
            // 
            this.TxtBolumID.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBolumID.Enabled = false;
            this.TxtBolumID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumID.Location = new System.Drawing.Point(122, 29);
            this.TxtBolumID.Name = "TxtBolumID";
            this.TxtBolumID.Size = new System.Drawing.Size(239, 30);
            this.TxtBolumID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.Location = new System.Drawing.Point(122, 86);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(239, 30);
            this.TxtBolumAd.TabIndex = 2;
            // 
            // bolumlerBindingSource5
            // 
            this.bolumlerBindingSource5.DataMember = "Bolumler";
            this.bolumlerBindingSource5.DataSource = this.yurtOtomasyonuDataSet1;
            // 
            // yurtOtomasyonuDataSet1
            // 
            this.yurtOtomasyonuDataSet1.DataSetName = "YurtOtomasyonuDataSet1";
            this.yurtOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.bolumlerBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 311);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BolumID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bölüm ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BolumAd";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bölüm Adı";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PcbBolumDuzenle
            // 
            this.PcbBolumDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbBolumDuzenle.Image = global::YurtKayitOtomasyon.Properties.Resources.editing;
            this.PcbBolumDuzenle.Location = new System.Drawing.Point(429, 77);
            this.PcbBolumDuzenle.Name = "PcbBolumDuzenle";
            this.PcbBolumDuzenle.Size = new System.Drawing.Size(63, 59);
            this.PcbBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBolumDuzenle.TabIndex = 2;
            this.PcbBolumDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumDuzenle, "Bölüm Düzenle");
            this.PcbBolumDuzenle.Click += new System.EventHandler(this.PcbBolumDuzenle_Click);
            // 
            // PcbBolumSil
            // 
            this.PcbBolumSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbBolumSil.Image = global::YurtKayitOtomasyon.Properties.Resources.trash;
            this.PcbBolumSil.Location = new System.Drawing.Point(498, 44);
            this.PcbBolumSil.Name = "PcbBolumSil";
            this.PcbBolumSil.Size = new System.Drawing.Size(63, 59);
            this.PcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBolumSil.TabIndex = 1;
            this.PcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumSil, "Bölüm Sil");
            this.PcbBolumSil.Click += new System.EventHandler(this.PcbBolumSil_Click);
            // 
            // PcbBolumEkle
            // 
            this.PcbBolumEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbBolumEkle.Image = global::YurtKayitOtomasyon.Properties.Resources.add;
            this.PcbBolumEkle.Location = new System.Drawing.Point(429, 12);
            this.PcbBolumEkle.Name = "PcbBolumEkle";
            this.PcbBolumEkle.Size = new System.Drawing.Size(63, 59);
            this.PcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBolumEkle.TabIndex = 0;
            this.PcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumEkle, "Bölüm Ekle");
            this.PcbBolumEkle.Click += new System.EventHandler(this.PcbBolumEkle_Click);
            // 
            // bolumlerBindingSource4
            // 
            this.bolumlerBindingSource4.DataMember = "Bolumler";
            // 
            // bolumlerBindingSource1
            // 
            this.bolumlerBindingSource1.DataMember = "Bolumler";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            // 
            // bolumlerBindingSource2
            // 
            this.bolumlerBindingSource2.DataMember = "Bolumler";
            // 
            // bolumlerBindingSource3
            // 
            this.bolumlerBindingSource3.DataMember = "Bolumler";
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbBolumDuzenle);
            this.Controls.Add(this.PcbBolumSil);
            this.Controls.Add(this.PcbBolumEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbBolumEkle;
        private System.Windows.Forms.PictureBox PcbBolumSil;
        private System.Windows.Forms.PictureBox PcbBolumDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
      
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
      
        private System.Windows.Forms.ToolTip toolTip1;
     
        private System.Windows.Forms.BindingSource bolumlerBindingSource1;
        
        private System.Windows.Forms.BindingSource bolumlerBindingSource2;
        
        private System.Windows.Forms.BindingSource bolumlerBindingSource3;
      
        private System.Windows.Forms.BindingSource bolumlerBindingSource4;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet1 yurtOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource bolumlerBindingSource5;
        private YurtOtomasyonuDataSet1TableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}