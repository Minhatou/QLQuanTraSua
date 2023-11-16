using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.Entity
{
	internal class SanPham
	{
		#region thuoc tinh
		private string masp;
		public string Masp
		{
			get { return masp; }
			set { masp = value; }
		}
		private string tensp;
		public string Tensp
		{
			get { return tensp; }
			set { tensp = value; }
		}
		private double dongia;
		public double Dongia
		{
			get { return dongia; }
			set { dongia = value; }
		}
		private string donvitinh;
		public string Donvitinh
		{
			get { return donvitinh; }
			set { donvitinh = value; }
		}
		private string loaisp;
		public string Loaisp
		{
			get { return loaisp; }
			set { loaisp = value; }
		}
		#endregion
		#region phuong thuc
		//phuong thuc khoi tao khong tham so
		public SanPham()
		{
			this.masp = "";
			this.tensp = "";
			this.dongia = 0;
			//this.soluong = 0;
			this.donvitinh = "";
			this.loaisp = "";
		}
		//phuong thuc khi tao co tham so
		public SanPham(string masp, string tensp, double dongia, string donvitinh, string loaisp)
		{
			this.masp = masp;
			this.tensp = tensp;
			this.dongia = dongia;
			//this.soluong = soluong;
			this.donvitinh = donvitinh;
			this.loaisp = loaisp;
		}
		#endregion
	}
}
