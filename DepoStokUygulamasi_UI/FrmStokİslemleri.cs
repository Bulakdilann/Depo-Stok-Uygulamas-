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
    public partial class FrmStokİslemleri : Form
    {
        public FrmStokİslemleri()
        {
            InitializeComponent();
        }
        StockOperationManager manager = new  StockOperationManager ();
        DataTable dataTable=new DataTable();
        
        
        private void FrmStokİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depoStokUygulamasiDataSet4.Products' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.productsTableAdapter.Fill(this.depoStokUygulamasiDataSet4.Products);
            // TODO: Bu kod satırı 'depoStokUygulamasiDataSet3.Companies' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.companiesTableAdapter.Fill(this.depoStokUygulamasiDataSet3.Companies);

             dataTable.Columns.Add("Urun Id", typeof(string));
             dataTable.Columns.Add("Fiyat", typeof(string));
             dataTable.Columns.Add("Adet", typeof(string));
           

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ICollection<StockOperationDetail> details =new List<StockOperationDetail>();
            for (int i = 0; i < (dataGridView1.Rows.Count-1); i++)
            {
                StockOperationDetail stockOperationDetail=new StockOperationDetail();
                stockOperationDetail.ProductId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                stockOperationDetail.UnitPrice = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                stockOperationDetail.Quantity = Convert.ToByte(dataGridView1.Rows[i].Cells[2].Value);

                details.Add(stockOperationDetail);
            }
            StockOperation stokcOperation  = new StockOperation();
            stokcOperation.OperationDate=Convert.ToDateTime(dtpIslemTarihi.Text);
            stokcOperation.CompanyId=(int)cbxFirma.SelectedValue;
            stokcOperation.StockOperationType=cbxIslemTuru.Text;
            stokcOperation.stockOperationDetails=details;
           
            manager.StockOperationAddBL(stokcOperation);
            FormTemizle();
           
          
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
           
        }
        private void FormTemizle()
        {
            cbxFirma.Text="";
            cbxIslemTuru.Text="";
            tbxStokIslemId.Clear();
            dtpIslemTarihi.Text=DateTime.Now.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            StockOperation stokcOperation = new StockOperation();
            stokcOperation.Id = Convert.ToInt32(tbxStokIslemId.Text);
            stokcOperation.OperationDate = Convert.ToDateTime(dtpIslemTarihi.Text);
            stokcOperation.CompanyId = (int)cbxFirma.SelectedValue;
            stokcOperation.StockOperationType = cbxIslemTuru.Text;

            manager.StockOperationUpdateBL(stokcOperation);
            FormTemizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxStokIslemId.Text!="")
            {
                  manager.StockOperationDeleteBL(Convert.ToInt32(tbxStokIslemId.Text));
            }
          
            FormTemizle();
           
        }

        private void cbxUrunler_Click(object sender, EventArgs e)
        {
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            
          
            dataTable.Rows.Add(cbxUrunler.SelectedValue, tbxFiyat.Text, tbxAdet.Text);
            dataGridView1.DataSource=dataTable;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (radioButton2TümKayıtListele.Checked)
            {
                dataGridView2.DataSource=manager.GetAllBL();
            }

            else if (radioButtonÇıkıs.Checked)
            {
                 dataGridView2.DataSource=manager.Cikisİslemi();
            }
             else if (radioButton1.Checked)
            {
                 dataGridView2.DataSource=manager.Girisİslemi();
            }
           
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxStokIslemId.Text=dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cbxFirma.SelectedValue=dataGridView2.CurrentRow.Cells[1].Value;
            cbxIslemTuru.Text=dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dtpIslemTarihi.Text=dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void tbxStokIslemId_TextChanged(object sender, EventArgs e)
        {
            if (tbxStokIslemId.Text!=null && tbxStokIslemId.Text !="")
            {
                 StockOperationDetailManager detailManager =new StockOperationDetailManager();   
                 int stokislemId=Convert.ToInt32(tbxStokIslemId.Text);
                 dataGridView1.DataSource=detailManager.GetAllBL().Where(x=> x.StockOperationId==stokislemId).ToList();

            }
            else
            {
                dataGridView1.DataSource=null;
               
            }
           
        }

        private void btnGirisİslemiOlanlar_Click(object sender, EventArgs e)
        {
           dataGridView2.DataSource= manager.Girisİslemi();
        }
    }
}
