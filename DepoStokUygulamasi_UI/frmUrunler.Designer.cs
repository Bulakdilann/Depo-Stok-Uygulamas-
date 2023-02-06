
namespace DepoStokUygulamasi_UI
{
    partial class frmUrunler
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
            this.tbxUrunId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBarkodKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStokMiktari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxBirimFiyati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxRafNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxMinStok = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxMaxStok = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxKategoriId = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet();
            this.cbxBirimId = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet1 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet1();
            this.cbxDepoId = new System.Windows.Forms.ComboBox();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoStokUygulamasiDataSet2 = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet2();
            this.categoriesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSetTableAdapters.CategoriesTableAdapter();
            this.unitsTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet1TableAdapters.UnitsTableAdapter();
            this.warehousesTableAdapter = new DepoStokUygulamasi_UI.DepoStokUygulamasiDataSet2TableAdapters.WarehousesTableAdapter();
            this.btnKategoriFormuAc = new System.Windows.Forms.Button();
            this.btnBirimFormAc = new System.Windows.Forms.Button();
            this.btnDepoFormAc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUrunId
            // 
            this.tbxUrunId.Enabled = false;
            this.tbxUrunId.Location = new System.Drawing.Point(146, 25);
            this.tbxUrunId.Name = "tbxUrunId";
            this.tbxUrunId.Size = new System.Drawing.Size(100, 22);
            this.tbxUrunId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Id";
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Location = new System.Drawing.Point(146, 53);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.tbxUrunAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori";
            // 
            // tbxBarkodKodu
            // 
            this.tbxBarkodKodu.Location = new System.Drawing.Point(146, 109);
            this.tbxBarkodKodu.Name = "tbxBarkodKodu";
            this.tbxBarkodKodu.Size = new System.Drawing.Size(100, 22);
            this.tbxBarkodKodu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barkod Kodu";
            // 
            // tbxStokMiktari
            // 
            this.tbxStokMiktari.Location = new System.Drawing.Point(146, 137);
            this.tbxStokMiktari.Name = "tbxStokMiktari";
            this.tbxStokMiktari.Size = new System.Drawing.Size(100, 22);
            this.tbxStokMiktari.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stok Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Birim";
            // 
            // tbxBirimFiyati
            // 
            this.tbxBirimFiyati.Location = new System.Drawing.Point(146, 193);
            this.tbxBirimFiyati.Name = "tbxBirimFiyati";
            this.tbxBirimFiyati.Size = new System.Drawing.Size(100, 22);
            this.tbxBirimFiyati.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Birim Fiyati";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dopo";
            // 
            // tbxRafNo
            // 
            this.tbxRafNo.Location = new System.Drawing.Point(146, 249);
            this.tbxRafNo.Name = "tbxRafNo";
            this.tbxRafNo.Size = new System.Drawing.Size(100, 22);
            this.tbxRafNo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Raf No";
            // 
            // tbxMinStok
            // 
            this.tbxMinStok.Location = new System.Drawing.Point(146, 277);
            this.tbxMinStok.Name = "tbxMinStok";
            this.tbxMinStok.Size = new System.Drawing.Size(100, 22);
            this.tbxMinStok.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Min Stok";
            // 
            // tbxMaxStok
            // 
            this.tbxMaxStok.Location = new System.Drawing.Point(146, 305);
            this.tbxMaxStok.Name = "tbxMaxStok";
            this.tbxMaxStok.Size = new System.Drawing.Size(100, 22);
            this.tbxMaxStok.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Max Stok";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(481, 21);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 37);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(481, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 37);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(481, 187);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(120, 35);
            this.btnFormTemizle.TabIndex = 16;
            this.btnFormTemizle.Text = "Formu Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 356);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(138, 42);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 186);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cbxKategoriId
            // 
            this.cbxKategoriId.DataSource = this.categoriesBindingSource;
            this.cbxKategoriId.DisplayMember = "Name";
            this.cbxKategoriId.FormattingEnabled = true;
            this.cbxKategoriId.Location = new System.Drawing.Point(146, 79);
            this.cbxKategoriId.Name = "cbxKategoriId";
            this.cbxKategoriId.Size = new System.Drawing.Size(121, 24);
            this.cbxKategoriId.TabIndex = 1;
            this.cbxKategoriId.ValueMember = "Id";
            this.cbxKategoriId.Click += new System.EventHandler(this.cbxKategoriId_Click);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.depoStokUygulamasiDataSet;
            // 
            // depoStokUygulamasiDataSet
            // 
            this.depoStokUygulamasiDataSet.DataSetName = "DepoStokUygulamasiDataSet";
            this.depoStokUygulamasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxBirimId
            // 
            this.cbxBirimId.DataSource = this.unitsBindingSource;
            this.cbxBirimId.DisplayMember = "BirimAdi";
            this.cbxBirimId.FormattingEnabled = true;
            this.cbxBirimId.Location = new System.Drawing.Point(146, 163);
            this.cbxBirimId.Name = "cbxBirimId";
            this.cbxBirimId.Size = new System.Drawing.Size(121, 24);
            this.cbxBirimId.TabIndex = 4;
            this.cbxBirimId.ValueMember = "Id";
            this.cbxBirimId.Click += new System.EventHandler(this.cbxBirimId_Click);
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.depoStokUygulamasiDataSet1;
            // 
            // depoStokUygulamasiDataSet1
            // 
            this.depoStokUygulamasiDataSet1.DataSetName = "DepoStokUygulamasiDataSet1";
            this.depoStokUygulamasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxDepoId
            // 
            this.cbxDepoId.DataSource = this.warehousesBindingSource;
            this.cbxDepoId.DisplayMember = "DepoAdi";
            this.cbxDepoId.FormattingEnabled = true;
            this.cbxDepoId.Location = new System.Drawing.Point(146, 219);
            this.cbxDepoId.Name = "cbxDepoId";
            this.cbxDepoId.Size = new System.Drawing.Size(121, 24);
            this.cbxDepoId.TabIndex = 6;
            this.cbxDepoId.ValueMember = "Id";
            this.cbxDepoId.Click += new System.EventHandler(this.cbxDepoId_Click);
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            this.warehousesBindingSource.DataSource = this.depoStokUygulamasiDataSet2;
            // 
            // depoStokUygulamasiDataSet2
            // 
            this.depoStokUygulamasiDataSet2.DataSetName = "DepoStokUygulamasiDataSet2";
            this.depoStokUygulamasiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // btnKategoriFormuAc
            // 
            this.btnKategoriFormuAc.Location = new System.Drawing.Point(274, 77);
            this.btnKategoriFormuAc.Name = "btnKategoriFormuAc";
            this.btnKategoriFormuAc.Size = new System.Drawing.Size(74, 26);
            this.btnKategoriFormuAc.TabIndex = 11;
            this.btnKategoriFormuAc.Text = "Ekle";
            this.btnKategoriFormuAc.UseVisualStyleBackColor = true;
            this.btnKategoriFormuAc.Click += new System.EventHandler(this.btnKategoriFormuAc_Click);
            // 
            // btnBirimFormAc
            // 
            this.btnBirimFormAc.Location = new System.Drawing.Point(274, 163);
            this.btnBirimFormAc.Name = "btnBirimFormAc";
            this.btnBirimFormAc.Size = new System.Drawing.Size(74, 24);
            this.btnBirimFormAc.TabIndex = 12;
            this.btnBirimFormAc.Text = "Ekle";
            this.btnBirimFormAc.UseVisualStyleBackColor = true;
            this.btnBirimFormAc.Click += new System.EventHandler(this.btnBirimFormAc_Click);
            // 
            // btnDepoFormAc
            // 
            this.btnDepoFormAc.Location = new System.Drawing.Point(274, 218);
            this.btnDepoFormAc.Name = "btnDepoFormAc";
            this.btnDepoFormAc.Size = new System.Drawing.Size(74, 25);
            this.btnDepoFormAc.TabIndex = 7;
            this.btnDepoFormAc.Text = "Ekle";
            this.btnDepoFormAc.UseVisualStyleBackColor = true;
            this.btnDepoFormAc.Click += new System.EventHandler(this.btnDepoFormAc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ürün Adına Göre Ara";
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 635);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDepoFormAc);
            this.Controls.Add(this.btnBirimFormAc);
            this.Controls.Add(this.btnKategoriFormuAc);
            this.Controls.Add(this.cbxDepoId);
            this.Controls.Add(this.cbxBirimId);
            this.Controls.Add(this.cbxKategoriId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnFormTemizle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMaxStok);
            this.Controls.Add(this.tbxMinStok);
            this.Controls.Add(this.tbxRafNo);
            this.Controls.Add(this.tbxBirimFiyati);
            this.Controls.Add(this.tbxStokMiktari);
            this.Controls.Add(this.tbxBarkodKodu);
            this.Controls.Add(this.tbxUrunAdi);
            this.Controls.Add(this.tbxUrunId);
            this.Name = "frmUrunler";
            this.Text = "frmUrunler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoStokUygulamasiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrunId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBarkodKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxStokMiktari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxBirimFiyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxRafNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxMinStok;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxMaxStok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxKategoriId;
        private System.Windows.Forms.ComboBox cbxBirimId;
        private System.Windows.Forms.ComboBox cbxDepoId;
        private DepoStokUygulamasiDataSet depoStokUygulamasiDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DepoStokUygulamasiDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DepoStokUygulamasiDataSet1 depoStokUygulamasiDataSet1;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private DepoStokUygulamasiDataSet1TableAdapters.UnitsTableAdapter unitsTableAdapter;
        private DepoStokUygulamasiDataSet2 depoStokUygulamasiDataSet2;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private DepoStokUygulamasiDataSet2TableAdapters.WarehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.Button btnKategoriFormuAc;
        private System.Windows.Forms.Button btnBirimFormAc;
        private System.Windows.Forms.Button btnDepoFormAc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}