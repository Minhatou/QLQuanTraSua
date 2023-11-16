using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.Entity
{
	class Nhanvien
	{
			private string manv;
			private string tennv;
			private string gioitinh;
			private string dienthoai;
			private string diachi;
			private string socmnd;
			#region thuoc tinh
			public string Manv
			{
				get { return manv; }
				set { manv = value; }
			}
			public string Tennv
			{
				get { return tennv; }
				set { tennv = value; }
			}
			public string Gioitinh
			{
				get { return gioitinh; }
				set { gioitinh = value; }
			}
			public string Dienthoai
			{
				get { return dienthoai; }
				set { dienthoai = value; }
			}
			public string Diachi
			{
				get { return diachi; }
				set { diachi = value; }
			}
			public string Socmnd
			{
				get { return socmnd; }
				set { socmnd = value; }
			}
			#endregion
			#region phuong thuc khoi tao
			// khoi tao khong tham so
			public Nhanvien()
			{
				this.manv = "";
				this.tennv = "";
				this.gioitinh = "";
				this.dienthoai = "";
				this.diachi = "";
				this.socmnd = "";

			}
			//khoi tao co tham so
			public Nhanvien(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
			{
				this.manv = manv;
				this.tennv = tennv;
				this.gioitinh = gioitinh;
				this.dienthoai = dienthoai;
				this.diachi = diachi;
				this.socmnd = socmnd;

			}
			#endregion
	}
}
