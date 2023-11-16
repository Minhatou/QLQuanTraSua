using QLQuanTraSua.Business;
using QLQuanTraSua.DataAccess;
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
	public partial class frmThongKeSanPham : Form
	{
		ChitietphieuxuatCRUD ctpxbll = new ChitietphieuxuatCRUD();
		public frmThongKeSanPham()
		{
			InitializeComponent();
		}

		private void tsThongKe_Click(object sender, EventArgs e)
		{
			if (cbKieuThongKe.Text == "Thống kê sản phẩm bán chạy")
			{
				dgThongKesp.DataSource = ctpxbll.ThongKeSanPhamBanChay();

			}

			else if (cbKieuThongKe.Text == "Thống kê sản phẩm bán chậm")
			{
				dgThongKesp.DataSource = ctpxbll.ThongKeSanPhamBanCham();

			}

			else
				MessageBox.Show("Bạn phải nhập kiêu thống kê");
		}

		private void tsLamMoi_Click(object sender, EventArgs e)
		{
			cbKieuThongKe.Text = "";
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			frmThongKeSanPham_Load(sender, e);
		}

		private void tsThoat_Click(object sender, EventArgs e)
		{
			DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (q.Equals(DialogResult.Yes))
			{
				this.Close();
			}
		}

		private void frmThongKeSanPham_Load(object sender, EventArgs e)
		{
			dgThongKesp.DataSource = ctpxbll.Loadctpx();
		}

		private void dgThongKesp_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
