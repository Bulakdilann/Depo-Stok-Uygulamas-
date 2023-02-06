
namespace DepoStokUygulamasi_UI
{
    partial class frmCategories
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKategoriListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKategoriId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxKategoriName = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxFormTemizle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 171);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnKategoriListele
            // 
            this.btnKategoriListele.Location = new System.Drawing.Point(12, 266);
            this.btnKategoriListele.Name = "btnKategoriListele";
            this.btnKategoriListele.Size = new System.Drawing.Size(138, 50);
            this.btnKategoriListele.TabIndex = 6;
            this.btnKategoriListele.Text = "Kategori Listele";
            this.btnKategoriListele.UseVisualStyleBackColor = true;
            this.btnKategoriListele.Click += new System.EventHandler(this.btnKategoriListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Id";
            // 
            // tbxKategoriId
            // 
            this.tbxKategoriId.Enabled = false;
            this.tbxKategoriId.Location = new System.Drawing.Point(117, 38);
            this.tbxKategoriId.Name = "tbxKategoriId";
            this.tbxKategoriId.Size = new System.Drawing.Size(56, 22);
            this.tbxKategoriId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Name";
            // 
            // tbxKategoriName
            // 
            this.tbxKategoriName.Location = new System.Drawing.Point(117, 80);
            this.tbxKategoriName.Name = "tbxKategoriName";
            this.tbxKategoriName.Size = new System.Drawing.Size(100, 22);
            this.tbxKategoriName.TabIndex = 3;
            this.tbxKategoriName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxKategoriName_Validating);
            this.tbxKategoriName.Validated += new System.EventHandler(this.tbxKategoriName_Validated);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(255, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(117, 121);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(100, 22);
            this.tbxDescription.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(257, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxFormTemizle
            // 
            this.tbxFormTemizle.Location = new System.Drawing.Point(257, 179);
            this.tbxFormTemizle.Name = "tbxFormTemizle";
            this.tbxFormTemizle.Size = new System.Drawing.Size(140, 42);
            this.tbxFormTemizle.TabIndex = 5;
            this.tbxFormTemizle.Text = "Formu Temizle";
            this.tbxFormTemizle.UseVisualStyleBackColor = true;
            this.tbxFormTemizle.Click += new System.EventHandler(this.tbxFormTemizle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 556);
            this.Controls.Add(this.tbxFormTemizle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKategoriName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKategoriId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategoriListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCategories";
            this.Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKategoriListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKategoriId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKategoriName;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button tbxFormTemizle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

