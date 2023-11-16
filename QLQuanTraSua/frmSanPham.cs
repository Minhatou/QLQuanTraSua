using QLQuanTraSua.Business;
using QLQuanTraSua.DataAccess;
using QLQuanTraSua.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanTraSua
{
	public partial class frmSanPham : Form
	{
		SanphamCRUD bll = new SanphamCRUD();
		SanPham SP = new SanPham();
		SanphamSQL dal = new SanphamSQL();
		public frmSanPham()
		{
			InitializeComponent();
		}

		private void tsLamMoi_Click(object sender, EventArgs e)
		{
			txtMasp.Text = "";
			txtTensp.Text = "";
			txtgiaban.Text = "";
			// txtSoluong.Text = "";
			cbDonViTinh.Text = "";
			cbLoaisanpham.Text = "";
			cbTimKiem.Text = "";
		}

		private void tsThem_Click(object sender, EventArgs e)
		{
			//Kiểm tra mã có trùng hay không?
			if (bll.tongbanghi(txtMasp.Text) == 1)
				MessageBox.Show("Mã: " + txtMasp.Text + " đã tồn tại. Nhập mã khác!");
			else if (bll.tongbanghi(txtMasp.Text) == 0)

			{
				if (txtMasp.Text != "" && txtTensp.Text != "" && txtgiaban.Text != "" && cbDonViTinh.Text != "" && cbLoaisanpham.Text != "")
				{
					bll.ThemSP(txtMasp.Text, (txtTensp.Text), double.Parse(txtgiaban.Text), cbDonViTinh.Text, cbLoaisanpham.Text);
					MessageBox.Show("Thêm Thành Công!", "Thông Báo");
					frmSanPham_Load(sender, e);
				}
				else
				{
					MessageBox.Show("Thêm Thất Bại,Bạn Phải Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				}
			}
		}

		private void tsSua_Click(object sender, EventArgs e)
		{
			if (txtTensp.Text != "" || txtgiaban.Text != "" || cbDonViTinh.Text != "" || cbLoaisanpham.Text != "")
			{

				{
					bll.SuaSP(txtMasp.Text, txtTensp.Text, double.Parse(txtgiaban.Text), cbDonViTinh.Text, cbLoaisanpham.Text);
					MessageBox.Show("Sửa Thành Công!", "Thông Báo");
					frmSanPham_Load(sender, e);

				}
			}

			else
				MessageBox.Show(" Chọn một hàng để sửa!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void tsXoa_Click(object sender, EventArgs e)
		{
			DialogResult q = MessageBox.Show("Bạn Có Muốn Xóa Sản Phẩm Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (q.Equals(DialogResult.Yes))
			{
				bll.XoaSP(txtMasp.Text, txtTensp.Text, double.Parse(txtgiaban.Text), cbDonViTinh.Text, cbLoaisanpham.Text);
				frmSanPham_Load(sender, e);

			}
		}

		private void tsTimKiem_Click(object sender, EventArgs e)
		{
			if (cbTimKiem.Text == "tim kiem theo ma")

			{
				dgSanPham.DataSource = bll.Listsp(txtMasp.Text);
				txtMasp.Text = "";

			}

			else if (cbTimKiem.Text == "tim kiem theo ten")

			{
				dgSanPham.DataSource = bll.ListTensp(txtTensp.Text);
				txtTensp.Text = "";

			}

			else
				MessageBox.Show("Bạn phải nhập kiêu tìm kiếm");
		}

		private void tsThoat_Click(object sender, EventArgs e)
		{
			DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (q.Equals(DialogResult.Yes))
			{
				this.Close();
			}
		}

		private void tsQuayLai_Click(object sender, EventArgs e)
		{
			dgSanPham.DataSource = bll.LoadSP();
		}

		private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int hangchon = e.RowIndex;
			txtMasp.Text = dgSanPham[0, hangchon].Value.ToString();
			txtTensp.Text = dgSanPham[1, hangchon].Value.ToString();
			txtgiaban.Text = dgSanPham[2, hangchon].Value.ToString();
			cbDonViTinh.Text = dgSanPham[3, hangchon].Value.ToString();
			cbLoaisanpham.Text = dgSanPham[4, hangchon].Value.ToString();
		}

		private void frmSanPham_Load(object sender, EventArgs e)
		{
			dgSanPham.DataSource = bll.LoadSP();
		}
	}
}
