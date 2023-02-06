
namespace DepoStokUygulamasi_UI
{
    partial class FrmStokİslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbxStokIslemId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxIslemTuru = new System.Windows.Forms.ComboBox();
            this.cbxFirma = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet3 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet3();
            this.companiesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet3TableAdapters.CompaniesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxUrunler = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet4 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet4();
            this.label5 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet4TableAdapters.ProductsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGirisİslemiOlanlar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonÇıkıs = new System.Windows.Forms.RadioButton();
            this.radioButton2TümKayıtListele = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok İşlem Id";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(24, 26);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 34);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Yeni Kayıt";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(141, 26);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 33);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(247, 26);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 33);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(350, 27);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 33);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbxStokIslemId
            // 
            this.tbxStokIslemId.Enabled = false;
            this.tbxStokIslemId.Location = new System.Drawing.Point(150, 103);
            this.tbxStokIslemId.Name = "tbxStokIslemId";
            this.tbxStokIslemId.Size = new System.Drawing.Size(100, 22);
            this.tbxStokIslemId.TabIndex = 5;
            this.tbxStokIslemId.TextChanged += new System.EventHandler(this.tbxStokIslemId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "İşlem Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "İşlem Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firma";
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Location = new System.Drawing.Point(150, 173);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpIslemTarihi.TabIndex = 6;
            // 
            // cbxIslemTuru
            // 
            this.cbxIslemTuru.FormattingEnabled = true;
            this.cbxIslemTuru.Items.AddRange(new object[] {
            "Giriş İşlemi",
            "Çıkış İşlemi"});
            this.cbxIslemTuru.Location = new System.Drawing.Point(150, 143);
            this.cbxIslemTuru.Name = "cbxIslemTuru";
            this.cbxIslemTuru.Size = new System.Drawing.Size(121, 24);
            this.cbxIslemTuru.TabIndex = 7;
            // 
            // cbxFirma
            // 
            this.cbxFirma.DataSource = this.companiesBindingSource;
            this.cbxFirma.DisplayMember = "FirmaAdi";
            this.cbxFirma.FormattingEnabled = true;
            this.cbxFirma.Location = new System.Drawing.Point(150, 201);
            this.cbxFirma.Name = "cbxFirma";
            this.cbxFirma.Size = new System.Drawing.Size(121, 24);
            this.cbxFirma.TabIndex = 8;
            this.cbxFirma.ValueMember = "Id";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.depoStokUygulamasiDataSet3;
            // 
            // depoStokUygulamasiDataSet3
            // 
            this.depoStokUygulamasiDataSet3.DataSetName = "DepoStokUygulamasiDataSet3";
            this.depoStokUygulamasiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-34, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDetail);
            this.groupBox1.Controls.Add(this.tbxAdet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxFiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxUrunler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayrıntılar";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(447, 27);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(63, 30);
            this.btnAddDetail.TabIndex = 16;
            this.btnAddDetail.Text = "Ekle";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(378, 27);
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(63, 22);
            this.tbxAdet.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adet";
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(256, 24);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(65, 22);
            this.tbxFiyat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ürün Fiyati";
            // 
            // cbxUrunler
            // 
            this.cbxUrunler.DataSource = this.productsBindingSource;
            this.cbxUrunler.DisplayMember = "Adi";
            this.cbxUrunler.FormattingEnabled = true;
            this.cbxUrunler.Location = new System.Drawing.Point(80, 22);
            this.cbxUrunler.Name = "cbxUrunler";
            this.cbxUrunler.Size = new System.Drawing.Size(95, 24);
            this.cbxUrunler.TabIndex = 11;
            this.cbxUrunler.ValueMember = "Id";
            this.cbxUrunler.Click += new System.EventHandler(this.cbxUrunler_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.depoStokUygulamasiDataSet4;
            // 
            // depoStokUygulamasiDataSet4
            // 
            this.depoStokUygulamasiDataSet4.DataSetName = "DepoStokUygulamasiDataSet4";
            this.depoStokUygulamasiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Seç";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 195);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(504, 174);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(20, 41);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 33);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGirisİslemiOlanlar
            // 
            this.btnGirisİslemiOlanlar.Location = new System.Drawing.Point(128, 41);
            this.btnGirisİslemiOlanlar.Name = "btnGirisİslemiOlanlar";
            this.btnGirisİslemiOlanlar.Size = new System.Drawing.Size(198, 32);
            this.btnGirisİslemiOlanlar.TabIndex = 13;
            this.btnGirisİslemiOlanlar.Text = "Giriş İşlemi Olanları Listele";
            this.btnGirisİslemiOlanlar.UseVisualStyleBackColor = true;
            this.btnGirisİslemiOlanlar.Click += new System.EventHandler(this.btnGirisİslemiOlanlar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2TümKayıtListele);
            this.groupBox2.Controls.Add(this.radioButtonÇıkıs);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnGirisİslemiOlanlar);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(551, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 396);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButtonÇıkıs
            // 
            this.radioButtonÇıkıs.AutoSize = true;
            this.radioButtonÇıkıs.Location = new System.Drawing.Point(128, 89);
            this.radioButtonÇıkıs.Name = "radioButtonÇıkıs";
            this.radioButtonÇıkıs.Size = new System.Drawing.Size(97, 21);
            this.radioButtonÇıkıs.TabIndex = 14;
            this.radioButtonÇıkıs.TabStop = true;
            this.radioButtonÇıkıs.Text = "Çıkış İşlemi";
            this.radioButtonÇıkıs.UseVisualStyleBackColor = true;
            // 
            // radioButton2TümKayıtListele
            // 
            this.radioButton2TümKayıtListele.AutoSize = true;
            this.radioButton2TümKayıtListele.Location = new System.Drawing.Point(128, 118);
            this.radioButton2TümKayıtListele.Name = "radioButton2TümKayıtListele";
            this.radioButton2TümKayıtListele.Size = new System.Drawing.Size(137, 21);
            this.radioButton2TümKayıtListele.TabIndex = 15;
            this.radioButton2TümKayıtListele.TabStop = true;
            this.radioButton2TümKayıtListele.Text = "Tüm Kayıt Listele";
            this.radioButton2TümKayıtListele.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(374, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "giriş";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FrmStokİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxFirma);
            this.Controls.Add(this.cbxIslemTuru);
            this.Controls.Add(this.dtpIslemTarihi);
            this.Controls.Add(this.tbxStokIslemId);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label1);
            this.Name = "FrmStokİslemleri";
            this.Text = "FrmStokİslemleri";
            this.Load += new System.EventHandler(this.FrmStokİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox tbxStokIslemId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.ComboBox cbxIslemTuru;
        private System.Windows.Forms.ComboBox cbxFirma;
        private DepoStokUygulamasiDataSet3 depoStokUygulamasiDataSet3;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private DepoStokUygulamasiDataSet3TableAdapters.CompaniesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxUrunler;
        private System.Windows.Forms.Label label5;
        private DepoStokUygulamasiDataSet4 depoStokUygulamasiDataSet4;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DepoStokUygulamasiDataSet4TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGirisİslemiOlanlar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2TümKayıtListele;
        private System.Windows.Forms.RadioButton radioButtonÇıkıs;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}