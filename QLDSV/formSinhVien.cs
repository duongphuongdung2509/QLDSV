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
    public partial class formSinhVien : Form
    {
        public formSinhVien()
        {
            InitializeComponent();
        }

        private void formSinhVien2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVR.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSVR.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);
            // TODO: This line of code loads data into the 'qLDSVR.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVR.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'qLDSVR.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSVR.LOP);
            // TODO: This line of code loads data into the 'qLDSVR.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSVR.SINHVIEN);

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

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG MÃ SINH VIÊN", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG TÊN SINH VIÊN", "THÔNG BÁO", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG HỌ SINH VIÊN", "THÔNG BÁO", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG MÃ LỚP", "THÔNG BÁO", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG ĐỊA CHỈ", "THÔNG BÁO", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (txtNoiSinh.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG NƠI SINH", "THÔNG BÁO", MessageBoxButtons.OK);
                txtNoiSinh.Focus();
                return;
            }
            if (comboNgaySInh.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG NGÀY SINH", "THÔNG BÁO", MessageBoxButtons.OK);
                comboNgaySInh.Focus();
                return;
            }
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_ThemSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = txtMaSV.Text;
                Program.sqlcmd.Parameters.Add("@HO", SqlDbType.NVarChar).Value = txtHo.Text;
                Program.sqlcmd.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = txtTen.Text;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@PHAI", SqlDbType.Bit).Value = checkPhai.Checked ? 1 : 0;
                Program.sqlcmd.Parameters.Add("@NOISINH", SqlDbType.NVarChar).Value = txtNoiSinh.Text;
                Program.sqlcmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                Program.sqlcmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = comboNgaySInh.Text;
                Program.sqlcmd.Parameters.Add("@NGHIHOC", SqlDbType.Bit).Value = CheckNghiHoc.Checked ? 1 : 0;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.sINHVIENBindingSource.EndEdit();
                this.sINHVIENTableAdapter.Fill(qLDSVR.SINHVIEN); 
                MessageBox.Show("THÊM SINH VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI GHI SINH VIÊN.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            this.sINHVIENBindingSource.AddNew();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                String strLenh = "dbo.SP_XoaSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = txtMaSV.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                // this.lOPBindingSource.EndEdit();
                this.sINHVIENBindingSource.RemoveCurrent();
                MessageBox.Show("XÓA SINH VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI XÓA SINH VIÊN.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {

                String strLenh = "dbo.SP_CapnhatSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = txtMaSV.Text;
                Program.sqlcmd.Parameters.Add("@HO", SqlDbType.NVarChar).Value = txtHo.Text;
                Program.sqlcmd.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = txtTen.Text;
                Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = txtMaLop.Text;
                Program.sqlcmd.Parameters.Add("@PHAI", SqlDbType.Bit).Value = checkPhai.Checked ? 1 : 0;
                Program.sqlcmd.Parameters.Add("@NOISINH", SqlDbType.NVarChar).Value = txtNoiSinh.Text;
                Program.sqlcmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtDiaChi.Text;
                Program.sqlcmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = comboNgaySInh.Text;
                Program.sqlcmd.Parameters.Add("@NGHIHOC", SqlDbType.Bit).Value = CheckNghiHoc.Checked ? 1 : 0;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.lOPBindingSource.EndEdit();
                this.sINHVIENTableAdapter.Fill(qLDSVR.SINHVIEN);
                MessageBox.Show("CẬP NHẬT SINH VIÊN THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI CẬP NHẬT.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
