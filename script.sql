USE [QL_BanHang]
GO
/****** Object:  Table [dbo].[tb_CTHD]    Script Date: 5/13/2021 7:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHD](
	[MaHD] [varchar](10) NOT NULL,
	[MaHH] [varchar](10) NOT NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_tb_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HangHoa]    Script Date: 5/13/2021 7:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HangHoa](
	[MaHang] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](30) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[Anh] [nvarchar](200) NULL,
 CONSTRAINT [PK_tb_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_HoaDon]    Script Date: 5/13/2021 7:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[NguoiLap] [varchar](10) NULL,
	[KhachHang] [varchar](10) NULL,
 CONSTRAINT [PK_tb_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_KhachHang]    Script Date: 5/13/2021 7:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NamSinh] [date] NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [varchar](30) NULL,
 CONSTRAINT [PK_tb_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 5/13/2021 7:55:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NamSinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](11) NULL,
	[MatKhau] [varchar](20) NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_CTHD] ([MaHD], [MaHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD001', N'HH001', 3190000, 5, 15950000)
INSERT [dbo].[tb_CTHD] ([MaHD], [MaHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD002', N'HH002', 21990000, 5, 109950000)
INSERT [dbo].[tb_CTHD] ([MaHD], [MaHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD004', N'HH009', 36990000, 5, 184950000)
INSERT [dbo].[tb_CTHD] ([MaHD], [MaHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD005', N'HH008', 41490000, 5, 207450000)
INSERT [dbo].[tb_CTHD] ([MaHD], [MaHH], [DonGia], [SoLuong], [ThanhTien]) VALUES (N'HD006', N'HH001', 3190000, 4, 12760000)
GO
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH001', N'OPPO A15', 3190000, 9986, N'D:\QL_BanHang\Picture\HH001.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH002', N'iphone 12 64GB', 21990000, 9989, N'D:\QL_BanHang\Picture\HH002.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH003', N'Xiaomi Redmi Note 10 (6/128)', 5190000, 9999, N'D:\QL_BanHang\Picture\HH003.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH004', N'SamSung Galaxy A72', 11490000, 9994, N'D:\QL_BanHang\Picture\HH004.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH005', N'Vsmart Star 5 (3/64)', 2890000, 8879, N'D:\QL_BanHang\Picture\HH005.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH006', N'Vivo Y51 (2020)', 5990000, 4444, N'D:\QL_BanHang\Picture\HH006.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH007', N'Samsung Galazy Z Fold 2 5G', 50000000, 5555, N'D:\QL_BanHang\Picture\HH007.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH008', N'iphone 12 Pro Max 512GB', 41490000, 550, N'D:\QL_BanHang\Picture\HH008.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH009', N'iphone 12 Pro 512GB', 36990000, 4439, N'D:\QL_BanHang\Picture\HH009.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH010', N'iphone 12 Pro Max 256GB', 34490000, 5555, N'D:\QL_BanHang\Picture\HH010.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH011', N'iphone 12 Pro Max 128GB', 31690000, 3333, N'D:\QL_BanHang\Picture\HH011.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH012', N'Samsung Galaxy S21 Ultra 5G', 33990000, 5555, N'D:\QL_BanHang\Picture\HH012.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH014', N'Samsung Galaxy Note 20 Ultra', 29990000, 54555, N'D:\QL_BanHang\Picture\HH014.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH015', N'Samsung Galaxy Note 20 Ultra', 29990000, 33232, N'D:\QL_BanHang\Picture\HH015.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH016', N'iphone 12 Proo 128GB', 28990000, 231243, N'D:\QL_BanHang\Picture\HH016.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH017', N'Samsung S21 Ultra 5G 128GB', 30990000, 13123, N'D:\QL_BanHang\Picture\HH017.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH018', N'Samsung Note 20 Ultra', 26990000, 231231, N'D:\QL_BanHang\Picture\HH018.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH019', N'Samsung S21+ 5G 256GB', 28990000, 342342, N'D:\QL_BanHang\Picture\HH019.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH020', N'Iphone 12 256GB', 25990000, 3131, N'D:\QL_BanHang\Picture\HH020.jpg')
INSERT [dbo].[tb_HangHoa] ([MaHang], [TenHang], [DonGia], [SoLuong], [Anh]) VALUES (N'HH021', N'Samsung s21+ 5G 128GB', 25990000, 12312, N'D:\QL_BanHang\Picture\HH021.jpg')
GO
INSERT [dbo].[tb_HoaDon] ([MaHD], [NgayLap], [NguoiLap], [KhachHang]) VALUES (N'HD001', CAST(N'2021-05-13' AS Date), N'NV002', N'KH001')
INSERT [dbo].[tb_HoaDon] ([MaHD], [NgayLap], [NguoiLap], [KhachHang]) VALUES (N'HD002', CAST(N'2021-05-13' AS Date), N'NV001', N'KH002')
INSERT [dbo].[tb_HoaDon] ([MaHD], [NgayLap], [NguoiLap], [KhachHang]) VALUES (N'HD004', CAST(N'2021-05-13' AS Date), N'NV002', N'KH002')
INSERT [dbo].[tb_HoaDon] ([MaHD], [NgayLap], [NguoiLap], [KhachHang]) VALUES (N'HD005', CAST(N'2021-05-13' AS Date), N'NV002', N'KH001')
INSERT [dbo].[tb_HoaDon] ([MaHD], [NgayLap], [NguoiLap], [KhachHang]) VALUES (N'HD006', CAST(N'2021-05-13' AS Date), N'NV002', N'KH001')
GO
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [NamSinh], [SDT], [DiaChi], [Email]) VALUES (N'KH001', N'V?? Th??? Thu??? Trang', N'Nam', CAST(N'2001-09-15' AS Date), N'0912345678', N'351 L???c Long Qu??n', N'trang@gmail.com')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [NamSinh], [SDT], [DiaChi], [Email]) VALUES (N'KH002', N'Ph???m Nh?? ??', N'N???', CAST(N'2021-11-04' AS Date), N'0987123456', N'351 L???c Long Qu??n', N'nhuy@gmail.com')
GO
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NamSinh], [DiaChi], [SDT], [MatKhau]) VALUES (N'NV001', N'Tr???n Ng???c Ngh??a', N'N???', CAST(N'2001-12-01' AS Date), N'351 L???c Long', N'0941414503', N'')
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [GioiTinh], [NamSinh], [DiaChi], [SDT], [MatKhau]) VALUES (N'NV002', N'H??? Thanh H???i', N'Nam', CAST(N'2001-01-04' AS Date), N'Qu???n 4', N'1234567890', N'12345')
GO
ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHD_tb_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[tb_HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [FK_tb_CTHD_tb_HangHoa]
GO
ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHD_tb_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tb_HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [FK_tb_CTHD_tb_HoaDon]
GO
ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon_tb_KhachHang] FOREIGN KEY([KhachHang])
REFERENCES [dbo].[tb_KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tb_HoaDon] CHECK CONSTRAINT [FK_tb_HoaDon_tb_KhachHang]
GO
ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon_tb_NhanVien] FOREIGN KEY([NguoiLap])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_HoaDon] CHECK CONSTRAINT [FK_tb_HoaDon_tb_NhanVien]
GO
