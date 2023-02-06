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
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
          CompanyManager manager = new CompanyManager();

        private void btnListele_Click(object sender, EventArgs e)
        {
           GetAllCompanies();
        }
         private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.FirmaAdi=tbxFirmaAdi.Text;
            company.FirmaTuru=tbxFirmaTuru.Text;
            company.Adres=tbxAdres.Text;
            company.Telefon=mtbTelefon.Text;
            company.Email=tbxEmail.Text;    
            company.YetkiliKisi= tbxYetkiliKisi.Text;
            company.Aciklama=tbxAdres.Text;
            company.VergiNo=tbxVergiNo.Text;
            company.HesapNo=tbxHesapNo.Text;

            manager.CompanyAddBL(company); //bana artık string bir değer dondurecek
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
            tbxFirmaId.Clear();
            tbxFirmaAdi.Clear();
            tbxFirmaTuru.Clear();
            tbxAdres.Clear();
            mtbTelefon.Clear();
            tbxEmail.Clear();
            tbxYetkiliKisi.Clear();
            tbxAciklama.Clear();
            tbxVergiNo.Clear();
            tbxHesapNo.Clear();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();
        }

         private void FormuDoldur()
        {
            tbxFirmaId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxFirmaAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxFirmaTuru.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtbTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxYetkiliKisi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxVergiNo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbxHesapNo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Id=Convert.ToInt32(tbxFirmaId.Text);
            company.FirmaAdi=tbxFirmaAdi.Text;
            company.FirmaTuru=tbxFirmaTuru.Text;
            company.Adres=tbxAdres.Text;
            company.Telefon=mtbTelefon.Text;
            company.Email=tbxEmail.Text;    
            company.YetkiliKisi= tbxYetkiliKisi.Text;
            company.Aciklama=tbxAdres.Text;
            company.VergiNo=tbxVergiNo.Text;
            company.HesapNo=tbxHesapNo.Text;
            manager.CompanyUpdateBL(company);//bana artık string bir değer dondurecek
            
            FormuTemizle(); 
            GetAllCompanies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             int firmaId = Convert.ToInt32(tbxFirmaId.Text);
            
            manager.CompanyDeleteBL(firmaId);
            GetAllCompanies();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= manager.AdaGoreAra(textBox1.Text);
        }
    }
}
