using QLQuanTraSua.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.DataAccess
{
	internal class PhieuXuatSQL
	{
		DataProcessor dah = new DataProcessor();

		public DataTable LoadPX()
		{
			string s = "Select * from PhieuXuat";
			return dah.get_DaTaTable(s);
		}
		public void Them(PhieuXuat px)
		{
			DateTime hientai = DateTime.Now;
			string ngaygio = hientai.Month.ToString() + "/" + hientai.Day.ToString() + "/" + hientai.Year.ToString();
			string s = "insert into PhieuXuat values('" + px.Mapx + "','" + px.Manvxuat + "','" + ngaygio + "','" + px.Banso + "')";
			dah.ThucThiCL(s);
		}
		public void Xoa(PhieuXuat px)
		{
			dah.ThucThiCL("delete from PhieuXuat where mapx='" + px.Mapx + "'");
		}
		public DataTable px(string mapx)
		{
			string caulenh = "select * from Phieuxuat where mapx='" + mapx + "'";
			return dah.get_DaTaTable(caulenh);
		}
		public int DemBanGhi(string mapx)
		{
			int banghi;
			banghi = dah.TongBanGhi("select * from phieuxuat where mapx='" + mapx + "' ");
			return banghi;
		}
	}
}
