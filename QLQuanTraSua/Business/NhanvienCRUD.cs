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
	class NhanvienCRUD
	{	
			DataProcessor dah = new DataProcessor();
			NhanvienSQL dal = new NhanvienSQL();
			public DataTable LoadNV()
			{
				return dal.LoadNV();
			}

			public void ThemNV(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
			{
				dal.Them(new Nhanvien(manv, tennv, gioitinh, dienthoai, diachi, socmnd));
			}
			public void SuaNV(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
			{
				dal.Sua(new Nhanvien(manv, tennv, gioitinh, dienthoai, diachi, socmnd));
			}
			public void XoaSP(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
			{
				dal.Xoa(new Nhanvien(manv, tennv, gioitinh, dienthoai, diachi, socmnd));
			}

			public DataTable Listmanv(string msp)
			{
				return dal.List1(msp);
			}
			public DataTable ListTennv(string tsp)
			{
				return dal.List2(tsp);
			}
			public int tongbanghi(string manv)
			{
				return dal.DemBanGhi(manv);
			}

		}
	}

