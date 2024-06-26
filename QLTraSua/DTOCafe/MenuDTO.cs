﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeManager.DTOCafe
{
    public class MenuDTO
    {
        public MenuDTO(float price, int count, string bev, float tp = 0, string anh = null)
        {
            this.TenThucDon = bev;
            
            this.SoLuong = count;
            
            this.GiaTien = price;
            
            this.TongGiaTien = tp;

            this.Anh = anh;
        }

        public MenuDTO(DataRow row)
        {
            this.TenThucDon = row["TenDoUong"].ToString();
            
            
            this.GiaTien = (float)Convert.ToDouble(row["DonGia"].ToString());

            this.Anh = row["Anh"].ToString();

		}

        private float tp;

        public float TongGiaTien
        {
            get { return tp; }
            
            set { tp = value; }
        }

        private float price;

        public float GiaTien
        {
            get { return price; }
            
            set { price = value; }
        }

        private int count;
        public int SoLuong
        {
            get { return count; }
           
            set { count = value; }
        }

        private string bev;

        public string TenThucDon
        {
            get { return bev; }
           
            set { bev = value; }
        }
		private string anh;

		public string Anh
		{
			get { return anh; }

			set { anh = value; }
		}
	}
}
