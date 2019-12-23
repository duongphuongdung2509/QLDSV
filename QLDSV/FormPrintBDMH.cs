using DevExpress.XtraReports.UI;
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
    public partial class FormPrintBDMH : Form
    {
        public FormPrintBDMH()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVR);

        }

        private void FormINBDMONHOC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSVR.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);

        }

        private void tENMHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btManHinh_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_INBDMONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_INBDMONHOCTableAdapter.Fill(qLDSVR.SP_INBDMONHOC, CbTenLop.Text,CbTenMH.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(CbLan.Text, typeof(short))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue == null) return;

            Program.servername = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mChinhanh)
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
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            XprtBDMH rpt = new XprtBDMH(CbTenLop.Text,CbTenMH.Text,CbLan.Text);
            
            rpt.txtLop.Text = CbTenLop.Text;
            rpt.txtMon.Text = CbTenMH.Text;
            rpt.txtLan.Text = CbLan.Text;
            ReportPrintTool rp = new ReportPrintTool(rpt);
            rp.ShowPreview();
        }
    }
}
