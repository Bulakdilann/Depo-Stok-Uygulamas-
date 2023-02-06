using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokUygulamasi_UI
{
    public partial class frmPersonelGirisSayfasi : Form
    {
        public frmPersonelGirisSayfasi()
        {
            InitializeComponent();
        }
        EmployeeManager manager=new EmployeeManager();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (manager.IsUserExist(tbxKullaniciAdi.Text,tbxSifre.Text))
            {
                MessageBox.Show("Giriş Başarılı");
                 FrmAnasayfa frmAnasayfa =new FrmAnasayfa();
                 frmAnasayfa.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
                tbxKullaniciAdi.Clear();
                tbxSifre.Clear();
                tbxKullaniciAdi.Focus(); // imleç tekrardan kullanıcı adına gidecek.
            }
           //string durum= manager.GetEmployee(tbxKullaniciAdi.Text,tbxSifre.Text);
           // MessageBox.Show(durum);

        }
    }
}
