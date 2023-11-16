using QLQuanTraSua.DataAccess;
using QLQuanTraSua.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.Business
{
	internal class ChitietphieuxuatCRUD
	{
		ChitietphieuxuatSQL bll = new ChitietphieuxuatSQL();
		DataProcessor dah = new DataProcessor();

		public DataTable Loadctpx()
		{
			return bll.Loadctpx();
		}

		public void Thempx(string mapx, string masp, int soluong, double thanhtien)
		{
			bll.Them(new ChiTietPhieuXuat(mapx, masp, soluong, thanhtien));
		}
		public DataTable Listctpx(string mapx)
		{
			return bll.List1(mapx);

		}
		public void XoaChiTietPhieuXuat(string mapx, string masp, int soluong, double thanhtien)
		{
			bll.Xoa(new ChiTietPhieuXuat(mapx, masp, soluong, thanhtien));
		}
		public DataTable TimKiemPX(string tu, string den)
		{
			return bll.TimKiemPX(tu, den);
		}

		public DataTable ThongKeSanPhamBanChay()
		{
			return bll.ThongKeHangBanChay();
		}
		public DataTable ThongKeSanPhamBanCham()
		{
			return bll.ThongKeHangBanCham();
		}
		public int tongbanghi(string mapx, string masp)
		{
			return bll.DemBanGhi(mapx, masp);
		}

	}
}
