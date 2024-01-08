namespace YurtKayitOtomasyon
{
    partial class FrmOgrListcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrListcs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrBolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet19 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet19();
            this.ogrenciBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet3 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet3();
            this.ogrenciBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet3TableAdapters.OgrenciTableAdapter();
            this.ogrenciTableAdapter1 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet19TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.OgrBolum,
            this.OgrMail,
            this.OgrOdaNo,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.dataGridView1.DataSource = this.ogrenciBindingSource6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OgrID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Öğrenci ID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OgrAd";
            this.dataGridViewTextBoxColumn10.HeaderText = "Öğrenci Adı";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OgrSoyad";
            this.dataGridViewTextBoxColumn11.HeaderText = "Öğrenci Soyadı";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OgrTC";
            this.dataGridViewTextBoxColumn12.HeaderText = "Öğrenci TC";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OgrTelefon";
            this.dataGridViewTextBoxColumn13.HeaderText = "Öğrenci Telefon No";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OgrDogum";
            this.dataGridViewTextBoxColumn14.HeaderText = "Öğrenci Doğum Tarihi";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // OgrBolum
            // 
            this.OgrBolum.DataPropertyName = "OgrBolum";
            this.OgrBolum.HeaderText = "Öğrenci Bölüm";
            this.OgrBolum.MinimumWidth = 6;
            this.OgrBolum.Name = "OgrBolum";
            this.OgrBolum.ReadOnly = true;
            this.OgrBolum.Width = 125;
            // 
            // OgrMail
            // 
            this.OgrMail.DataPropertyName = "OgrMail";
            this.OgrMail.HeaderText = "Öğrenci Mail";
            this.OgrMail.MinimumWidth = 6;
            this.OgrMail.Name = "OgrMail";
            this.OgrMail.ReadOnly = true;
            this.OgrMail.Width = 125;
            // 
            // OgrOdaNo
            // 
            this.OgrOdaNo.DataPropertyName = "OgrOdaNo";
            this.OgrOdaNo.HeaderText = "Öğrenci Oda No";
            this.OgrOdaNo.MinimumWidth = 6;
            this.OgrOdaNo.Name = "OgrOdaNo";
            this.OgrOdaNo.ReadOnly = true;
            this.OgrOdaNo.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "OgrKayitTarihi";
            this.dataGridViewTextBoxColumn16.HeaderText = "Kayıt Tarihi";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "OgrVeliAdSoyad";
            this.dataGridViewTextBoxColumn17.HeaderText = "Veli Adı Soyadı";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "OgrVeliTelefon";
            this.dataGridViewTextBoxColumn18.HeaderText = "Veli Telefon No";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "OgrVeliAdres";
            this.dataGridViewTextBoxColumn19.HeaderText = "Veli Adresi";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // ogrenciBindingSource6
            // 
            this.ogrenciBindingSource6.DataMember = "Ogrenci";
            this.ogrenciBindingSource6.DataSource = this.yurtOtomasyonuDataSet19;
            // 
            // yurtOtomasyonuDataSet19
            // 
            this.yurtOtomasyonuDataSet19.DataSetName = "YurtOtomasyonuDataSet19";
            this.yurtOtomasyonuDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource5
            // 
            this.ogrenciBindingSource5.DataMember = "Ogrenci";
            this.ogrenciBindingSource5.DataSource = this.yurtOtomasyonuDataSet3;
            // 
            // yurtOtomasyonuDataSet3
            // 
            this.yurtOtomasyonuDataSet3.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource4
            // 
            this.ogrenciBindingSource4.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource3
            // 
            this.ogrenciBindingSource3.DataMember = "Ogrenci";
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmOgrListcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1086, 384);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrListcs";
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.FrmOgrListcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdresDataGridViewTextBoxColumn;

        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private System.Windows.Forms.BindingSource ogrenciBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKayitTarihiDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource ogrenciBindingSource5;
        private YurtOtomasyonuDataSet3TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private YurtOtomasyonuDataSet19 yurtOtomasyonuDataSet19;
        private System.Windows.Forms.BindingSource ogrenciBindingSource6;
        private YurtOtomasyonuDataSet19TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrBolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrOdaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}