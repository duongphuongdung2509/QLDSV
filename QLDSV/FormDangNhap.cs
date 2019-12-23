using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtTaiKhoan.Text = "son";
            txtPassword.Text = "123456";
            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG TÀI KHOẢN", "THÔNG BÁO", MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("KHÔNG ĐƯỢC ĐỂ TRỐNG PASSWORD", "THÔNG BÁO", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            Program.mlogin = txtTaiKhoan.Text.Trim();
            Program.password = txtPassword.Text.Trim();
            if (Program.KetNoi() == 0)
            {
                return;
            }
            Program.mChinhanh = cbBoPhan.SelectedIndex;//xác định chi nhánh
            Program.tenChiNhanh = cbBoPhan.Text;
            if (Program.tenChiNhanh == "QLDSV_CNTT")
            {
                Program.maCN = "CNTT";
            }
            else if (Program.tenChiNhanh == "QLDSV_VT")
            {
                Program.maCN = "VT";
            }
            else if (Program.tenChiNhanh == "QLDSV_KETOAN")
            {
                Program.maCN = "KETOAN";
            }
            else
            {
                return;
            }
            SqlDataReader myReader;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();
            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            //Program.frmMain.HienThiMenu();
            myReader.Close();
            Program.conn.Close();
            MessageBox.Show("Đăng Nhập Thành Công", "", MessageBoxButtons.OK);
            this.Hide();
            
            //FormMain f = new FormMain();
            //f.HienThiMenu();
            //FormMain f = new FormMain();
            //f.Show();

            formMainv2 f = new formMainv2();
            f.ShowDialog();
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbBoPhan.SelectedValue.ToString();

            }
            catch (Exception ex)
            {
                Program.servername = "";
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            string chuoiketnoi = "Data Source=PHUONGDUNG;Initial Catalog=QLDSV;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cbBoPhan.DataSource = dt;
            cbBoPhan.DisplayMember = "TENCN";
            cbBoPhan.ValueMember = "TENSERVER";
            cbBoPhan.SelectedIndex = 1;
            cbBoPhan.SelectedIndex = 0;
            txtTaiKhoan.Focus();

        }
    }
}