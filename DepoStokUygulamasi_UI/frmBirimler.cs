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
    public partial class frmBirimler : Form
    {
        public frmBirimler()
        {
            InitializeComponent();
        }
          UnitManager manager = new UnitManager();

        private void btnListele_Click(object sender, EventArgs e)
        {
             GetAllCompanies();
        }
         private void GetAllCompanies()
        {
            dataGridView1.DataSource = manager.GetAllBL();
            dataGridView1.Columns[3].Visible=false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Unit unit = new Unit();
            unit.BirimAdi=tbxBirimAdi.Text;
            unit.Aciklama=tbxAciklama.Text;

            manager.UnitAddBL(unit); 
            
            FormuTemizle(); 
            GetAllCompanies();  //LİSTELEME BUU
            MessageBox.Show("Birim kaydedildi");
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
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormuDoldur();
        }

         private void FormuDoldur()
        {
            tbxBirimId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxBirimAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxAciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           if (tbxBirimAdi.Text != "")
            {
            Unit unit = new Unit();
            unit.Id=Convert.ToInt32(tbxBirimId.Text);
            unit.BirimAdi=tbxBirimAdi.Text;
            unit.Aciklama=tbxAciklama.Text;
            manager.UnitUpdateBL(unit);
            
            FormuTemizle(); 
            GetAllCompanies();
                MessageBox.Show("Birim güncellendi.");
            }
            else
            {
                MessageBox.Show("Birim Adı boş geçilemez.");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (tbxBirimId.Text != "")   ////bak yinedeee
            { 
              int birimId = Convert.ToInt32(tbxBirimId.Text);
            
             manager.UnitDeleteBL(birimId);
             FormuTemizle();
             GetAllCompanies();
                MessageBox.Show("Birim Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen id seçiniz");
            }
        }
    }
}
