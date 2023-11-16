using QLQuanTraSua.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.DataAccess
{
	internal class NhanvienSQL
	{
			DataProcessor dah = new DataProcessor();


			public DataTable LoadNV()
			{
				string s = "Select * from Nhanvien";
				return dah.get_DaTaTable(s);
			}


			public void Them(Nhanvien nv)
			{

				string s = "insert into Nhanvien values(N'" + nv.Manv + "',N'" + nv.Tennv + "',N'" + nv.Gioitinh + "','" + nv.Dienthoai + "',N'" + nv.Diachi + "','" + nv.Socmnd + "')";
				dah.ThucThiCL(s);

			}
			public void Xoa(Nhanvien nv)
			{
				dah.ThucThiCL("delete from Nhanvien where manv= N'" + nv.Manv + "'");
			}
			public void Sua(Nhanvien nv)
			{
				string caulenh = "Update Nhanvien set tennv= N'" + nv.Tennv + "',gioitinh= N'" + nv.Gioitinh + "',dienthoai='" + nv.Dienthoai + "',diachi=N'" + nv.Diachi + "',Socmnd='" + nv.Socmnd + "' where manv='" + nv.Manv + "'";
				dah.ThucThiCL(caulenh);
			}
			public DataTable List1(string manv)
			{
				string caulenh = "select * from Nhanvien where manv='" + manv + "'";
				return dah.get_DaTaTable(caulenh);
			}
			public DataTable List2(string tennv)
			{
				string caulenh = "select * from Nhanvien where tennv=N'" + tennv + "'";
				return dah.get_DaTaTable(caulenh);
			}
			public int DemBanGhi(string manv)
			{
				int banghi;
				banghi = dah.TongBanGhi("select * from nhanvien where manv='" + manv + "' ");
				return banghi;
			}
		}
	}

