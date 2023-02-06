
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
    public partial class frmDepolar : Form
    {
        public frmDepolar()
        {
            InitializeComponent();
        }
         WarehouseManager manager = new WarehouseManager ();

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllCompanies();
        }
         private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
            // dataGridView1.Columns[4].Visible=false; bak buna bi
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbxDepoAdi.Text != "")
            {
            Warehouse warehouse  = new Warehouse ();
            warehouse.DepoAdi=tbxDepoAdi.Text;
            warehouse.Aciklama=tbxAciklama.Text;
            warehouse.DepoYetkilisi=tbxDepoYetkilisi.Text;
            warehouse.Telefon=mtbTelefon.Text;
            manager.WarehouseAddBL(warehouse); //bana artık string bir değer dondurecek
            
            FormuTemizle(); //KAYDETTİKTEN Sonra for
            GetAllCompanies();
            MessageBox.Show("depo başarılı bir şekilde kaydoldu");
            }
            else
            {
                MessageBox.Show("depo adı boş geçilemez");
            }
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

         public void FormuTemizle()
        {
             foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    item.Text = "";
                }                
            }
            mtbTelefon.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();
        }

         private void FormuDoldur()
        {
            tbxDepoId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxDepoAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxDepoYetkilisi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mtbTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           if (tbxDepoAdi.Text != "")
            {
            Warehouse warehouse  = new Warehouse();
            warehouse.Id=Convert.ToInt32(tbxDepoId.Text);
            warehouse.DepoAdi=tbxDepoAdi.Text;
            warehouse.Aciklama=tbxAciklama.Text;
            warehouse.DepoYetkilisi=tbxDepoYetkilisi.Text;
            warehouse.Telefon=mtbTelefon.Text;
            manager.WarehouseUpdateBL(warehouse);
            
            FormuTemizle(); 
            GetAllCompanies();
                MessageBox.Show("Depo güncellendi.");
            }
            else
            {
                MessageBox.Show("Depo Adı boş geçilemez.");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxDepoId.Text != "")
            {
             int depoId = Convert.ToInt32(tbxDepoId.Text);
            
            manager.WarehouseDeleteBL(depoId);
            GetAllCompanies();
            MessageBox.Show("Kayıt başaıyla silindi");
            }
            else
            {
                MessageBox.Show("id alanı boş geçilemez..");
            }
        }
    }
}
