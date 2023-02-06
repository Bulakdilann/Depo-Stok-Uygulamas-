
namespace DepoStokUygulamasi_UI
{
    partial class frmPersonelGirisSayfasi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DepoStokUygulamasi_UI.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.tbxSifre);
            this.groupBox1.Controls.Add(this.tbxKullaniciAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(52, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Girişi";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGirisYap.Location = new System.Drawing.Point(121, 181);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(125, 38);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // tbxSifre
            // 
            this.tbxSifre.BackColor = System.Drawing.Color.White;
            this.tbxSifre.Location = new System.Drawing.Point(163, 99);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.PasswordChar = '*';
            this.tbxSifre.Size = new System.Drawing.Size(116, 24);
            this.tbxSifre.TabIndex = 2;
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(163, 45);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(116, 24);
            this.tbxKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // frmPersonelGirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPersonelGirisSayfasi";
            this.Text = "frmPersonelGirisSayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
    }
}