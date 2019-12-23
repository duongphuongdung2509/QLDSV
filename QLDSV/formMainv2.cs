using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class formMainv2 : Form
    {
        public formMainv2()
        {
            InitializeComponent();
        }

        private void btLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLop frm = new FormLop();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMonhoc frm = new FormMonhoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formSinhVien frm = new formSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDiemSV frm = new FormDiemSV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPrintDSSV frm = new FormPrintDSSV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btPrintDiemMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPrintBDMH frm = new FormPrintBDMH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btDSHetMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btPhieuDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPhieuDiem frm = new FormPhieuDiem();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
