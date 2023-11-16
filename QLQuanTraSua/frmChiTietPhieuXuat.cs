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
using Excel = Microsoft.Office.Interop.Excel;
namespace QLQuanTraSua
{
	public partial class frmChiTietPhieuXuat : Form
	{
		
		ChitietphieuxuatCRUD bll = new ChitietphieuxuatCRUD();
		SanphamCRUD dtb = new SanphamCRUD();
		PhieuxuatCRUD pxb = new PhieuxuatCRUD();
		SanphamSQL sps = new SanphamSQL();
		System.Data.DataTable dt = new System.Data.DataTable();
		double Tong = 0;
		public double TongTien(System.Data.DataTable dt)
		{
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Tong = Tong + double.Parse(dt.Rows[i][3].ToString());
			}
			return Tong;
		}
		public void tinhtien()
		{
			int soluong;
			double dongia, thanhtien;
			if (txtSoLuong.Text == "")
			{ MessageBox.Show("chua nhap so luong"); }
			else
			{
				soluong = int.Parse(txtSoLuong.Text);
				dongia = double.Parse(txtDonGia.Text);

				if (soluong <= 0)
				{
					MessageBox.Show("so luong phai >0");
				}
				else
				{
					thanhtien = soluong * dongia;
					txtThanhTien.Text = thanhtien.ToString();

				}

			}
		}
		public frmChiTietPhieuXuat()
		{
			InitializeComponent();
			btnIn.Enabled = false;
		}

		private void btLamMoi_Click(object sender, EventArgs e)
		{
			cbMaSanPham.Text = "";
			cbMaPhieuXuat.Text = "";
			txtDonGia.Text = "";
			txtSoLuong.Text = "";
			txtThanhTien.Text = "";
			txtTongtien.Text = "";
		}

		private void btThem_Click(object sender, EventArgs e)
		{
			//Kiểm tra sự hợp lệ của chi tiết phiếu xuất
			if (bll.tongbanghi(cbMaPhieuXuat.Text, cbMaSanPham.Text) == 1)
				MessageBox.Show("Chi tiết phiếu xuất này không hợp lệ. Nhập chi tiết phiếu xuất khác!");
			else if (bll.tongbanghi(cbMaPhieuXuat.Text, cbMaSanPham.Text) == 0)
			{
				if (txtSoLuong.Text != "" && txtDonGia.Text != "")
				{
					tinhtien();
					MessageBox.Show("Số tiền khách hàng phải trả cho sản phẩm này là:" + txtThanhTien.Text + "");
				}

				bll.Thempx(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));
				frmChiTietPhieuXuat_Load(sender, e);
			}
		}

			private void btXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa chi tiết phiếu xuất này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				bll.XoaChiTietPhieuXuat(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));


				MessageBox.Show("xoa thanh cong");
				frmChiTietPhieuXuat_Load(sender, e);
			}
		}
		private void btTimKiem_Click(object sender, EventArgs e)
		{
			btnIn.Enabled = true;
			Tong = 0;
			System.Data.DataTable dt = bll.Listctpx(cbTimKiem.Text);
			{
				dgChiTietPhieuXuat.DataSource = dt;

				if (dt.Rows.Count > 0)
				{
					txtTongtien.Text = TongTien(dt).ToString();

				}
				else
				{
					txtTongtien.Text = "";
				}
			}
		}

		private void bttrolai_Click(object sender, EventArgs e)
		{
			btnIn.Enabled = false;
			frmChiTietPhieuXuat_Load(sender, e);
			txtTongtien.Text = "";
		}

		private void btSanPham_Click(object sender, EventArgs e)
		{
			frmSanPham s = new frmSanPham();
			s.ShowDialog();
		}

		private void btThoat_Click(object sender, EventArgs e)
		{
			DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (q.Equals(DialogResult.Yes))
			{
				this.Close();
			}
		}

		private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
		{
			dgChiTietPhieuXuat.DataSource = bll.Loadctpx();

			// load mã sản phẩm
			SanphamCRUD dtb = new SanphamCRUD();
			cbMaSanPham.DataSource = dtb.LoadSP();
			cbMaSanPham.DisplayMember = "masp";
			cbMaSanPham.ValueMember = "dongia";

			//load ma phieu xuat
			PhieuxuatCRUD pxb = new PhieuxuatCRUD();
			cbMaPhieuXuat.DataSource = pxb.LoadPX();
			cbMaPhieuXuat.DisplayMember = "mapx";
			//load ma phieu xuat vao ô tìm kiếm
			cbTimKiem.DataSource = pxb.LoadPX();
			cbTimKiem.DisplayMember = "mapx";
		}

		private void dgChiTietPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int hang = e.RowIndex;
			cbMaPhieuXuat.Text = dgChiTietPhieuXuat[0, hang].Value.ToString();
			cbMaSanPham.Text = dgChiTietPhieuXuat[1, hang].Value.ToString();
			txtSoLuong.Text = dgChiTietPhieuXuat[2, hang].Value.ToString();
			txtThanhTien.Text = dgChiTietPhieuXuat[3, hang].Value.ToString();
		}

		private void cbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = sps.laygia(cbMaSanPham.Text).ToString();
		}

		private void txtDonGia_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgChiTietPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

			Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
			exRange.Range["A1"].Font.Size = 15;
			exRange.Range["A1"].Font.Bold = true;
			exRange.Range["A1"].Font.Color = Color.Blue;
			exRange.Range["A1"].Value = "CỬA HÀNG TRÀ SỮA";

			Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1];
			exRange.Range["A2"].Font.Size = 13;
			exRange.Range["A2"].Font.Color = Color.Blue;
			exRange.Range["A2"].Value = "1a Cầu Giấy - Hà Nội";

			exSheet.Range["D4"].Font.Size = 20;
			exSheet.Range["D4"].Font.Bold = true;
			exSheet.Range["D4"].Font.Color = Color.Red;
			exSheet.Range["D4"].Value = "HÓA ĐƠN BÁN";

			exSheet.Range["A5:A8"].Font.Size = 12;
			exSheet.Range["A5"].Value = "Mã phiếu xuất: " + cbTimKiem.Text;

			exSheet.Range["A10:G10"].Font.Size = 12;
			exSheet.Range["A10:G10"].Font.Bold = true;
			exSheet.Range["B10"].ColumnWidth = 16;
			exSheet.Range["D10"].ColumnWidth = 16;
			exSheet.Range["C10"].ColumnWidth = 25;
			exSheet.Range["G10"].ColumnWidth = 25;
			exSheet.Range["E10"].ColumnWidth = 20;
			exSheet.Range["A10"].Value = "STT: ";
			exSheet.Range["B10"].Value = "Mã phiếu xuất: ";
			exSheet.Range["C10"].Value = "Mã sản phẩm: ";
			exSheet.Range["D10"].Value = "Số lượng: ";
			exSheet.Range["E10"].Value = "Thành tiền: ";

			int dong = 11;
			for (int i = 0; i < dgChiTietPhieuXuat.Rows.Count - 1; i++)
			{
				exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
				exSheet.Range["B" + (dong + i).ToString()].Value = dgChiTietPhieuXuat.Rows[i].Cells[0].Value.ToString();
				exSheet.Range["C" + (dong + i).ToString()].Value = dgChiTietPhieuXuat.Rows[i].Cells[1].Value.ToString();
				exSheet.Range["D" + (dong + i).ToString()].Value = dgChiTietPhieuXuat.Rows[i].Cells[2].Value.ToString();
				exSheet.Range["E" + (dong + i).ToString()].Value = dgChiTietPhieuXuat.Rows[i].Cells[3].Value.ToString();
			}

			dong += dgChiTietPhieuXuat.Rows.Count;
			exSheet.Range["F" + dong.ToString()].Value = "Tổng tiền: " + txtTongtien.Text + " đồng";
			exSheet.Name = cbMaPhieuXuat.Text;

			exBook.Activate();

			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|All Files|*.*";
			save.FilterIndex = 1;

			if (save.ShowDialog() == DialogResult.OK)
			{
				exBook.SaveAs(save.FileName);
				MessageBox.Show("In hóa đơn xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			exApp.Quit();
		}

		private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnIn.Enabled = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
