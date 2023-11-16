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
	public partial class frmMain : Form
	{
		public static string TenNguoiDung = "";
		public frmMain()
		{
			InitializeComponent();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSanPham qlsp = new frmSanPham();
			qlsp.ShowDialog();
		}

		private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyNhanVien qlnv = new frmQuanLyNhanVien();
			qlnv.ShowDialog();
		}

		private void quảnLýPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyPhieuXuat qlpx = new frmQuanLyPhieuXuat();
			qlpx.ShowDialog();
		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dg == DialogResult.Yes)
				Application.Exit();
		}

		private void thốngKếSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmThongKeSanPham tksp = new frmThongKeSanPham();
			tksp.ShowDialog();

		}

		private void thốngKêPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmThongKePhieuXuat tkpx = new frmThongKePhieuXuat();
			tkpx.ShowDialog();
		}

		private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			this.BackgroundImage = Properties.Resources._363343469_663459592495496_5772758379965676244_n;
			this.BackgroundImageLayout = ImageLayout.Stretch;
		}
	}
}
