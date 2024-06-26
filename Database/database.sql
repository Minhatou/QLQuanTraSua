USE [master]
GO
/****** Object:  Database [QuanLyTraSua]    Script Date: 11/22/2023 12:39:30 PM ******/
CREATE DATABASE [QuanLyTraSua]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTraSua', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\QuanLyTraSua.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyTraSua_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\QuanLyTraSua_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyTraSua] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTraSua].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTraSua] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyTraSua] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTraSua] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTraSua] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyTraSua] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTraSua] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTraSua] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTraSua] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTraSua] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTraSua] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTraSua] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyTraSua] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyTraSua] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyTraSua] SET QUERY_STORE = OFF
GO
USE [QuanLyTraSua]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/22/2023 12:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TongTien] [float] NULL,
	[ThoiGian] [date] NOT NULL,
	[GiamGia] [int] NULL,
	[ThanhToan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDoUong]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  Table [dbo].[ThongTinHoaDon]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  Table [dbo].[ThucDon]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDLoaiDoUong] [int] NOT NULL,
	[TenDoUong] [nvarchar](50) NOT NULL,
	[DonGia] [float] NOT NULL,
	[Anh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (1, 35000, CAST(N'2023-02-13' AS Date), 0, 35000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (2, 30000, CAST(N'2023-02-13' AS Date), 50, 15000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (3, 25000, CAST(N'2023-02-13' AS Date), 0, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (24, 50000, CAST(N'2023-02-20' AS Date), 50, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (25, 60000, CAST(N'2023-02-20' AS Date), 0, 60000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (26, 35000, CAST(N'2023-02-20' AS Date), 0, 35000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (27, 35000, CAST(N'2023-02-20' AS Date), 0, 35000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (33, 25000, CAST(N'2023-02-21' AS Date), 0, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (34, 25000, CAST(N'2023-02-21' AS Date), 0, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (35, 700000, CAST(N'2023-02-21' AS Date), 0, 700000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (36, 25000, CAST(N'2023-02-22' AS Date), 0, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (37, 25000, CAST(N'2023-02-22' AS Date), 0, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (42, 35000, CAST(N'2023-02-23' AS Date), 0, 35000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (43, 45000, CAST(N'2023-02-23' AS Date), 0, 45000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (44, 30000, CAST(N'2023-10-23' AS Date), 50, 15000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (45, 25000, CAST(N'2023-10-23' AS Date), 0, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (46, 250000, CAST(N'2023-11-22' AS Date), 50, 125000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (48, 50000, CAST(N'2023-11-22' AS Date), 50, 25000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (49, 70000, CAST(N'2023-11-22' AS Date), 0, 70000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (50, 210000, CAST(N'2023-11-22' AS Date), 10, 193500)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (51, 75000, CAST(N'2023-11-22' AS Date), 0, 75000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (52, 90000, CAST(N'2023-11-22' AS Date), 10, 81000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (53, 75000, CAST(N'2023-11-22' AS Date), 0, 75000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (54, 60000, CAST(N'2023-11-22' AS Date), 50, 30000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (55, 125000, CAST(N'2023-11-22' AS Date), 10, 112500)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (56, 125000, CAST(N'2023-11-22' AS Date), 0, 125000)
INSERT [dbo].[HoaDon] ([ID], [TongTien], [ThoiGian], [GiamGia], [ThanhToan]) VALUES (57, 25000, CAST(N'2023-11-22' AS Date), 50, 12500)
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
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenTK], [ChucVu], [MatKhau], [LoaiID]) VALUES (N'Cuong', N'Nhân viên', N'3333', 2)
INSERT [dbo].[TaiKhoan] ([TenTK], [ChucVu], [MatKhau], [LoaiID]) VALUES (N'Dien', N'Nhân viên', N'2222', 2)
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
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[ThucDon] ON 

INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (1, 1, N'Nước chanh tươi lạnh', 20000, N'001.jpg')
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (2, 1, N'Trà Đào Bigsize', 25000, N'002.jpg')
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (3, 2, N'Trà sữa 2J', 25000, N'003.jpg
')
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (4, 2, N'Trà sữa Bá Vương', 30000, N'004.jpg')
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (5, 3, N'Super Sundae Xoài', 25000, N'005.jpg')
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (6, 3, N'Super Sundae Dâu tây', 25000, N'006.jpg')
INSERT [dbo].[ThucDon] ([ID], [IDLoaiDoUong], [TenDoUong], [DonGia], [Anh]) VALUES (9, 1, N'Trà đào bốn mùa', 25000, N'007.jpg')
SET IDENTITY_INSERT [dbo].[ThucDon] OFF
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [ThoiGian]
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
/****** Object:  StoredProcedure [dbo].[USP_CapNhatTK]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_DangNhap]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_DanhSachThucDon]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DanhSachThucDon]
as select * from dbo.ThucDon
GO
/****** Object:  StoredProcedure [dbo].[USP_DSHDTheoNgayVaTrang]    Script Date: 11/22/2023 12:39:31 PM ******/
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
	
	;with HienHD as( select hd.ID, hd.TongTien as [Tổng tiền], ThoiGianVao as [Ngày vào], ThoiGianRa as [Ngày ra], GiamGia as [Giảm giá]
	from HoaDon as hd
	where ThoiGianVao >= @tgv AND ThoiGianRa <= @tgr)
	
	select top (@selectRows) * from HienHD where ID NOT IN (SELECT TOP (@exceptRows) ID from HienHD)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTaiKhoanByTenTK]    Script Date: 11/22/2023 12:39:31 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_LayDonGia]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_LayDonGia]
@Tendouong nvarchar(400)
as
begin
select Dongia from dbo.ThucDon where TenDoUong = @TenDoUong
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LayDSHDTheoNgay]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_LayDSHDTheoNgay]
@tgv date, @tgr date  
as
 begin
     select hd.ID, hd.TongTien, hd.ThoiGian, hd.GiamGia, hd.ThanhToan
	 from HoaDon as hd
	 where hd.ThoiGian >= @tgv and hd.ThoiGian <= @tgr
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_NhapHD]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_NhapHD]
as
 begin
     insert into HoaDon(ThoiGianVao, ThoiGianRa, GiamGia)
	 values (getdate(), null, 0)
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_NhapTTHD]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_NhapTTHD]
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
/****** Object:  StoredProcedure [dbo].[USP_SoHD]    Script Date: 11/22/2023 12:39:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_SoHD]
@tgv date, @tgr date
as 
begin
	select count(*)
	from HoaDon as hd
	WHERE ThoiGianVao >= @tgv AND ThoiGianRa <= @tgr
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyTraSua] SET  READ_WRITE 
GO
