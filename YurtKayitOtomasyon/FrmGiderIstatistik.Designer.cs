namespace YurtKayitOtomasyon
{
    partial class FrmGiderIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderIstatistik));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektrikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet22 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet22();
            this.giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet20 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet20();
            this.LblKasa = new System.Windows.Forms.Label();
            this.KasadakiPara = new System.Windows.Forms.Label();
            this.giderlerTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet20TableAdapters.GiderlerTableAdapter();
            this.giderlerTableAdapter1 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet22TableAdapters.GiderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Georgia", 7.8F);
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Georgia", 7.8F);
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Georgia", 7.8F);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 87);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Aylar";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(482, 329);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihDataGridViewTextBoxColumn,
            this.Toplam,
            this.elektrikDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(498, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 562);
            this.dataGridView1.TabIndex = 1;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // Toplam
            // 
            this.Toplam.DataPropertyName = "AylıkToplam";
            this.Toplam.HeaderText = "Aylık Gider (TL) ";
            this.Toplam.MinimumWidth = 6;
            this.Toplam.Name = "Toplam";
            this.Toplam.Width = 125;
            // 
            // elektrikDataGridViewTextBoxColumn
            // 
            this.elektrikDataGridViewTextBoxColumn.DataPropertyName = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.HeaderText = "Elektrik";
            this.elektrikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elektrikDataGridViewTextBoxColumn.Name = "elektrikDataGridViewTextBoxColumn";
            this.elektrikDataGridViewTextBoxColumn.Width = 125;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            this.suDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "Dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "Doğalgaz";
            this.dogalgazDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            this.dogalgazDataGridViewTextBoxColumn.Width = 125;
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "İnternet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "İnternet";
            this.internetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            this.internetDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            this.personelDataGridViewTextBoxColumn.Width = 125;
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            this.gıdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diğer";
            this.digerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            this.digerDataGridViewTextBoxColumn.Width = 125;
            // 
            // giderlerBindingSource1
            // 
            this.giderlerBindingSource1.DataMember = "Giderler";
            this.giderlerBindingSource1.DataSource = this.yurtOtomasyonuDataSet22;
            // 
            // yurtOtomasyonuDataSet22
            // 
            this.yurtOtomasyonuDataSet22.DataSetName = "YurtOtomasyonuDataSet22";
            this.yurtOtomasyonuDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giderlerBindingSource
            // 
            this.giderlerBindingSource.DataMember = "Giderler";
            this.giderlerBindingSource.DataSource = this.yurtOtomasyonuDataSet20;
            // 
            // yurtOtomasyonuDataSet20
            // 
            this.yurtOtomasyonuDataSet20.DataSetName = "YurtOtomasyonuDataSet20";
            this.yurtOtomasyonuDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.BackColor = System.Drawing.Color.LightSalmon;
            this.LblKasa.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold);
            this.LblKasa.Location = new System.Drawing.Point(319, 442);
            this.LblKasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(41, 39);
            this.LblKasa.TabIndex = 7;
            this.LblKasa.Text = "0";
            // 
            // KasadakiPara
            // 
            this.KasadakiPara.AutoSize = true;
            this.KasadakiPara.BackColor = System.Drawing.Color.LightSalmon;
            this.KasadakiPara.Font = new System.Drawing.Font("Georgia", 20F);
            this.KasadakiPara.Location = new System.Drawing.Point(44, 442);
            this.KasadakiPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KasadakiPara.Name = "KasadakiPara";
            this.KasadakiPara.Size = new System.Drawing.Size(236, 39);
            this.KasadakiPara.TabIndex = 6;
            this.KasadakiPara.Text = "Toplam Gider:";
            // 
            // giderlerTableAdapter
            // 
            this.giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // giderlerTableAdapter1
            // 
            this.giderlerTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmGiderIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 631);
            this.Controls.Add(this.LblKasa);
            this.Controls.Add(this.KasadakiPara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Georgia", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Label KasadakiPara;
        private YurtOtomasyonuDataSet20 yurtOtomasyonuDataSet20;
        private System.Windows.Forms.BindingSource giderlerBindingSource;
        private YurtOtomasyonuDataSet20TableAdapters.GiderlerTableAdapter giderlerTableAdapter;
        private YurtOtomasyonuDataSet22 yurtOtomasyonuDataSet22;
        private System.Windows.Forms.BindingSource giderlerBindingSource1;
        private YurtOtomasyonuDataSet22TableAdapters.GiderlerTableAdapter giderlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektrikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}