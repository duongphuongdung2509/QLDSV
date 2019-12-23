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
    public partial class FormMonhoc : Form
    {
        public FormMonhoc()
        {
            InitializeComponent();
        }

        private void FormMonhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVR.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVR.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVR.MONHOC);
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);

        }

        private void comboKHOA_SelectedIndexChanged(object sender, EventArgs e)
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.qLDSVR.MONHOC);
            }
        }


        private void xoa_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                String strLenh = "dbo.SP_XoaMonHoc";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMon.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.mONHOCBindingSource.RemoveCurrent();
                MessageBox.Show("XÓA MÔN HỌC THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI CẬP NHẬT MÔN HỌC .\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void ghi_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            this.mONHOCBindingSource.AddNew();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {

                String strLenh = "dbo.SP_CapnhatMonHoc";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMon.Text;
                Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = txtTenMon.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.mONHOCBindingSource.EndEdit();
                MessageBox.Show("CẬP NHẬT MÔN HỌC THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI CẬP NHẬT \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG MÃ MÔN", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaMon.Focus();
                return;
            }
            if (txtTenMon.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG TÊN MÔN", "THÔNG BÁO", MessageBoxButtons.OK);
                txtTenMon.Focus();
                return;
            }
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_ThemMonHoc";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMon.Text;
                Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = txtTenMon.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.mONHOCBindingSource.EndEdit();
                MessageBox.Show("THÊM MÔN HỌC THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
