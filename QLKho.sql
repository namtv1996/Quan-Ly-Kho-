USE [QLNhaKho]
GO
/****** Object:  Table [dbo].[ChiTietHangHoa]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHangHoa](
	[mahh] [int] NOT NULL,
	[makho] [int] NOT NULL,
	[soluongton] [int] NULL CONSTRAINT [DF_ChiTietHangHoa_soluongton]  DEFAULT ((0)),
 CONSTRAINT [PK__ChiTietH__8A8ABF18801D3C35] PRIMARY KEY CLUSTERED 
(
	[mahh] ASC,
	[makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[macv] [int] IDENTITY(1,1) NOT NULL,
	[tencv] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[macv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiaDiem]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaDiem](
	[madd] [int] IDENTITY(1,1) NOT NULL,
	[tendd] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[madd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[mahh] [int] IDENTITY(1,1) NOT NULL,
	[tenhh] [nvarchar](50) NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[nhasx] [nvarchar](50) NULL,
	[maloaihh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[makh] [int] IDENTITY(1,1) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[sdt] [varchar](20) NULL,
	[ngaysinh] [datetime] NULL CONSTRAINT [DF_KhachHang_ngaysinh]  DEFAULT (getdate()),
	[gioitinh] [nvarchar](20) NULL CONSTRAINT [DF_KhachHang_gioitinh]  DEFAULT (N'Nam'),
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[makho] [int] IDENTITY(1,1) NOT NULL,
	[tenkho] [nvarchar](50) NULL,
	[madd] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[maloaihh] [int] IDENTITY(1,1) NOT NULL,
	[tenloaihh] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[maloaihh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[mancc] [int] IDENTITY(1,1) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[sdt] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nhansu]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhansu](
	[mans] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL CONSTRAINT [DF_Nhansu_gioitinh]  DEFAULT (N'Nam'),
	[ngaysinh] [datetime] NULL CONSTRAINT [DF_Nhansu_ngaysinh]  DEFAULT (getdate()),
	[diachi] [nvarchar](100) NULL,
	[sdt] [varchar](20) NULL,
	[macv] [int] NULL,
	[makho] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[mancc] [int] NOT NULL,
	[mahh] [int] NOT NULL,
	[ngaynhap] [datetime] NULL CONSTRAINT [DF_PhieuNhap_ngaynhap]  DEFAULT (getdate()),
	[soluong] [int] NULL CONSTRAINT [DF_PhieuNhap_soluong]  DEFAULT ((0)),
	[danhan] [int] NULL CONSTRAINT [DF_PhieuNhap_danhan]  DEFAULT ((0)),
	[ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK__PhieuNha__3DD8D43FC407FE2E] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC,
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[makh] [int] NOT NULL,
	[mahh] [int] NOT NULL,
	[soluong] [int] NULL CONSTRAINT [DF_PhieuXuat_soluong]  DEFAULT ((0)),
	[ngayxuat] [datetime] NULL CONSTRAINT [DF_PhieuXuat_ngayxuat]  DEFAULT (getdate()),
	[ngaynhan] [datetime] NULL CONSTRAINT [DF_PhieuXuat_ngaynhan]  DEFAULT (getdate()),
	[danhan] [int] NULL CONSTRAINT [DF_PhieuXuat_danhan]  DEFAULT ((1)),
	[ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK__PhieuXua__4D83AB460956E3B9] PRIMARY KEY CLUSTERED 
(
	[makh] ASC,
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (1, 1, 1)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (2, 2, 2)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (3, 1, 4)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (5, 2, 8)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (6, 1, 4)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (7, 2, 28)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (8, 1, 40)
INSERT [dbo].[ChiTietHangHoa] ([mahh], [makho], [soluongton]) VALUES (9, 1, 20)
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([macv], [tencv]) VALUES (1, N'giam doc')
INSERT [dbo].[ChucVu] ([macv], [tencv]) VALUES (2, N'nhan vien')
INSERT [dbo].[ChucVu] ([macv], [tencv]) VALUES (3, N'ke toan')
INSERT [dbo].[ChucVu] ([macv], [tencv]) VALUES (4, N'van chuyen')
INSERT [dbo].[ChucVu] ([macv], [tencv]) VALUES (5, N'quan doc')
INSERT [dbo].[ChucVu] ([macv], [tencv]) VALUES (6, N'bao ve')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[DiaDiem] ON 

INSERT [dbo].[DiaDiem] ([madd], [tendd]) VALUES (1, N'ha noi')
INSERT [dbo].[DiaDiem] ([madd], [tendd]) VALUES (2, N'hai phong')
SET IDENTITY_INSERT [dbo].[DiaDiem] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (1, N'kem que', N'hong', N'mr.pusheen', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (2, N'kem oc que', N'tot', N'mr.stormy', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (3, N'keo', N'tot', N'mr.pusheen', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (5, N'chip chip', N'tot', N'mr.heo', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (6, N'ice cream', N'tot', N'nha sx 1', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (7, N'Bánh mì', N'Tốt', N'Pusheen', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (8, N'Bánh kem', N'Tốt', N'ice cream', 1)
INSERT [dbo].[HangHoa] ([mahh], [tenhh], [tinhtrang], [nhasx], [maloaihh]) VALUES (9, N'Coffee', N'Tốt', N'Pusheen', 2)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (1, N'khach hang 1', N'ha noi', N'0123456789', CAST(N'1996-07-13 00:00:00.000' AS DateTime), N'nam')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (2, N'khach hang 2', N'hai phong', N'0123456788', CAST(N'1996-08-14 00:00:00.000' AS DateTime), N'nu')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (4, N'khach hang 4', N'thai binh', N'0962374650', CAST(N'2017-03-30 00:00:00.000' AS DateTime), N'Nu')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (5, N'khach hang 4', N'thai binh', N'962374650', CAST(N'2017-03-30 00:00:00.000' AS DateTime), N'Nu')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (6, N'khach hang 5', N'tuyen quang', N'1679436543', CAST(N'2017-03-31 00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (7, N'khach hang 6', N'hưng yên', N'0166666666', CAST(N'2017-03-31 00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (8, N'khach hang 99', N'vinh phuc', N'16794365222', CAST(N'2017-03-31 00:00:00.000' AS DateTime), N'Nu')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (9, N'khach hang 98', N'thai thuy', N'167650720', CAST(N'2017-03-31 00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (10, N'khach hang 97', N'some where ', N'11111111', CAST(N'2017-03-30 00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (12, N'Meo', N'at home', N'0962374650', CAST(N'2017-12-31 00:00:00.000' AS DateTime), N'Nu')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (13, N'Pusheen', N'khong biet', N'0962374650', CAST(N'2017-07-08 00:00:00.000' AS DateTime), N'Nu')
INSERT [dbo].[KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh]) VALUES (14, N'Lê Quỳnh', N'Ở nhà', N'01675857755', CAST(N'1996-05-18 00:00:00.000' AS DateTime), N'Nu')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([makho], [tenkho], [madd]) VALUES (1, N'kho 1', 1)
INSERT [dbo].[Kho] ([makho], [tenkho], [madd]) VALUES (2, N'kho 2', 1)
SET IDENTITY_INSERT [dbo].[Kho] OFF
SET IDENTITY_INSERT [dbo].[LoaiHangHoa] ON 

INSERT [dbo].[LoaiHangHoa] ([maloaihh], [tenloaihh]) VALUES (1, N'Đồ ăn')
INSERT [dbo].[LoaiHangHoa] ([maloaihh], [tenloaihh]) VALUES (2, N'Đồ uống')
INSERT [dbo].[LoaiHangHoa] ([maloaihh], [tenloaihh]) VALUES (3, N'Khác')
SET IDENTITY_INSERT [dbo].[LoaiHangHoa] OFF
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([mancc], [tenncc], [diachi], [sdt]) VALUES (1, N'nha cung cap 1', N'ha noi', NULL)
INSERT [dbo].[NhaCungCap] ([mancc], [tenncc], [diachi], [sdt]) VALUES (2, N'nha cung cap 2', N'ha noi', NULL)
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
SET IDENTITY_INSERT [dbo].[Nhansu] ON 

INSERT [dbo].[Nhansu] ([mans], [hoten], [gioitinh], [ngaysinh], [diachi], [sdt], [macv], [makho]) VALUES (1, N'nguyen van a', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Nhansu] ([mans], [hoten], [gioitinh], [ngaysinh], [diachi], [sdt], [macv], [makho]) VALUES (2, N'nguyen van b', NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Nhansu] OFF
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (1, 1, CAST(N'2017-05-11 00:00:00.000' AS DateTime), 2, NULL, N'khong')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (1, 3, CAST(N'2017-05-12 23:43:27.170' AS DateTime), 20, 1, N'khong')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (1, 5, CAST(N'2017-05-13 04:14:11.293' AS DateTime), 22, 1, N'khong')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (1, 8, CAST(N'2017-05-13 16:28:49.297' AS DateTime), 100, 1, N'Không')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (2, 2, CAST(N'2017-05-11 00:00:00.000' AS DateTime), 3, NULL, N'khong')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (2, 6, CAST(N'2017-05-09 17:02:28.393' AS DateTime), 10, 1, N'khoong')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (2, 7, CAST(N'2017-05-13 15:56:31.117' AS DateTime), 20, 1, N'Không')
INSERT [dbo].[PhieuNhap] ([mancc], [mahh], [ngaynhap], [soluong], [danhan], [ghichu]) VALUES (2, 9, CAST(N'2017-05-15 18:53:20.733' AS DateTime), 20, 1, N'Không')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 1, 1, CAST(N'2017-05-13 04:10:08.220' AS DateTime), CAST(N'2017-05-13 04:10:08.213' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 2, 1, CAST(N'2017-05-09 17:04:09.020' AS DateTime), CAST(N'2017-05-09 17:04:09.020' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 3, 10, CAST(N'2017-05-17 05:50:46.647' AS DateTime), CAST(N'2017-05-17 05:50:46.643' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 5, 2, CAST(N'2017-05-15 14:21:56.720' AS DateTime), CAST(N'2017-05-15 14:21:56.720' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 6, 6, CAST(N'2017-05-09 17:04:09.020' AS DateTime), CAST(N'2017-05-09 17:04:09.020' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 7, 1, CAST(N'2017-05-15 14:21:56.720' AS DateTime), CAST(N'2017-05-15 14:21:56.720' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (1, 8, 10, CAST(N'2017-05-15 19:07:48.917' AS DateTime), CAST(N'2017-05-15 19:07:48.917' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (2, 1, 2, CAST(N'2017-05-17 05:40:40.530' AS DateTime), CAST(N'2017-05-17 05:40:40.530' AS DateTime), 0, N'khong')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (2, 2, 1, CAST(N'2017-05-17 05:40:40.530' AS DateTime), CAST(N'2017-05-17 05:40:40.530' AS DateTime), 0, N'khong')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (2, 3, 1, CAST(N'2017-05-17 05:40:40.530' AS DateTime), CAST(N'2017-05-17 05:40:40.530' AS DateTime), 0, N'khong')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (4, 8, 21, CAST(N'2017-05-13 16:29:32.730' AS DateTime), CAST(N'2017-05-13 16:29:32.730' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (12, 7, 5, CAST(N'2017-05-14 11:18:58.203' AS DateTime), CAST(N'2017-05-14 11:18:58.200' AS DateTime), 0, N'')
INSERT [dbo].[PhieuXuat] ([makh], [mahh], [soluong], [ngayxuat], [ngaynhan], [danhan], [ghichu]) VALUES (12, 8, 19, CAST(N'2017-05-14 11:18:58.203' AS DateTime), CAST(N'2017-05-14 11:18:58.200' AS DateTime), 0, N'')
ALTER TABLE [dbo].[ChiTietHangHoa]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHa__makho__1FCDBCEB] FOREIGN KEY([makho])
REFERENCES [dbo].[Kho] ([makho])
GO
ALTER TABLE [dbo].[ChiTietHangHoa] CHECK CONSTRAINT [FK__ChiTietHa__makho__1FCDBCEB]
GO
ALTER TABLE [dbo].[ChiTietHangHoa]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHan__mahh__1ED998B2] FOREIGN KEY([mahh])
REFERENCES [dbo].[HangHoa] ([mahh])
GO
ALTER TABLE [dbo].[ChiTietHangHoa] CHECK CONSTRAINT [FK__ChiTietHan__mahh__1ED998B2]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHangHoa] FOREIGN KEY([maloaihh])
REFERENCES [dbo].[LoaiHangHoa] ([maloaihh])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHangHoa]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD FOREIGN KEY([madd])
REFERENCES [dbo].[DiaDiem] ([madd])
GO
ALTER TABLE [dbo].[Nhansu]  WITH CHECK ADD FOREIGN KEY([macv])
REFERENCES [dbo].[ChucVu] ([macv])
GO
ALTER TABLE [dbo].[Nhansu]  WITH CHECK ADD FOREIGN KEY([makho])
REFERENCES [dbo].[Kho] ([makho])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK__PhieuNhap__mahh__239E4DCF] FOREIGN KEY([mahh])
REFERENCES [dbo].[HangHoa] ([mahh])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK__PhieuNhap__mahh__239E4DCF]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK__PhieuNhap__mancc__22AA2996] FOREIGN KEY([mancc])
REFERENCES [dbo].[NhaCungCap] ([mancc])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK__PhieuNhap__mancc__22AA2996]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK__PhieuXuat__mahh__29572725] FOREIGN KEY([mahh])
REFERENCES [dbo].[HangHoa] ([mahh])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK__PhieuXuat__mahh__29572725]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK__PhieuXuat__makh__286302EC] FOREIGN KEY([makh])
REFERENCES [dbo].[KhachHang] ([makh])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK__PhieuXuat__makh__286302EC]
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_nhap]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_nhap]
@makho int, @mancc int, @ngaynhap datetime, @soluong int, @danhan int, @ghichu nvarchar(100),
@ten nvarchar(50),@tinhtrang nvarchar(100), @maloaihh int, @nhasx nvarchar(50)
as begin
begin try
	insert into hanghoa (tenhh, tinhtrang, maloaihh, nhasx) 
	values (@ten, @tinhtrang, @maloaihh, @nhasx)
	declare @ma int
	select @ma=mahh from hanghoa
	insert into ChiTietHangHoa (mahh, makho, soluongton) values (@ma, @makho, @soluong)
	insert into PhieuNhap(mancc, mahh, ngaynhap, soluong, danhan, ghichu)
	values(@mancc,@ma,@ngaynhap,@soluong,@danhan,@ghichu)
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_search]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_hh_search] 
@value nvarchar(100)
as begin
	select a.*, b.soluongton,e.ngaynhap, e.mancc, b.makho from hanghoa a 
	left join ChiTietHangHoa b on a.mahh=b.mahh
	inner join Kho X on b.makho=X.makho
	inner join LoaiHangHoa Z on a.maloaihh=Z.maloaihh
	inner join 
		(select c.mahh,d.tenncc, c.ngaynhap, c.mancc from phieunhap c 
			inner join nhacungcap d on c.mancc=d.mancc) e
	on a.mahh=e.mahh
	where cast(a.mahh as nvarchar) like @value or a.tenhh like @value
		or cast(e.ngaynhap as varchar) like @value or e.tenncc like @value
		or X.tenkho like @value or Z.tenloaihh like @value
		or cast(b.soluongton as varchar) like @value
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_sua]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_sua] @makho int, @mahh int, @tenhh nvarchar(50), @tinhtrang nvarchar(100),
@mancc int, @maloaihh int, @soluongton int, @ngaynhap datetime, @nhasx nvarchar(50)
as begin
begin try
	update hanghoa set tenhh=@tenhh, tinhtrang=@tinhtrang, maloaihh=@maloaihh,
	nhasx=@nhasx where mahh=@mahh
	update ChiTietHangHoa set soluongton=@soluongton,makho=@makho where mahh=@mahh
	update phieunhap set ngaynhap=@ngaynhap,mancc=@mancc where mahh=@mahh
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_thongkenhap]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_hh_thongkenhap]
as begin
	select top 5 cast(ngaynhap as date) ngaynhap, count(*) soluong
           from phieunhap group by cast(ngaynhap as date)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_thongkesoluong]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_thongkesoluong]
as begin
select top 5 cast(C.ngaynhap as date) ngaynhap, A.soluongton from ChiTietHangHoa A 
inner join HangHoa B on A.mahh=B.mahh
inner join PhieuNhap C on B.mahh=C.mahh
group by cast(C.ngaynhap as date), A.soluongton
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_thongkexuat]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_hh_thongkexuat]
as begin
	select top 5 cast(ngayxuat as date) ngayxuat, count(*) soluong 
           from phieuxuat group by cast(ngayxuat as date)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_xem]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_xem]
as begin
	select a.*, b.soluongton,e.ngaynhap, e.mancc, b.makho from hanghoa a 
	left join ChiTietHangHoa b on a.mahh=b.mahh
	inner join 
		(select c.mahh, c.ngaynhap, c.mancc from phieunhap c 
			inner join nhacungcap d on c.mancc=d.mancc) e
	on a.mahh=e.mahh
end
GO
/****** Object:  StoredProcedure [dbo].[sp_hh_xuat]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_hh_xuat] 
@makh int, @mahh int, @soluong int, @ngayxuat datetime, @ngaynhan datetime,
@ghichu nvarchar(100), @danhan int, @makho int
as begin

	if exists(select * from PhieuXuat where mahh=@mahh and makh=@makh)
	begin
		update PhieuXuat set ngayxuat=@ngayxuat,ngaynhan=@ngaynhan,ghichu=@ghichu,danhan=@danhan
		where mahh=@mahh and makh=@makh
	end
	else
	begin
		insert into PhieuXuat(makh, mahh, soluong, ngayxuat, ngaynhan, danhan, ghichu)
		values(@makh, @mahh, @soluong, @ngayxuat, @ngaynhan, @danhan, @ghichu)
	end
	update ChiTietHangHoa set soluongton=soluongton-@soluong 
	where mahh=@mahh and makho=@makho

end
GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_search]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_khachhang_search]
@value nvarchar(100)
as begin
	select * from KhachHang where cast(makh as varchar) like @value
		or tenkh like @value or cast(ngaysinh as varchar) like @value
		or gioitinh like @value or diachi like @value or sdt like @value
end 
GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_sua]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_khachhang_sua]
@makh int, @tenkh nvarchar(50), @gioitinh nvarchar(20), @ngaysinh datetime,
@diachi nvarchar(200), @sdt varchar(20)
as begin
	update khachhang set tenkh=@tenkh, gioitinh=@gioitinh, ngaysinh=@ngaysinh,
		diachi=@diachi, sdt=@sdt where makh=@makh
end
GO
/****** Object:  StoredProcedure [dbo].[sp_khachhang_them]    Script Date: 5/15/2017 7:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_khachhang_them]
@tenkh nvarchar(50), @gioitinh nvarchar(20), @ngaysinh datetime,
@diachi nvarchar(200), @sdt varchar(20)
as begin
	insert into KhachHang (tenkh, gioitinh, ngaysinh, diachi, sdt)
	values (@tenkh, @gioitinh, @ngaysinh, @diachi, @sdt)
end
GO
