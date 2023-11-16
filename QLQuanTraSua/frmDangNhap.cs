
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanTraSua
{
	public partial class frmDangNhap : Form
	{
		frmMain frm2 = new frmMain();
		SqlConnection con;
		SqlCommand cmd;
		SqlDataReader dr;
		public frmDangNhap()
		{
			InitializeComponent();
			con = new SqlConnection("server=DESKTOP-T0SS1UU\\SQLEXPRESS01; Initial Catalog=DA2_QLCHCFMH;Integrated Security=SSPI");
		}

		private void txtTenDN_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string user = txtTenDN.Text;
			string pass = txtMatKhau.Text;
			cmd = new SqlCommand();
			con.Open();
			cmd.Connection = con;
			cmd.CommandText = "SELECT * FROM DangNhap where Tendangnhap='" + txtTenDN.Text + "' AND Matkhau='" + txtMatKhau.Text + "'";
			dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				frm2.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
			}
			con.Close();
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
		}

		private void btnHuyBo_Click(object sender, EventArgs e)
		{
			DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dg == DialogResult.Yes)
				Application.Exit();
		}
	}
}
