namespace YurtKayitOtomasyon
{
    partial class FrmOgrIzin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrIzin));
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGunGir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzinGun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet10 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet10();
            this.devamsizlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet9 = new YurtKayitOtomasyon.YurtOtomasyonuDataSet9();
            this.devamsizlikTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet9TableAdapters.DevamsizlikTableAdapter();
            this.ogrenciBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.İzinlerTableAdapter = new YurtKayitOtomasyon.YurtOtomasyonuDataSet10TableAdapters.İzinlerTableAdapter();
            this.txtIzinGir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIzin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamsizlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(209, 133);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(247, 30);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Öğrenci Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(209, 80);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(247, 30);
            this.TxtAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Öğrenci Ad:";
            // 
            // BtnGunGir
            // 
            this.BtnGunGir.BackColor = System.Drawing.Color.Lavender;
            this.BtnGunGir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGunGir.Location = new System.Drawing.Point(188, 292);
            this.BtnGunGir.Name = "BtnGunGir";
            this.BtnGunGir.Size = new System.Drawing.Size(287, 48);
            this.BtnGunGir.TabIndex = 6;
            this.BtnGunGir.Text = "İzin Kullan";
            this.BtnGunGir.UseVisualStyleBackColor = false;
            this.BtnGunGir.Click += new System.EventHandler(this.BtnGunGir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kalan İzin:";
            // 
            // TxtOgrId
            // 
            this.TxtOgrId.Enabled = false;
            this.TxtOgrId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrId.Location = new System.Drawing.Point(209, 32);
            this.TxtOgrId.Name = "TxtOgrId";
            this.TxtOgrId.ReadOnly = true;
            this.TxtOgrId.Size = new System.Drawing.Size(247, 30);
            this.TxtOgrId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Öğrenci ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.IzinGun});
            this.dataGridView1.DataSource = this.izinlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(501, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 328);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OgrID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Öğrenci ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OgrAd";
            this.dataGridViewTextBoxColumn2.HeaderText = "Öğrenci Adı";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OgrSoyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Öğrenci Soyadı";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // IzinGun
            // 
            this.IzinGun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IzinGun.DataPropertyName = "IzinGun";
            this.IzinGun.HeaderText = "Kalan İzin (Gün)";
            this.IzinGun.MinimumWidth = 6;
            this.IzinGun.Name = "IzinGun";
            this.IzinGun.ReadOnly = true;
            // 
            // izinlerBindingSource
            // 
            this.izinlerBindingSource.DataMember = "İzinler";
            this.izinlerBindingSource.DataSource = this.yurtOtomasyonuDataSet10;
            // 
            // yurtOtomasyonuDataSet10
            // 
            this.yurtOtomasyonuDataSet10.DataSetName = "YurtOtomasyonuDataSet10";
            this.yurtOtomasyonuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devamsizlikBindingSource
            // 
            this.devamsizlikBindingSource.DataMember = "Devamsizlik";
            this.devamsizlikBindingSource.DataSource = this.yurtOtomasyonuDataSet9;
            // 
            // yurtOtomasyonuDataSet9
            // 
            this.yurtOtomasyonuDataSet9.DataSetName = "YurtOtomasyonuDataSet9";
            this.yurtOtomasyonuDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devamsizlikTableAdapter
            // 
            this.devamsizlikTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciBindingSource4
            // 
            this.ogrenciBindingSource4.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "Ogrenci";
            // 
            // ogrTakipBindingSource
            // 
            this.ogrTakipBindingSource.DataMember = "OgrTakip";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            // 
            // ogrenciBindingSource3
            // 
            this.ogrenciBindingSource3.DataMember = "Ogrenci";
            // 
            // İzinlerTableAdapter
            // 
            this.İzinlerTableAdapter.ClearBeforeFill = true;
            // 
            // txtIzinGir
            // 
            this.txtIzinGir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIzinGir.Location = new System.Drawing.Point(209, 187);
            this.txtIzinGir.Name = "txtIzinGir";
            this.txtIzinGir.Size = new System.Drawing.Size(247, 30);
            this.txtIzinGir.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "İzin Girin (Gün):";
            // 
            // TxtIzin
            // 
            this.TxtIzin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIzin.Location = new System.Drawing.Point(209, 237);
            this.TxtIzin.Name = "TxtIzin";
            this.TxtIzin.ReadOnly = true;
            this.TxtIzin.Size = new System.Drawing.Size(247, 30);
            this.TxtIzin.TabIndex = 5;
            // 
            // FrmOgrIzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1345, 352);
            this.Controls.Add(this.TxtIzin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIzinGir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGunGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrIzin";
            this.Text = "Öğrenci İzinleri";
            this.Load += new System.EventHandler(this.FrmOgrIzin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamsizlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ogrTakipBindingSource;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGunGir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDevamsizlikDataGridViewTextBoxColumn;
        private YurtOtomasyonuDataSet9 yurtOtomasyonuDataSet9;
        private System.Windows.Forms.BindingSource devamsizlikBindingSource;
        private YurtOtomasyonuDataSet9TableAdapters.DevamsizlikTableAdapter devamsizlikTableAdapter;
        private YurtOtomasyonuDataSet10 yurtOtomasyonuDataSet10;
        private System.Windows.Forms.BindingSource izinlerBindingSource;
        private YurtOtomasyonuDataSet10TableAdapters.İzinlerTableAdapter İzinlerTableAdapter;
        private System.Windows.Forms.TextBox txtIzinGir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzinGun;
    }
}