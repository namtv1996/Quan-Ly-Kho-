USE [QLNhaKho]
GO
/****** Object:  Table [dbo].[ChiTietHangHoa]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHangHoa](
	[mahh] [int] NOT NULL,
	[makho] [int] NOT NULL,
	[soluongton] [int] NULL,
 CONSTRAINT [PK__ChiTietH__8A8ABF18801D3C35] PRIMARY KEY CLUSTERED 
(
	[mahh] ASC,
	[makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/14/2017 8:40:37 PM ******/
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
/****** Object:  Table [dbo].[DiaDiem]    Script Date: 5/14/2017 8:40:37 PM ******/
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
/****** Object:  Table [dbo].[HangHoa]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[mahh] [int] IDENTITY(1,1) NOT NULL,
	[tenhh] [nvarchar](50) NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[ngaysx] [datetime] NULL,
	[hansd] [datetime] NULL,
	[nhasx] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/14/2017 8:40:37 PM ******/
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
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 5/14/2017 8:40:37 PM ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/14/2017 8:40:37 PM ******/
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
/****** Object:  Table [dbo].[Nhansu]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhansu](
	[mans] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](10) NULL,
	[ngaysinh] [datetime] NULL,
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[mancc] [int] NOT NULL,
	[mahh] [int] NOT NULL,
	[ngaynhap] [datetime] NULL,
	[soluong] [int] NULL,
	[danhan] [int] NULL,
	[ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK__PhieuNha__3DD8D43FC407FE2E] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC,
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[makh] [int] NOT NULL,
	[mahh] [int] NOT NULL,
	[soluong] [int] NULL,
	[ngayxuat] [datetime] NULL,
	[ngaynhan] [datetime] NULL,
	[danhan] [int] NULL,
	[ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK__PhieuXua__4D83AB460956E3B9] PRIMARY KEY CLUSTERED 
(
	[makh] ASC,
	[mahh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
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
/****** Object:  StoredProcedure [dbo].[commodity_exporting]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[commodity_exporting] 
@makh int, @mahh int, @soluong int, @ngayxuat datetime, @ngaynhan datetime,
@ghichu nvarchar(100), @danhan int, @makho int
as begin
begin transaction
begin try
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
	commit
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[commodity_insertion]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[commodity_insertion]
@makho int, @mancc int, @ngaynhap datetime, @soluong int, @danhan int, @ghichu nvarchar(100),
@ten nvarchar(50),@tinhtrang nvarchar(100), @ngaysx datetime, @hansd datetime, @nhasx nvarchar(50)
as begin
begin try
	insert into hanghoa (tenhh, tinhtrang, ngaysx, hansd, nhasx) 
	values (@ten, @tinhtrang, @ngaysx, @hansd, @nhasx)
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
/****** Object:  StoredProcedure [dbo].[commodity_modification]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[commodity_modification] @makho int, @mahh int, @tenhh nvarchar(50), @tinhtrang nvarchar(100),
@mancc int, @ngaysx datetime, @hansd datetime, @soluongton int, @ngaynhap datetime, @nhasx nvarchar(50)
as begin
begin try
	update hanghoa set tenhh=@tenhh, tinhtrang=@tinhtrang, ngaysx=@ngaysx, hansd=@hansd,
	nhasx=@nhasx where mahh=@mahh
	update ChiTietHangHoa set soluongton=@soluongton,makho=@makho where mahh=@mahh
	update phieunhap set ngaynhap=@ngaynhap,mancc=@mancc where mahh=@mahh
end try
begin catch
	rollback
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[commodity_selection]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[commodity_selection]
as begin
select a.mahh, a.tenhh, b.soluongton, b.makho from hanghoa a 
left join ChiTietHangHoa b on a.mahh=b.mahh
end
GO
/****** Object:  StoredProcedure [dbo].[commodity_view]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[commodity_view] @makho int
as begin
select a.*, b.soluongton,e.ngaynhap, e.mancc from hanghoa a left join ChiTietHangHoa b on a.mahh=b.mahh
inner join (select c.mahh, c.ngaynhap, c.mancc from phieunhap c inner join nhacungcap d on c.mancc=d.mancc) e
on a.mahh=e.mahh where b.makho=@makho
end
GO
/****** Object:  StoredProcedure [dbo].[sp_customer_insert]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_customer_insert]
@tenkh nvarchar(50), @gioitinh nvarchar(20), @ngaysinh datetime,
@diachi nvarchar(200), @sdt varchar(20)
as begin
	insert into KhachHang (tenkh, gioitinh, ngaysinh, diachi, sdt)
	values (@tenkh, @gioitinh, @ngaysinh, @diachi, @sdt)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_customer_update]    Script Date: 5/14/2017 8:40:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_customer_update]
@makh int, @tenkh nvarchar(50), @gioitinh nvarchar(20), @ngaysinh datetime,
@diachi nvarchar(200), @sdt varchar(20)
as begin
	update khachhang set tenkh=@tenkh, gioitinh=@gioitinh, ngaysinh=@ngaysinh,
		diachi=@diachi, sdt=@sdt where makh=@makh
end
GO
