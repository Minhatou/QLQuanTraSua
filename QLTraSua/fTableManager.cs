using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CoffeManager.DAOCafe;
using CoffeManager.DTOCafe;
using Button = System.Windows.Forms.Button;

namespace CoffeManager
{
    public partial class fTableManager : Form
    {
		private AccDTO dntk;
		float TongThanhToan = 0;
		public AccDTO DangNhapTK
		{
			get { return dntk; }

			set { dntk = value; ChuyenTK(dntk.LoaiTK); }
		}

		public fTableManager(AccDTO acc)
		{
			InitializeComponent();

			this.DangNhapTK = acc;

			TaoThucDon();

			LoaiDoUong();

			//TaoCBBanAn(fTableCB);
		}

		#region Method

		void ChuyenTK(int ltk)
		{
			fAdmin.Enabled = ltk == 1;

			accountInfoToolStripMenuItem.Text += " (" + DangNhapTK.TenTK + ")";
		}
		//private void TaoBanAn()
		// {
		//fTableList.Controls.Clear();

		//  List<TableDTO> tableList = TableDAO.Instance.TaoBanAn();

		//for (int i = 0; i < tableList.Count; i++)

		//     foreach (TableDTO item in tableList)

		//    {
		//var item = tableList[i];
		//
		//               Button btn = new Button() { Width = TableDAO.ChieuRongBan, Height = TableDAO.ChieuCaoBan };

		//btn.Text = i + Environment.NewLine + item.TabStat;

		//                btn.Text = item.TabNum + "\n" + item.TabStat;

		//               btn.Click += btn_Click;

		//               btn.Tag = item;

		//               switch (item.TabStat)
		//    {
		//                   case "Bàn trống":
		//                    btn.BackColor = Color.Azure;
		//                  break;
		//           default:
		// //            btn.BackColor = Color.LightGreen;
		//         break;
		//    }

		//      fTableList.Controls.Add(btn);

		//   }
		//  }
		private void TaoThucDon()
		{
			fTableList.Controls.Clear();

			List<MenuDTO> tableList = MenuDAO.Instance.TaoThucDon();

			//for (int i = 0; i < tableList.Count; i++)

			foreach (MenuDTO item in tableList)

			{
				//var item = tableList[i];

				Button btn = new Button() { Width = 225, Height = 300 };
				string fileAnh = "E:\\Downloads\\QLQuanTraSua-main\\QLQuanTraSua-main\\QLTraSua\\bin\\Debug\\Images\\" + item.Anh;
				btn.Image = System.Drawing.Image.FromFile(fileAnh);
				// Align the image and text on the button.
				btn.ImageAlign = ContentAlignment.MiddleCenter;
				btn.Font = new Font("Tahoma", 10);
				btn.Text = item.TenThucDon + Environment.NewLine + item.GiaTien;
				btn.TextAlign = ContentAlignment.BottomCenter;

				btn.Click += btn_Click;

				btn.Tag = item;

				fTableList.Controls.Add(btn);

			}
		}


		void HienHoaDon(int id)
		{

			string Dongia = MenuDAO.LayDonGia(txtMon.Text);
			int TongGiaTien = Convert.ToInt32(Dongia) * Convert.ToInt32(fMenuValue.Value);
			string TongGia = TongGiaTien.ToString();
			List<CoffeManager.DTOCafe.MenuDTO> listBInfo = new List<CoffeManager.DTOCafe.MenuDTO>();

			ListViewItem LVI = new ListViewItem(txtMon.Text);

			LVI.SubItems.Add(fMenuValue.Value.ToString());

			LVI.SubItems.Add(Dongia);

			LVI.SubItems.Add(TongGia);

			TongThanhToan += TongGiaTien;

			fBillInfo.Items.Add(LVI);

			CultureInfo vnd = new CultureInfo("vi-VN");

			//Thread.CurrentThread.CurrentCulture = vnd;

			f3T.Text = TongThanhToan.ToString("c", vnd);


		}

		void LoaiDoUong()
		{
			List<CateDTO> listLoaiTD = CateDAO.Instance.LayDanhSachTD();

			fBevMenu.DataSource = listLoaiTD;

			fBevMenu.DisplayMember = "LoaiDoUong";
		}

		void IDDanhSachThucDon(int id)
		{
			List<BevDTO> listTD = BevDAO.Instance.IDDanhSachTD(id);
		}

		//  void TaoCBBanAn (ComboBox cbt)
		//   {
		//     cbt.DataSource = TableDAO.Instance.TaoBanAn();
		//    cbt.DisplayMember = "TabNum";
		//  }

		#endregion

		#region Event

		void btn_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;

			string str = button.Text;
			string val = (str.IndexOf("\n") > 0)
						  ? str.Substring(0, str.IndexOf("\n") - 1)
						  : string.Empty;
			txtMon.Text = val;
			string val2 = (str.IndexOf("\n") > 0)
						  ? str.Substring(str.IndexOf("\n") - 1)
						  : string.Empty;
			txtDonGia.Text = val2;
		}
		private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn quay trở lại màn hình đăng nhập?", "Exit", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
			{
				e.Cancel = true;
			}
		}

		private void fTableManager_Load(object sender, EventArgs e)
		{
			TaoThucDon();
			fBevMenu.Text = "";
		}


		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fAdmin1_Click(object sender, EventArgs e)
		{
			fAdmin1 f = new fAdmin1();

			f.dntk = DangNhapTK;

			f.NhapTD += f_NhapTD;

			f.SuaTD += f_SuaTD;

			f.XoaTD += f_XoaTD;

			//f.ThemBanan += f_ThemBan;

			//f.XoaBanan += f_XoaBan;

			f.ShowDialog();
		}

		void f_NhapTD(object sender, EventArgs e)
		{
			//IDDanhSachThucDon((fBevMenu.SelectedItem as CateDTO).CateID);

			if (fBillInfo.Tag != null)
				HienHoaDon((fBillInfo.Tag as BillDTO).IDBan);
		}

		void f_SuaTD(object sender, EventArgs e)
		{
			//IDDanhSachThucDon((fBevMenu.SelectedItem as CateDTO).CateID);

			if (fBillInfo.Tag != null)
				HienHoaDon((fBillInfo.Tag as BillDTO).IDBan);
		}

		void f_XoaTD(object sender, EventArgs e)
		{
			//IDDanhSachThucDon((fBevMenu.SelectedItem as CateDTO).CateID);

			if (fBillInfo.Tag != null)
				HienHoaDon((fBillInfo.Tag as BillDTO).IDBan);

			//TaoBanAn();
		}

		void f_ThemBan(object sender, EventArgs e)
		{
			// TaoBanAn();
		}

		void f_XoaBan(object sender, EventArgs e)
		{
			// TaoBanAn();
		}

		private void fBillInfo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void fBevMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}
		private void fBevName_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void fTableControlPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void fAddMenu_Click(object sender, EventArgs e)
		{
			HienHoaDon(100);
			fMenuValue.Value = 0;

			//TaoBanAn();
		}

		private void fMenuValue_ValueChanged(object sender, EventArgs e)
		{

		}

		private void fCheck_Click(object sender, EventArgs e)
		{
			int km = (int)fDiscountValue.Value;
			double TongTien = Convert.ToDouble(f3T.Text.Split(',')[0].Replace(".", ""));
			double ThanhToan = TongTien - (TongTien / 100) * km;
			if (MessageBox.Show(string.Format("Thanh toán hóa đơn này? \nTổng tiền = " + ThanhToan + " VND"), "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				MessageBox.Show("Đã thanh toán");

				fBillInfo.Clear();
				TongThanhToan = 0;
				BillDAO.Instance.CkOut(TongTien, km, ThanhToan);

			}

			TaoThucDon();
			//TaoBanAn();
		}

		private void fSwitchTable_Click(object sender, EventArgs e)
		{


			// TaoBanAn();
		}

		private void fMergeTable_Click(object sender, EventArgs e)
		{

			// TaoBanAn();
		}
		private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAccProfile f = new fAccProfile(DangNhapTK);

			f.CNTK += f_CNTK;

			f.ShowDialog();
		}

		void f_CNTK(object sender, AccEvent e)
		{
			accountInfoToolStripMenuItem.Text = "Thông tin tài khoản (" + e.TaiKhoan.TenTK + ")";
		}

		private void fTableCB_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void thêmThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAddMenu_Click(this, new EventArgs());
		}

		private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fSwitchTable_Click(this, new EventArgs());
		}

		private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fCheck_Click(this, new EventArgs());
		}

		private void fPowerOffBt_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fHome_Click(object sender, EventArgs e)
		{

		}

		private void fTableList_Paint(object sender, PaintEventArgs e)
		{

		}

		private void fDiscountValue_ValueChanged(object sender, EventArgs e)
		{

		}

		private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void quayVềTrangĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fHome_TextChanged(object sender, EventArgs e)
		{

		}

		private void f3T_TextChanged(object sender, EventArgs e)
		{

		}

		private void fMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			fTableList.Controls.Clear();
			List<MenuDTO> tableList = MenuDAO.Instance.LocThucDon(fBevMenu.Text);
			//for (int i = 0; i < tableList.Count; i++)
			foreach (MenuDTO item in tableList)

			{
				//var item = tableList[i];


				Button btn = new Button() { Width = 225, Height = 300 };
				string fileAnh = "E:\\Downloads\\QLQuanTraSua-main\\QLQuanTraSua-main\\QLTraSua\\bin\\Debug\\Images\\" + item.Anh;
				btn.Image = System.Drawing.Image.FromFile(fileAnh);
				// Align the image and text on the button.
				btn.ImageAlign = ContentAlignment.MiddleCenter;
				btn.Font = new Font("Tahoma", 10);
				btn.Text = item.TenThucDon + Environment.NewLine + item.GiaTien;
				btn.TextAlign = ContentAlignment.BottomCenter;

				btn.Click += btn_Click;

				btn.Tag = item;

				fTableList.Controls.Add(btn);
			}
		}
	}
}
#endregion
