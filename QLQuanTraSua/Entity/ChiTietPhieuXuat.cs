using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanTraSua.Entity
{
	internal class ChiTietPhieuXuat
	{
		private string mapx;
		private string masp;
		private int soluong;
		private double thanhtien;
		#region thuoc tinh
		public string Mapx
		{
			get { return mapx; }
			set { mapx = value; }
		}

		public string Masp
		{
			get { return masp; }
			set { masp = value; }
		}
		public int Soluong
		{
			get { return soluong; }
			set { soluong = value; }
		}
		public double Thanhtien
		{
			get { return thanhtien; }
			set { thanhtien = value; }
		}
		#endregion

		//khoi tao 
		public ChiTietPhieuXuat(string mapx, string masp, int soluong, double thanhtien)
		{
			this.mapx = mapx;
			this.masp = masp;
			this.soluong = soluong;
			this.thanhtien = thanhtien;

		}
	}
}
