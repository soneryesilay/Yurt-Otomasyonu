namespace YurtKayitOtomasyon
{
    partial class FrmGiderListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderListesi));
            this.giderlerBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet2 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet2();
            this.giderlerTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet2TableAdapters.GiderlerTableAdapter();
            this.yurtOtomasyonuDataSet17 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet17();
            this.giderlerBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerTableAdapter1 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet17TableAdapters.GiderlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet18 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet18();
            this.giderlerTableAdapter2 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet18TableAdapters.GiderlerTableAdapter();
            this.giderlerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.giderlerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // giderlerBindingSource5
            // 
            this.giderlerBindingSource5.DataMember = "Giderler";
            this.giderlerBindingSource5.DataSource = this.yurtOtomasyonuDataSet2;
            // 
            // yurtOtomasyonuDataSet2
            // 
            this.yurtOtomasyonuDataSet2.DataSetName = "YurtOtomasyonuDataSet2";
            this.yurtOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // yurtOtomasyonuDataSet17
            // 
            this.yurtOtomasyonuDataSet17.DataSetName = "YurtOtomasyonuDataSet17";
            this.yurtOtomasyonuDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerBindingSource6
            // 
            this.giderlerBindingSource6.DataMember = "Giderler";
            this.giderlerBindingSource6.DataSource = this.yurtOtomasyonuDataSet17;
            // 
            // giderlerTableAdapter1
            // 
            this.giderlerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn,
            this.elektrikDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.giderlerBindingSource7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GiderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Gider ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            this.elektrikDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Su";
            this.dataGridViewTextBoxColumn2.HeaderText = "Su";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dogalgaz";
            this.dataGridViewTextBoxColumn3.HeaderText = "Doğalgaz";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "İnternet";
            this.dataGridViewTextBoxColumn4.HeaderText = "İnternet";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Personel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Personel";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gıda";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gıda";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Diger";
            this.dataGridViewTextBoxColumn7.HeaderText = "Diğer";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // giderlerBindingSource7
            // 
            this.giderlerBindingSource7.DataMember = "Giderler";
            this.giderlerBindingSource7.DataSource = this.yurtOtomasyonuDataSet18;
            // 
            // yurtOtomasyonuDataSet18
            // 
            this.yurtOtomasyonuDataSet18.DataSetName = "YurtOtomasyonuDataSet18";
            this.yurtOtomasyonuDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerTableAdapter2
            // 
            this.giderlerTableAdapter2.ClearBeforeFill = true;
            // 
            // giderlerBindingSource4
            // 
            this.giderlerBindingSource4.DataMember = "Giderler";
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            // 
            // giderlerBindingSource1
            // 
            this.giderlerBindingSource1.DataMember = "Giderler";
            // 
            // giderlerBindingSource2
            // 
            this.giderlerBindingSource2.DataMember = "Giderler";
            // 
            // giderlerBindingSource3
            // 
            this.giderlerBindingSource3.DataMember = "Giderler";
            // 
            // FrmGiderListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1180, 304);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderListesi";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
     
        private System.Windows.Forms.BindingSource giderlerBindingSource;
       
   
        private System.Windows.Forms.BindingSource giderlerBindingSource1;
    
        private System.Windows.Forms.BindingSource giderlerBindingSource2;
       
        private System.Windows.Forms.BindingSource giderlerBindingSource3;
      
        private System.Windows.Forms.BindingSource giderlerBindingSource4;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn giderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektirikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet2 yurtOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource giderlerBindingSource5;
        private YurtOtomasyonuDataSet2TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private YurtOtomasyonuDataSet17 yurtOtomasyonuDataSet17;
        private System.Windows.Forms.BindingSource giderlerBindingSource6;
        private YurtOtomasyonuDataSet17TableAdapters.GiderlerTableAdapter giderlerTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet18 yurtOtomasyonuDataSet18;
        private System.Windows.Forms.BindingSource giderlerBindingSource7;
        private YurtOtomasyonuDataSet18TableAdapters.GiderlerTableAdapter giderlerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}