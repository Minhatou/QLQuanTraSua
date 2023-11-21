USE [master]
GO
/****** Object:  Database [QLTraSua]    Script Date: 11/21/2023 6:59:51 PM ******/
CREATE DATABASE [QLTraSua]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeManager', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\CoffeManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeManager_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\CoffeManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLTraSua] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTraSua].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTraSua] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTraSua] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTraSua] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTraSua] SET  MULTI_USER 
GO
ALTER DATABASE [QLTraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTraSua] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTraSua] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTraSua] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTraSua] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTraSua] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLTraSua] SET QUERY_STORE = OFF
GO
USE [QLTraSua]
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoBan] [nvarchar](50) NOT NULL,
	[TrangThai] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDBanAn] [int] NOT NULL,
	[TrangThai] [int] NOT NULL,
	[TongTien] [float] NULL,
	[ThoiGianVao] [date] NOT NULL,
	[GiamGia] [int] NULL,
	[ThoiGianRa] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDoUong]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDoUong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDoUong] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VaiTro] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](20) NULL,
	[MatKhau] [nvarchar](1000) NULL,
	[LoaiID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinHoaDon]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHoaDon] [int] NOT NULL,
	[IDThucDon] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDLoaiDoUong] [int] NOT NULL,
	[TenDoUong] [nvarchar](50) NOT NULL,
	[DonGia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanAn] ON 

INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (1, N'Bàn số 0', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (2, N'Bàn số 1', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (3, N'Bàn số 2', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (4, N'Bàn số 3', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (5, N'Bàn số 4', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (6, N'Bàn số 5', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (7, N'Bàn số 6', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (8, N'Bàn số 7', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (9, N'Bàn số 8', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (10, N'Bàn số 9', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (11, N'Bàn số 10', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (12, N'Bàn số 11', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (13, N'Bàn số 12', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (14, N'Bàn số 13', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (15, N'Bàn số 14', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (16, N'Bàn số 15', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (17, N'Bàn số 16', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (18, N'Bàn số 17', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (19, N'Bàn số 18', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (20, N'Bàn số 19', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (33, N'Bàn số 20', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (34, N'Bàn số 1', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (35, N'Bàn số 2', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (36, N'Bàn số 3', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (37, N'Bàn số 4', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (38, N'Bàn số 5', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (39, N'Bàn số 6', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (40, N'Bàn số 7', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (41, N'Bàn số 8', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (42, N'Bàn số 9', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (43, N'Bàn số 10', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (44, N'Bàn số 11', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (45, N'Bàn số 12', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (46, N'Bàn số 13', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (47, N'Bàn số 14', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (48, N'Bàn số 15', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (49, N'Bàn số 16', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (50, N'Bàn số 17', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (51, N'Bàn số 18', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (52, N'Bàn số 19', N'Bàn trống')
INSERT [dbo].[BanAn] ([ID], [SoBan], [TrangThai]) VALUES (53, N'Bàn số 20', N'Bàn trống')
SET IDENTITY_INSERT [dbo].[BanAn] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (1, 2, 1, 35000, CAST(N'2023-02-13' AS Date), 0, CAST(N'2023-02-14' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (2, 1, 1, 30000, CAST(N'2023-02-13' AS Date), 50, CAST(N'2023-02-13' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (3, 1, 1, 25000, CAST(N'2023-02-13' AS Date), 0, CAST(N'2023-02-13' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (24, 1, 1, 57500, CAST(N'2023-02-20' AS Date), 50, CAST(N'2023-02-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (25, 2, 1, 60000, CAST(N'2023-02-20' AS Date), 0, CAST(N'2023-02-20' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (26, 2, 1, 35000, CAST(N'2023-02-20' AS Date), 0, CAST(N'2023-02-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (27, 2, 1, 0, CAST(N'2023-02-20' AS Date), 0, CAST(N'2023-02-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (33, 2, 1, 25000, CAST(N'2023-02-21' AS Date), 0, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (34, 1, 1, 25000, CAST(N'2023-02-21' AS Date), 0, CAST(N'2023-02-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (35, 7, 1, 700000, CAST(N'2023-02-21' AS Date), 0, CAST(N'2023-02-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (36, 10, 1, 25000, CAST(N'2023-02-22' AS Date), 0, CAST(N'2023-02-22' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (37, 15, 0, NULL, CAST(N'2023-02-22' AS Date), 0, NULL)
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (42, 2, 1, 35000, CAST(N'2023-02-23' AS Date), 0, CAST(N'2023-02-23' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (43, 1, 0, NULL, CAST(N'2023-02-23' AS Date), 0, NULL)
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (44, 4, 1, 23750, CAST(N'2023-02-23' AS Date), 5, CAST(N'2023-02-23' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (45, 2, 1, 25000, CAST(N'2023-02-23' AS Date), 0, CAST(N'2023-02-23' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (46, 8, 1, 50000, CAST(N'2023-11-21' AS Date), 0, CAST(N'2023-11-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (47, 11, 0, NULL, CAST(N'2023-11-21' AS Date), 0, NULL)
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (48, 7, 1, 90000, CAST(N'2023-11-21' AS Date), 10, CAST(N'2023-11-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (49, 50, 1, 80000, CAST(N'2023-11-21' AS Date), 0, CAST(N'2023-11-21' AS Date))
INSERT [dbo].[HoaDon] ([ID], [IDBanAn], [TrangThai], [TongTien], [ThoiGianVao], [GiamGia], [ThoiGianRa]) VALUES (50, 50, 1, 135000, CAST(N'2023-11-21' AS Date), 10, CAST(N'2023-11-21' AS Date))
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiDoUong] ON 

INSERT [dbo].[LoaiDoUong] ([ID], [TenDoUong]) VALUES (1, N'Trà hoa quả')
INSERT [dbo].[LoaiDoUong] ([ID], [TenDoUong]) VALUES (2, N'Trà sữa')
INSERT [dbo].[LoaiDoUong] ([ID], [TenDoUong]) VALUES (3, N'Kem')
SET IDENTITY_INSERT [dbo].[LoaiDoUong] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] ON 

INSERT [dbo].[LoaiTaiKhoan] ([ID], [VaiTro]) VALUES (1, N'Quản lí')
INSERT [dbo].[LoaiTaiKhoan] ([ID], [VaiTro]) VALUES (2, N'Nhân viên')
INSERT [dbo].[LoaiTaiKhoan] ([ID], [VaiTro]) VALUES (3, N'Quản lí')
INSERT [dbo].[LoaiTaiKhoan] ([ID], [VaiTro]) VALUES (4, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenTK], [ChucVu], [MatKhau], [LoaiID]) VALUES (N'Cuong', N'Nhân viên', N'2222', 2)
INSERT [dbo].[TaiKhoan] ([TenTK], [ChucVu], [MatKhau], [LoaiID]) VALUES (N'Dien', N'Nhân viên', N'3333', 2)
INSERT [dbo].[TaiKhoan] ([TenTK], [ChucVu], [MatKhau], [LoaiID]) VALUES (N'Nhat', N'Quản lí', N'1111', 1)
GO
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] ON 

INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (1, 2, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (2, 2, 3, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (3, 3, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (4, 1, 3, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (27, 25, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (28, 25, 3, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (30, 26, 3, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (31, 24, 4, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (32, 24, 5, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (33, 24, 6, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (34, 24, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (37, 34, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (38, 35, 1, 28)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (39, 36, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (45, 33, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (46, 44, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (47, 42, 3, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (48, 45, 1, 1)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (49, 46, 6, 2)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (50, 47, 3, 2)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (51, 48, 1, 4)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (52, 49, 1, 4)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (53, 50, 4, 3)
INSERT [dbo].[ThongTinHoaDon] ([ID], [IDHoaDon], [IDThucDon], [count]) VALUES (54, 50, 1, 3)
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[ThucDon] ON 

INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (1, 1, N'Nước chanh tươi lạnh', 20000)
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (2, 1, N'Trà đào Bigsize', 25000)
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (3, 2, N'Trà sữa 2J', 25000)
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (4, 2, N'Trà sữa Bá Vương', 30000)
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (5, 3, N'Super Sundae Xoài', 25000)
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (6, 3, N'Super Sundae Dâu Tây', 25000)
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia]) VALUES (13, 1, N'Super Sundae Trân châu đường đen', 25000)
SET IDENTITY_INSERT [dbo].[ThucDon] OFF
GO
ALTER TABLE [dbo].[BanAn] ADD  DEFAULT (N'Bàn chưa có số') FOR [SoBan]
GO
ALTER TABLE [dbo].[BanAn] ADD  DEFAULT (N'Bàn trống') FOR [TrangThai]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [ThoiGianVao]
GO
ALTER TABLE [dbo].[LoaiDoUong] ADD  DEFAULT (N'Chưa đặt tên') FOR [TenDoUong]
GO
ALTER TABLE [dbo].[LoaiTaiKhoan] ADD  DEFAULT (N'Trống') FOR [VaiTro]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT (N'Không') FOR [ChucVu]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [MatKhau]
GO
ALTER TABLE [dbo].[ThongTinHoaDon] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[ThucDon] ADD  DEFAULT (N'Chưa đặt tên') FOR [TenDoUong]
GO
ALTER TABLE [dbo].[ThucDon] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_HoaDon_IDBanAn] FOREIGN KEY([IDBanAn])
REFERENCES [dbo].[BanAn] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_HoaDon_IDBanAn]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_TaiKhoan_LoaiID] FOREIGN KEY([LoaiID])
REFERENCES [dbo].[LoaiTaiKhoan] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [fk_TaiKhoan_LoaiID]
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinHoaDon_IDHoaDon] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinHoaDon] CHECK CONSTRAINT [fk_ThongTinHoaDon_IDHoaDon]
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ThongTinHoaDon_IDThucDon] FOREIGN KEY([IDThucDon])
REFERENCES [dbo].[ThucDon] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThongTinHoaDon] CHECK CONSTRAINT [fk_ThongTinHoaDon_IDThucDon]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [fk_ThucDon_IDLoaiDoUong] FOREIGN KEY([IDLoaiDoUong])
REFERENCES [dbo].[LoaiDoUong] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [fk_ThucDon_IDLoaiDoUong]
GO
/****** Object:  StoredProcedure [dbo].[USP_CapNhatTK]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CapNhatTK]
@tentk nvarchar (50), @mk nvarchar (50), @mkmoi nvarchar (50)
as
 begin
     declare @mkdung int = 0
	 select @mkdung = count(*) from TaiKhoan where TenTK = @tentk and MatKhau = @mk
	 if (@mkdung = 1)
	 begin
	     if (@mkdung = null or @mkmoi = '')
		 begin 
		     update TaiKhoan set TenTK = @tentk where TenTK = @tentk
		 end
		 else
		     update TaiKhoan set TenTK = @tentk, MatKhau = @mkmoi where TenTK = @tentk
		 end
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_ChuyenBan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ChuyenBan]
@idban1 int, @idban2 int
as 
 begin
    declare @idhdbandau int
	declare @idhdcuoi int
	declare @idban1trong int = 1
	declare @idban2trong int = 1
	 select @idhdbandau = ID from HoaDon where IDBanAn = @idban1 and TrangThai = 0
	 select @idhdcuoi = ID from HoaDon where IDBanAn = @idban2 and TrangThai = 0
     select ID from HoaDon where IDBanAn = @idban1 and TrangThai = 0
	 if (@idhdbandau is null)
	  begin
	     insert into HoaDon (IDBanAn, ThoiGianVao, ThoiGianRa, TrangThai)
		 values (@idban1, getdate(), null, 0)
         select @idhdbandau = max(ID) from HoaDon 
		 where IDBanAn = @idban1 and TrangThai = 0
      end
	  select @idban1trong = count(*) from ThongTinHoaDon
	  where IDHoaDon = @idhdbandau
	  if (@idhdcuoi is null)
	  begin
	     insert into HoaDon (IDBanAn, ThoiGianVao, ThoiGianRa, TrangThai)
		 values (@idban2, getdate(), null, 0)
         select @idhdcuoi = max(ID) from HoaDon 
		 where IDBanAn = @idban2 and TrangThai = 0
      end
	  select @idban2trong = count(*) from ThongTinHoaDon
	  where IDHoaDon = @idhdcuoi
	  select id into IDHDTheoBan from ThongTinHoaDon
	  where IDHoaDon = @idhdcuoi
	  update ThongTinHoaDon set IDHoaDon = @idhdcuoi 
	  where IDHoaDon = @idhdbandau
	  update ThongTinHoaDon set IDHoaDon = @idhdbandau
	  where ID in (select * from IDHDTheoBan)
drop table IDHDTheoBan
	  if (@idban1trong = 0)
	      update BanAn set TrangThai = N'Bàn trống' where ID = @idban2
      if (@idban2trong = 0)
	      update BanAn set TrangThai = N'Bàn trống' where ID = @idban1

 end
GO
/****** Object:  StoredProcedure [dbo].[USP_DangNhap]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DangNhap]
@tentk nvarchar (50),
@matkhau nvarchar (50)
as
 begin
     select * from dbo.TaiKhoan where TenTK = @tentk and MatKhau = @matkhau
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_DanhSachBanAn]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DanhSachBanAn]
as select * from dbo.BanAn
GO
/****** Object:  StoredProcedure [dbo].[USP_DanhSachThucDon]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DanhSachThucDon]
as select * from dbo.ThucDon
GO
/****** Object:  StoredProcedure [dbo].[USP_DSHDTheoNgayVaTrang]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DSHDTheoNgayVaTrang]
@tgv date, @tgr date, @st int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows
	declare @exceptRows int = (@st - 1) * @pageRows
	
	;with HienHD as( select hd.ID, ba.SoBan as [Bàn số], hd.TongTien as [Tổng tiền], ThoiGianVao as [Ngày vào], ThoiGianRa as [Ngày ra], GiamGia as [Giảm giá]
	from HoaDon as hd, BanAn as ba
	where ThoiGianVao >= @tgv AND ThoiGianRa <= @tgr AND hd.TrangThai = 1
	AND ba.ID = hd.IDBanAn)
	
	select top (@selectRows) * from HienHD where ID NOT IN (SELECT TOP (@exceptRows) ID from HienHD)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTaiKhoanByTenTK]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetTaiKhoanByTenTK]
@tentk nvarchar (50)
as
 begin
   select * from dbo.TaiKhoan where TenTK = @tentk
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_GopBan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GopBan]
@idban1 int, @idban2 int
as
	begin
		declare @idhduncheck1 int = -1
		declare @idhduncheck2 int = -1
		select @idhduncheck1 = ID from HoaDon where IDBanAn = @idban1 and TrangThai = 0
		select @idhduncheck2 = ID from HoaDon where IDBanAn = @idban2 and TrangThai = 0

		if (@idhduncheck1 != -1 AND @idhduncheck2 != -1)
			begin
				declare @idtthd int
				select @idtthd = ID from ThongTinHoaDon where IDHoaDon = @idhduncheck1

				update ThongTinHoaDon set IDHoaDon = @idhduncheck2 where ID = @idtthd
				delete HoaDon where ID = @idhduncheck1

				update BanAn set TrangThai = N'Bàn trống' where ID = @idban1
			end
    end
GO
/****** Object:  StoredProcedure [dbo].[USP_LayDSHDTheoNgay]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_LayDSHDTheoNgay]
@tgv date , @tgr date
as
 begin
     select hd.id, hd.TongTien, ThoiGianVao, ThoiGianRa, GiamGia
	 from HoaDon as hd, BanAn as b
	 where ThoiGianVao >= @tgv and ThoiGianRa <= @tgr and hd.TrangThai = 1
	 and b.ID = hd.IDBanAn
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_NhapHD]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_NhapHD]
@idbanan int
as
 begin
     insert into HoaDon(ThoiGianVao, ThoiGianRa, IDBanAn, TrangThai, GiamGia)
	 values (getdate(), null, @idbanan, 0, 0)
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_NhapTTHD]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_NhapTTHD]
@idhoadon int, @idthucdon int, @soluong int
as
 begin
    declare @tthddaco int
    declare @sltd int = 1
     select @tthddaco = ID, @sltd = tthd.count 
     from ThongTinHoaDon as tthd
     where IDHoaDon = @idhoadon and IDThucDon = @idthucdon
     if (@tthddaco > 0)
	  begin
         declare @slmoi int = @sltd + @soluong
		    if (@slmoi > 0)
		     update ThongTinHoaDon set count = @slmoi where IDHoaDon = @idhoadon and IDThucDon = @idthucdon
			else
			 delete ThongTinHoaDon where IDHoaDon = @idhoadon and IDThucDon = @idthucdon
            end
	 else if (@soluong > 0)
      begin
	     insert into ThongTinHoaDon(IDHoaDon, IDThucDon, count)
	     values (@idhoadon, @idthucdon, @soluong)
	 end
 end

GO
/****** Object:  StoredProcedure [dbo].[USP_SoHD]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_SoHD]
@tgv date, @tgr date
as 
begin
	select count(*)
	from HoaDon as hd,BanAn AS ba
	WHERE ThoiGianVao >= @tgv AND ThoiGianRa <= @tgr AND hd.TrangThai = 1
	AND ba.ID = hd.IDBanAn
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SuaBan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_SuaBan]
@idbanan int, @tenban nvarchar(100)
as
	update BanAn set SoBan = @tenban WHERE ID = @idbanan
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemBan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ThemBan]
@tenban nvarchar(100)
as
	insert BanAn( SoBan )
	values  ( @tenban )
GO
/****** Object:  StoredProcedure [dbo].[USP_XoaBan]    Script Date: 11/21/2023 6:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_XoaBan]
@idbanan int
as begin
	declare @count int = 0
	select @count = count(*) from BanAn where ID = @idbanan and TrangThai = N'Bàn trống'

	if (@count <> 0)
	begin
		declare @idhd int
		select @idhd = hd.ID from HoaDon as hd, BanAn as ba where hd.IDBanAn = ba.ID

		delete ThongTinHoaDon where IDHoaDon = @idhd
		delete HoaDon where ID = @idhd
		delete BanAn where ID = @idbanan
	end
end
GO
USE [master]
GO
ALTER DATABASE [QLTraSua] SET  READ_WRITE 
GO
