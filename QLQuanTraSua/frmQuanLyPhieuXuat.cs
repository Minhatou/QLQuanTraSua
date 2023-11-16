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
	public partial class frmQuanLyPhieuXuat : Form
	{
		PhieuXuat px = new PhieuXuat();
		PhieuxuatCRUD pxb = new PhieuxuatCRUD();
		SanphamCRUD dtb = new SanphamCRUD();
		ChitietphieuxuatCRUD ctx = new ChitietphieuxuatCRUD();
		DataTable dt = new DataTable();
		public frmQuanLyPhieuXuat()
		{
			InitializeComponent();
		}

		private void tstThem_Click(object sender, EventArgs e)
		{
			try
			{
				//Kiểm tra mã có trùng hay không?
				if (pxb.tongbanghi(txtMapx.Text) == 1)
					MessageBox.Show("Mã: " + txtMapx.Text + " đã tồn tại. Nhập mã khác!");
				else if (pxb.tongbanghi(txtMapx.Text) == 0)
				{

					if (txtMapx.Text != "" && cbManv.Text != "" && cbBanSo.Text != "" && msNgayBan.Text != "")
					{
						pxb.Thempx(txtMapx.Text, cbManv.Text, cbBanSo.Text);
						MessageBox.Show("them thanh cong");
						frmQuanLyPhieuXuat_Load(sender, e);
					}
				}
			}
			catch
			{
				MessageBox.Show("Thêm thất bại", "thôngbao", MessageBoxButtons.OK);
			}
		}

		private void tstLamMoi_Click(object sender, EventArgs e)
		{
			txtMapx.Text = "";
			cbBanSo.Text = "";
			cbManv.Text = "";
		}

		private void tstChiTietPhieuXuat_Click(object sender, EventArgs e)
		{
			frmChiTietPhieuXuat ct = new frmChiTietPhieuXuat();
			ct.ShowDialog();
		}

		private void tsXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa phiếu xuất này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				pxb.Xoapx(txtMapx.Text, cbManv.Text, cbBanSo.Text);
				MessageBox.Show("xoa thanh cong");
				frmQuanLyPhieuXuat_Load(sender, e);
			}
		}

		private void tsTimKiem_Click(object sender, EventArgs e)
		{
			dgPhieuXuat.DataSource = pxb.Listpx(txtMapx.Text);
			txtMapx.Text = "";
		}

		private void tstThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tsQuayLai_Click(object sender, EventArgs e)
		{
			frmQuanLyPhieuXuat_Load(sender, e);
		}

		private void dgPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int hang = e.RowIndex;
			txtMapx.Text = dgPhieuXuat[0, hang].Value.ToString();
			cbManv.Text = dgPhieuXuat[1, hang].Value.ToString();
			msNgayBan.Text = dgPhieuXuat[2, hang].Value.ToString();
			cbBanSo.Text = dgPhieuXuat[3, hang].Value.ToString();
		}

		private void frmQuanLyPhieuXuat_Load(object sender, EventArgs e)
		{
			// load các phiếu xuất đã có
			dgPhieuXuat.DataSource = pxb.LoadPX();
			//load ma nhan vien
			NhanvienCRUD nvnll = new NhanvienCRUD();
			cbManv.DataSource = nvnll.LoadNV();
			cbManv.DisplayMember = "manv";

			//// load ngay bán là ngày hiện tại
			msNgayBan.Text = DateTime.Today.ToShortDateString();
		}

	}
}
