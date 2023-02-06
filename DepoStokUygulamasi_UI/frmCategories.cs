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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
        CategoryManager manager = new CategoryManager();

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
           GetAllCompanies();
            //dataGridView1.Rows[3].Visible=false;
        }
        private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Category category = new Category();  //dbset ten gelmiyor. biz uretiyoruz.
            category.Name = tbxKategoriName.Text;
            category.Description=tbxDescription.Text;
            string sonuc= manager.CategoryAddBL(category); //bana artık string bir değer dondurecek
            MessageBox.Show(sonuc);
            FormuTemizle(); //KAYDETTİKTEN Sonra formu temizlesin
            GetAllCompanies();
        }
        private void tbxFormTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        public void FormuTemizle()
        {
            tbxKategoriId.Clear();
            tbxKategoriName.Clear();
            tbxDescription.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e) //bak
        {
            Category category = new Category();
            category.Id=Convert.ToInt32(tbxKategoriId.Text);
            category.Name = tbxKategoriName.Text;
            category.Description=tbxDescription.Text;
            manager.CategoryUpdateBL(category);//bana artık string bir değer dondurecek
            
            FormuTemizle(); 
            GetAllCompanies();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();
        }

        private void FormuDoldur()
        {
            tbxKategoriId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxKategoriName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value != null)
            {
                tbxDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

         private void btnDelete_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(tbxKategoriId.Text);
            
            manager.CategoryDeleteBL(categoryId);
            GetAllCompanies();
        }

        private void tbxKategoriName_Validated(object sender, EventArgs e)
        {

        }

        private void tbxKategoriName_Validating(object sender, CancelEventArgs e)
        {
            if (tbxKategoriName.Text=="")
            {
                e.Cancel=true;
                errorProvider1.SetError(tbxKategoriName,"Category name alanı boş geçilemez");
            }
            else if(tbxKategoriName.Text.Length<3)
                {
                 e.Cancel=true;
                errorProvider1.SetError(tbxKategoriName,"categori NAME ALANI en az 3 karakter olmalıdır.");
                }
            else
            {
                e.Cancel=false;
                errorProvider1.SetError(tbxKategoriName,"");
            }
        }
    }
}
