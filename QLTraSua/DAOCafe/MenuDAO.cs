using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeManager.DTOCafe;

namespace CoffeManager.DAOCafe
{
    public class MenuDAO
    {
			private static MenuDAO instance;

			public static MenuDAO Instance
			{
				get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
				private set { MenuDAO.instance = value; }
			}

			private MenuDAO() { }

			public List<MenuDTO> LayDSTDTheoBan(int id)
			{
				List<MenuDTO> listMenu = new List<MenuDTO>();

				string query = "\r\nselect bv.TenDoUong, ttd.count, bv.DonGia, bv.DonGia*ttd.count as TongGiaTien from dbo.ThongTinHoaDon as ttd, dbo.HoaDon as hd, dbo.ThucDon as bv \r\nwhere ttd.IDHoaDon = hd.ID and ttd.IDThucDon = bv.ID";

				DataTable data = DataProviderCF.Instance.ExecuteQuery(query);

				foreach (DataRow item in data.Rows)
				{
					MenuDTO menu = new MenuDTO(item);

					listMenu.Add(menu);
				}
				return listMenu;
			}
			public List<MenuDTO> TaoThucDon()
			{
				List<MenuDTO> tableList = new List<MenuDTO>();

				DataTable data = DataProviderCF.Instance.ExecuteQuery("USP_DanhSachThucDon");
				Console.WriteLine(data);
				foreach (DataRow item in data.Rows)
				{
					Console.WriteLine(item);
					MenuDTO table = new MenuDTO(item);

					tableList.Add(table);
				}

				return tableList;
			}
			public static string LayDonGia(string a)
			{
				string query = "select Dongia from ThucDon where TenDoUong = N'" + a + "'";
				DataTable data = DataProviderCF.Instance.ExecuteQuery(query);
				string name = data.Rows[0]["Dongia"].ToString();
				return name;
			}
			public List<MenuDTO> LocThucDon(string a)
			{
				List<MenuDTO> tableList = new List<MenuDTO>();
				string query = "SELECT * FROM ThucDon \r\nWHERE IDLoaiDoUong IN (\r\n    SELECT DISTINCT IDLoaiDoUong \r\n    FROM ThucDon \r\n    JOIN LoaiDoUong ON ThucDon.IDLoaiDoUong = LoaiDoUong.ID \r\n    WHERE LoaiDoUong.TenDoUong = N'" + a + "'\r\n)";
				DataTable data = DataProviderCF.Instance.ExecuteQuery(query);
				Console.WriteLine(data);
				foreach (DataRow item in data.Rows)
				{
					Console.WriteLine(item);
					MenuDTO table = new MenuDTO(item);

					tableList.Add(table);
				}

				return tableList;
			}
		}
	}