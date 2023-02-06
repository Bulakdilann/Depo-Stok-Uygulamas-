using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }
        EmployeeManager manager = new EmployeeManager();

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
             GetAllCompanies();
        }
        private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Adi=tbxAdi.Text;
            employee.Soyadi=tbxSoyadi.Text;
            employee.Gorevi=tbxGorevi.Text;
            employee.KullaniciAdi=tbxKullaniciAdi.Text;
            employee.Sifre=tbxSifre.Text;
            employee.AktifMi=ckbAktifMi.Checked;  //bakkkkk

            manager.EmployeeAddBL(employee);
           // MessageBox.Show(sonuc);
            FormuTemizle(); 
            GetAllCompanies();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

         public void FormuTemizle()
        {
            tbxPersonelId.Clear();
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxGorevi.Clear();
            tbxKullaniciAdi.Clear();
            tbxSifre.Clear();
            ckbAktifMi.Text="";   ///bakk
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id=Convert.ToInt32(tbxPersonelId.Text);
            employee.Adi=tbxAdi.Text;
            employee.Soyadi=tbxSoyadi.Text;
            employee.Gorevi=tbxGorevi.Text;
            employee.KullaniciAdi=tbxKullaniciAdi.Text;
            employee.Sifre=tbxSifre.Text;
            employee.AktifMi=ckbAktifMi.Checked;
             manager.EmployeeUpdateBL(employee);

            
            FormuTemizle(); 
            GetAllCompanies();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
             int personelId = Convert.ToInt32(tbxPersonelId.Text);
            
            manager.EmployeeDeleteBL(personelId);
            GetAllCompanies();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();

        }

         private void FormuDoldur()
        {
            tbxPersonelId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxGorevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ckbAktifMi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           dataGridView1.DataSource= manager.AdaGoreAra(textBox1.Text);
        }

        private void btnaktifmi_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= manager.AktifOlanlar();
        }

        private void btnaktifolmayanlar_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= manager.AktifOlmayanlar();
        }
    }
}
