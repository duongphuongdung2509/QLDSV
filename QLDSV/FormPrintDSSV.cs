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
    public partial class FormPrintDSSV : Form
    {
        public FormPrintDSSV()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSVR);

        }

        private void FormPrintDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);
            this.gridView1.OptionsBehavior.ReadOnly = true;
        }

        private void mALOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENLOPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void btManHinh_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_INDSSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_INDSSVTableAdapter.Fill(this.qLDSVR.SP_INDSSV, txtMaLop.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            xRptDSSV rpt = new xRptDSSV(txtMaLop.Text);
            rpt.lbTenLop.Text = cbTenLop.Text;
            ReportPrintTool rp = new ReportPrintTool(rpt);
            rp.ShowPreview();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();

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
            }
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
