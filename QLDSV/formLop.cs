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
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void them_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG MÃ LỚP", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG TÊN LỚP", "THÔNG BÁO", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG MÃ KHOA", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_ThemLop";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
                Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.lOPBindingSource.EndEdit();
                MessageBox.Show("THÊM LỚP THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI GHI LỚP.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            this.lOPBindingSource.AddNew();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
               
                String strLenh = "dbo.SP_CapnhatLop";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txtTenLop.Text;
                Program.sqlcmd.Parameters.Add("@MAKH", SqlDbType.NChar).Value = txtMaKhoa.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.lOPBindingSource.EndEdit();
                MessageBox.Show("CẬP NHẬT LỚP THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI CẬP NHẬT.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                String strLenh = "dbo.SP_XoaLop";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
               // this.lOPBindingSource.EndEdit();
                this.lOPBindingSource.RemoveCurrent();
                MessageBox.Show("XÓA LỚP THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI XÓA LỚP.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKhoa_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
