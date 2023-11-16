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
	public partial class frmThongKePhieuXuat : Form
	{
		PhieuxuatCRUD pxbll = new PhieuxuatCRUD();

		ChitietphieuxuatCRUD ctpxbll = new ChitietphieuxuatCRUD();
		DataTable dt = new DataTable();
		double Tong = 0;
		public double TongTien(DataTable dt)
		{
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Tong = Tong + double.Parse(dt.Rows[i][3].ToString());
			}
			return Tong;
		}
		public frmThongKePhieuXuat()
		{
			InitializeComponent();
		}

		private void tsThongKe_Click(object sender, EventArgs e)
		{
			DataTable dt = ctpxbll.TimKiemPX(dtpTuNgay.Value.ToShortDateString(), dtpDenNgay.Value.ToShortDateString());

			{
				dgThongKepx.DataSource = dt;
				if (dt.Rows.Count > 0)
				{
					txtTongTien.Text = TongTien(dt).ToString();
				}
				else
				{
					txtTongTien.Text = "";
				}
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			frmThongKePhieuXuat_Load(sender, e);
		}

		private void tsThoat_Click(object sender, EventArgs e)
		{
			DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (q.Equals(DialogResult.Yes))
			{
				this.Close();
			}
		}

		private void btTongTien_Click(object sender, EventArgs e)
		{

		}

		private void frmThongKePhieuXuat_Load(object sender, EventArgs e)
		{
			dgThongKepx.DataSource = ctpxbll.Loadctpx();
		}

		private void cbKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			Tong = 0;
			switch (cbKieuThongKe.Text.ToString())
			{
				case "Thống kê ngày ":
					dtpTuNgay.Value = DateTime.Parse(dt.ToShortDateString());
					dtpDenNgay.Value = DateTime.Parse(dt.ToShortDateString());
					break;
				case "Theo tháng":
					dtpTuNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month, dt.Year));
					dtpDenNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month + 1, dt.Year));
					break;
				case "Theo năm":
					dtpTuNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year));
					dtpDenNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year + 1));
					break;
			}
		}
	}
}
