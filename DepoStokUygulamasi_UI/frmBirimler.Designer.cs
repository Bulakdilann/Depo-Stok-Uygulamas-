
namespace DepoStokUygulamasi_UI
{
    partial class frmBirimler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBirimAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBirimId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAciklama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 211);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(27, 200);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(134, 43);
            this.btnListele.TabIndex = 33;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(353, 153);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(117, 33);
            this.btnFormTemizle.TabIndex = 32;
            this.btnFormTemizle.Text = "Formu Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 35);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(353, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 34);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Açıklama";
            // 
            // tbxBirimAdi
            // 
            this.tbxBirimAdi.Location = new System.Drawing.Point(148, 45);
            this.tbxBirimAdi.Name = "tbxBirimAdi";
            this.tbxBirimAdi.Size = new System.Drawing.Size(100, 22);
            this.tbxBirimAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birim Adı";
            // 
            // tbxBirimId
            // 
            this.tbxBirimId.Enabled = false;
            this.tbxBirimId.Location = new System.Drawing.Point(148, 17);
            this.tbxBirimId.Name = "tbxBirimId";
            this.tbxBirimId.Size = new System.Drawing.Size(50, 22);
            this.tbxBirimId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Birim Id";
            // 
            // tbxAciklama
            // 
            this.tbxAciklama.Location = new System.Drawing.Point(148, 73);
            this.tbxAciklama.Name = "tbxAciklama";
            this.tbxAciklama.Size = new System.Drawing.Size(100, 22);
            this.tbxAciklama.TabIndex = 1;
            // 
            // frmBirimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnFormTemizle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbxAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBirimAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBirimId);
            this.Controls.Add(this.label1);
            this.Name = "frmBirimler";
            this.Text = "Birimler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBirimAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBirimId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAciklama;
    }
}