using QLQuanTraSua.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.DataAccess
{
	internal class SanphamSQL
	{
		DataProcessor dah = new DataProcessor();


		public DataTable LoadSP()
		{
			string s = "Select * from SanPham";
			return dah.get_DaTaTable(s);
		}


		public void Them(SanPham sp)
		{
			//  int sbg = dah.TongBanGhi("Select masp from SanPham ");
			string s = "insert into SanPham values(N'" + sp.Masp + "',N'" + sp.Tensp + "','" + sp.Dongia + "',N'" + sp.Donvitinh + "',N'" + sp.Loaisp + "')";
			dah.ThucThiCL(s);

		}
		public void Xoa(SanPham sp)
		{
			dah.ThucThiCL("delete from SanPham where masp= N'" + sp.Masp + "'");
		}
		public void Sua(SanPham sp)
		{
			string caulenh = "Update SanPham set tensp= N'" + sp.Tensp + "',dongia='" + sp.Dongia + "',donvitinh=N'" + sp.Donvitinh + "',loaisp=N'" + sp.Loaisp + "' where masp='" + sp.Masp + "'";
			dah.ThucThiCL(caulenh);
		}
		public DataTable List1(string masp)
		{
			string caulenh = "select * from SanPham where masp='" + masp + "'";
			return dah.get_DaTaTable(caulenh);
		}
		public DataTable List2(string tensp)
		{
			string caulenh = "select * from SanPham where tensp=N'" + tensp + "'";
			return dah.get_DaTaTable(caulenh);
		}
		//public DataTable px(string masp)
		//{
		//    string caulenh = "select * from SanPham where masp='" + masp + "'";
		//    return dah.get_DaTaTable(caulenh);
		//}
		public DataTable laygia(string masp)
		{
			string caulenh = "select Dongia from SanPham where masp='" + masp + "'";
			return dah.get_DaTaTable(caulenh);
		}
		public int DemBanGhi(string masp)
		{
			int banghi;
			banghi = dah.TongBanGhi("select * from sanpham where masp='" + masp + "' ");
			return banghi;
		}
	}
}
