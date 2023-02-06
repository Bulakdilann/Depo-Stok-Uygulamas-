
namespace DepoStokUygulamasi_UI
{
    partial class frmDepolar
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
            this.tbxAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDepoAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDepoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDepoYetkilisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 211);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(25, 290);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(134, 43);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(351, 156);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(117, 33);
            this.btnFormTemizle.TabIndex = 7;
            this.btnFormTemizle.Text = "Formu Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(351, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 35);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(351, 31);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 34);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbxAciklama
            // 
            this.tbxAciklama.Location = new System.Drawing.Point(146, 76);
            this.tbxAciklama.Name = "tbxAciklama";
            this.tbxAciklama.Size = new System.Drawing.Size(100, 22);
            this.tbxAciklama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Açıklama";
            // 
            // tbxDepoAdi
            // 
            this.tbxDepoAdi.Location = new System.Drawing.Point(146, 48);
            this.tbxDepoAdi.Name = "tbxDepoAdi";
            this.tbxDepoAdi.Size = new System.Drawing.Size(100, 22);
            this.tbxDepoAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Depo Adı";
            // 
            // tbxDepoId
            // 
            this.tbxDepoId.Enabled = false;
            this.tbxDepoId.Location = new System.Drawing.Point(146, 20);
            this.tbxDepoId.Name = "tbxDepoId";
            this.tbxDepoId.Size = new System.Drawing.Size(50, 22);
            this.tbxDepoId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Depo Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Depo Yetkilisi";
            // 
            // tbxDepoYetkilisi
            // 
            this.tbxDepoYetkilisi.Location = new System.Drawing.Point(146, 104);
            this.tbxDepoYetkilisi.Name = "tbxDepoYetkilisi";
            this.tbxDepoYetkilisi.Size = new System.Drawing.Size(100, 22);
            this.tbxDepoYetkilisi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefon";
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(146, 133);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(100, 22);
            this.mtbTelefon.TabIndex = 3;
            // 
            // frmDepolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 562);
            this.Controls.Add(this.mtbTelefon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnFormTemizle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDepoYetkilisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDepoAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDepoId);
            this.Controls.Add(this.label1);
            this.Name = "frmDepolar";
            this.Text = "frmDepolar";
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
        private System.Windows.Forms.TextBox tbxAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDepoAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDepoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDepoYetkilisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
    }
}