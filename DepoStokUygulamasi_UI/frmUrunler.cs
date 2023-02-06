using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokUygulamasi_UI
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
         ProductManager manager = new ProductManager ();

        Context db=new Context();
        Product db1=new Product();

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllCompanies();
        }
        private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
            dataGridView1.Columns[11].Visible=false;
            dataGridView1.Columns[12].Visible=false;
            dataGridView1.Columns[13].Visible=false;
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
         public void FormuTemizle()
        {
            foreach(Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    item.Text="";
                }

                 if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    item.Text="";
                }
            }
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();
        }

          private void FormuDoldur()
        {
            tbxUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           cbxKategoriId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxBarkodKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxStokMiktari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           cbxBirimId.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxBirimFiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           cbxDepoId.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxRafNo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbxMinStok.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tbxMaxStok.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Product product  = new Product();   //bak
            product.Adi=tbxUrunAdi.Text;
            product.CategoryId=(int)cbxKategoriId.SelectedValue;  //int değilde convertToInt de yapabilirsin
            product.BarkodKodu=tbxBarkodKodu.Text;
            product.StokMiktari=Convert.ToInt32(tbxStokMiktari.Text);
            product.UnitId =(int)cbxBirimId.SelectedValue;
            product.BirimFiyat=Convert.ToDouble(tbxBirimFiyati.Text);
            product.WarehouseId=(int)cbxDepoId.SelectedValue;
            product.RafNo=tbxRafNo.Text;
            product.MinStok=Convert.ToInt32(tbxMinStok.Text);
            product.MaxStok=Convert.ToInt32(tbxMaxStok.Text);
            


            manager.ProductAddBL(product); //bana artık string bir değer dondurecek
           // MessageBox.Show(sonuc);
            FormuTemizle(); //KAYDETTİKTEN Sonra for
            GetAllCompanies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             Product product  = new Product();
            product.Id=Convert.ToInt32(tbxUrunId.Text);
            product.Adi=tbxUrunAdi.Text;
            product.CategoryId=(int)cbxKategoriId.SelectedValue;
            product.BarkodKodu=tbxBarkodKodu.Text;
            product.StokMiktari=Convert.ToInt32(tbxStokMiktari.Text);
            product.UnitId =(int)cbxBirimId.SelectedValue;
            product.BirimFiyat=Convert.ToDouble(tbxBirimFiyati.Text);
            product.WarehouseId=(int)cbxDepoId.SelectedValue;
            product.RafNo=tbxRafNo.Text;
            product.MinStok=Convert.ToInt32(tbxMinStok.Text);
            product.MaxStok=Convert.ToInt32(tbxMaxStok.Text);

            
            manager.ProductUpdateBL(product);
            
            FormuTemizle(); 
            GetAllCompanies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             int urunId = Convert.ToInt32(tbxUrunId.Text);
            
            manager.ProductDeleteBL(urunId);
            GetAllCompanies();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depoStokUygulamasiDataSet2.Warehouses' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.warehousesTableAdapter.Fill(this.depoStokUygulamasiDataSet2.Warehouses);
            // TODO: Bu kod satırı 'depoStokUygulamasiDataSet1.Units' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.unitsTableAdapter.Fill(this.depoStokUygulamasiDataSet1.Units);
            // TODO: Bu kod satırı 'depoStokUygulamasiDataSet.Categories' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.categoriesTableAdapter.Fill(this.depoStokUygulamasiDataSet.Categories);

            GetAllCompanies();

        }

        private void btnKategoriFormuAc_Click(object sender, EventArgs e)
        {
            frmCategories frmcategories=new frmCategories();
            frmcategories.ShowDialog();
        }

        private void btnBirimFormAc_Click(object sender, EventArgs e)
        {
            frmBirimler frmbirimler=new frmBirimler();
            frmbirimler.ShowDialog();
        }

        private void btnDepoFormAc_Click(object sender, EventArgs e)
        {
            frmDepolar frmdepolar=new frmDepolar();
            frmdepolar.ShowDialog();
        }

        private void cbxKategoriId_Click(object sender, EventArgs e)
        {
             this.categoriesTableAdapter.Fill(this.depoStokUygulamasiDataSet.Categories);
        }

        private void cbxBirimId_Click(object sender, EventArgs e)
        {
            this.unitsTableAdapter.Fill(this.depoStokUygulamasiDataSet1.Units);
        }

        private void cbxDepoId_Click(object sender, EventArgs e)
        {
             this.warehousesTableAdapter.Fill(this.depoStokUygulamasiDataSet2.Warehouses);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //ürün adı bulma
        {
          dataGridView1.DataSource=manager.AdaGoreAra(textBox1.Text);
         
        }
    }
}
