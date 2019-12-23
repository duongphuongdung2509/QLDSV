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
    public partial class FormDiemSV : Form
    {
        public FormDiemSV()
        {
            InitializeComponent();
        }

        private void FormDiemSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVR.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DIEMSVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DIEMSVTableAdapter.Fill(this.qLDSVR.SP_DIEMSV, cbMaLop.Text, cbMaMon.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(cbLanThi.Text, typeof(short))))));
                this.btGhiDiem.Enabled = true;
                this.btStart.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGhiDiem_Click(object sender, EventArgs e)
        {
            int dem = sP_DIEMSVBindingSource.Count;
            for (int i = 0; i < dem; i++)
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                try
                {

                    String strLenh = "dbo.SP_NhapDiemSV";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = gridView1.GetRowCellValue(i, "MASV").ToString().Trim();
                    Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = cbMaMon.Text;
                    Program.sqlcmd.Parameters.Add("@DIEM", SqlDbType.NChar).Value = gridView1.GetRowCellValue(i, "DIEM").ToString().Trim();
                    Program.sqlcmd.Parameters.Add("@LAN", SqlDbType.NChar).Value = cbLanThi.Text;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    this.sP_DIEMSVBindingSource.EndEdit();
             //       this.sP_DIEMSVTableAdapter.Fill(this.qLDSVR.SP_DIEMSV,);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
    }

    //private void fillToolStripButton_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        this.sP_DIEMSVTableAdapter.Fill(this.qLDSVR.SP_DIEMSV, mALOPToolStripTextBox.Text, mAMHToolStripTextBox.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(lANToolStripTextBox.Text, typeof(short))))));
    //    }
    //    catch (System.Exception ex)
    //    {
    //        System.Windows.Forms.MessageBox.Show(ex.Message);
    //    }

    //}

   
