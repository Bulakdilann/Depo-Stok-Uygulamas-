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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            statusStrip1.Text=statusStrip1.Text+""+"Admin";
        }

        private void tsbtnUrunİslemleri_Click(object sender, EventArgs e)
        {
            frmUrunler frmurunler= new frmUrunler();
            frmurunler.MdiParent=this;
            FormGetir(frmurunler);
        }

        private void FormGetir(Form form)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.FormBorderStyle=FormBorderStyle.None;
            form.Show();
        }

        private void tsbtnFirmaIslemleri_Click(object sender, EventArgs e)
        {
            frmFirmalar frmfirmalar=new frmFirmalar();
            frmfirmalar.MdiParent=this;
            FormGetir(frmfirmalar);
        }

        private void tsbtnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            frmPersoneller frmpersoneller=new frmPersoneller();
             frmpersoneller.MdiParent=this;
            FormGetir(frmpersoneller);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnStokİşlemleri_Click(object sender, EventArgs e)
        {
            FrmStokİslemleri frmstokislemleri=new  FrmStokİslemleri();
            frmstokislemleri.MdiParent=this;
            FormGetir(frmstokislemleri);
        }
    }
}
