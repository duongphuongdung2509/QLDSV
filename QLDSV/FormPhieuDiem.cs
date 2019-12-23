using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLDSV
{
    public partial class FormPhieuDiem : Form
    {
        public FormPhieuDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVR);

        }

        private void FormPhieuDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVR.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVR.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVR.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVR.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);

        }

        private void CbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btManHinh_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_PHIEUDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_PHIEUDIEMTableAdapter.Fill(this.qLDSVR.SP_PHIEUDIEM, CbMaSV.Text, CbMaLop.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKhoa.SelectedValue == null) return;

            Program.servername = comboKhoa.SelectedValue.ToString();
            if (comboKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSVR.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSVR.SINHVIEN);

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            XtraPhieuDiem rpt = new XtraPhieuDiem(CbMaLop.Text, CbMaSV.Text);
            rpt.txtMaLop.Text = CbMaLop.Text;
            rpt.txtMaSV.Text = CbMaSV.Text;
            ReportPrintTool rp = new ReportPrintTool(rpt);
            rp.ShowPreview();

        }
    }
}
