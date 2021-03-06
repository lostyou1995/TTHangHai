USE [master]
GO
/****** Object:  Database [db_thongtinthuyenvien]    Script Date: 4/1/2018 12:20:00 AM ******/
CREATE DATABASE [db_thongtinthuyenvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_thongtinthuyenvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_thongtinthuyenvien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_thongtinthuyenvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_thongtinthuyenvien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_thongtinthuyenvien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_thongtinthuyenvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_thongtinthuyenvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET  MULTI_USER 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_thongtinthuyenvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_thongtinthuyenvien] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_thongtinthuyenvien]
GO
/****** Object:  Table [dbo].[tb_coquan]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_coquan](
	[MaCoQuan] [int] IDENTITY(1,1) NOT NULL,
	[TenCoQuan] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[TruongCoQuan] [int] NULL,
 CONSTRAINT [PK_tb_coquan] PRIMARY KEY CLUSTERED 
(
	[MaCoQuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_danhsachthuyenvien]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_danhsachthuyenvien](
	[Tau] [int] NOT NULL,
	[ThuyenVien] [int] NOT NULL,
	[TrangThai] [bit] NULL,
	[ThoiGian] [datetime] NOT NULL,
 CONSTRAINT [PK_tb_danhsachthuyenvien] PRIMARY KEY CLUSTERED 
(
	[Tau] ASC,
	[ThuyenVien] ASC,
	[ThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_doanhnghiep]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_doanhnghiep](
	[MSDoanhNghiep] [varchar](50) NOT NULL,
	[TenDoanhNghiep] [nvarchar](150) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[SoFax] [nvarchar](50) NULL,
	[NgayCap] [varchar](12) NULL,
	[NoiCap] [nvarchar](50) NULL,
	[CoQuanPheDuyet] [int] NULL,
	[ChuDoanhNghiep] [int] NULL,
 CONSTRAINT [PK_tb_doanhnghiep] PRIMARY KEY CLUSTERED 
(
	[MSDoanhNghiep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_loaitau]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_loaitau](
	[LoaiTau] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
	[CoQuanThem] [int] NULL,
 CONSTRAINT [PK_tb_loaitau] PRIMARY KEY CLUSTERED 
(
	[LoaiTau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_taikhoan]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_taikhoan](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[TrangThai] [bit] NULL,
	[CoQuanDuyet] [int] NULL,
	[TKThuyenVien] [bit] NULL,
	[TKCoQuan] [bit] NULL,
	[TkDoanhNghiep] [bit] NULL,
	[EmailDangKy] [varchar](100) NULL,
	[SDTDangKy] [varchar](50) NULL,
 CONSTRAINT [PK_tb_taikhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tau_doanhnghiep]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tau_doanhnghiep](
	[Tau] [int] NOT NULL,
	[DoanhNghiep] [varchar](50) NOT NULL,
	[CoQuanPheDuyet] [int] NULL,
	[NgayDuyet] [nvarchar](12) NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_tb_tau_doanhnghiep] PRIMARY KEY CLUSTERED 
(
	[Tau] ASC,
	[DoanhNghiep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_thuyen]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_thuyen](
	[MaTau] [int] IDENTITY(1,1) NOT NULL,
	[SoHieu] [nvarchar](50) NULL,
	[TenTau] [nvarchar](50) NULL,
	[IMO] [nvarchar](50) NULL,
	[QuocTich] [nvarchar](50) NULL,
	[LoaiTau] [int] NULL,
	[TongDungTichMay] [float] NULL,
	[TongCSMayChinh] [float] NULL,
	[ChuTau] [int] NULL,
	[CoQuanPheDuyet] [int] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_tb_thuyen] PRIMARY KEY CLUSTERED 
(
	[MaTau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_thuyenvien]    Script Date: 4/1/2018 12:20:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_thuyenvien](
	[MaThuyenVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTenLot] [nvarchar](100) NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [nvarchar](12) NULL,
	[NoiSinh] [ntext] NULL,
	[DiaChiThuongTru] [ntext] NULL,
	[Mobile] [varchar](12) NULL,
	[SoDienThoai] [varchar](12) NULL,
	[SoCMND] [varchar](12) NULL,
	[NgayCap] [varchar](12) NULL,
	[NoiCap] [nvarchar](50) NULL,
	[TaiKhoan] [varchar](50) NULL,
 CONSTRAINT [PK_tb_thuyenvien] PRIMARY KEY CLUSTERED 
(
	[MaThuyenVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tb_danhsachthuyenvien]  WITH CHECK ADD  CONSTRAINT [FK_tb_danhsachthuyenvien_tb_thuyen] FOREIGN KEY([Tau])
REFERENCES [dbo].[tb_thuyen] ([MaTau])
GO
ALTER TABLE [dbo].[tb_danhsachthuyenvien] CHECK CONSTRAINT [FK_tb_danhsachthuyenvien_tb_thuyen]
GO
ALTER TABLE [dbo].[tb_danhsachthuyenvien]  WITH CHECK ADD  CONSTRAINT [FK_tb_danhsachthuyenvien_tb_thuyenvien] FOREIGN KEY([ThuyenVien])
REFERENCES [dbo].[tb_thuyenvien] ([MaThuyenVien])
GO
ALTER TABLE [dbo].[tb_danhsachthuyenvien] CHECK CONSTRAINT [FK_tb_danhsachthuyenvien_tb_thuyenvien]
GO
ALTER TABLE [dbo].[tb_loaitau]  WITH CHECK ADD  CONSTRAINT [FK_tb_loaitau_tb_coquan] FOREIGN KEY([CoQuanThem])
REFERENCES [dbo].[tb_coquan] ([MaCoQuan])
GO
ALTER TABLE [dbo].[tb_loaitau] CHECK CONSTRAINT [FK_tb_loaitau_tb_coquan]
GO
ALTER TABLE [dbo].[tb_tau_doanhnghiep]  WITH CHECK ADD  CONSTRAINT [FK_tb_tau_doanhnghiep_tb_coquan] FOREIGN KEY([CoQuanPheDuyet])
REFERENCES [dbo].[tb_coquan] ([MaCoQuan])
GO
ALTER TABLE [dbo].[tb_tau_doanhnghiep] CHECK CONSTRAINT [FK_tb_tau_doanhnghiep_tb_coquan]
GO
ALTER TABLE [dbo].[tb_tau_doanhnghiep]  WITH CHECK ADD  CONSTRAINT [FK_tb_tau_doanhnghiep_tb_doanhnghiep] FOREIGN KEY([DoanhNghiep])
REFERENCES [dbo].[tb_doanhnghiep] ([MSDoanhNghiep])
GO
ALTER TABLE [dbo].[tb_tau_doanhnghiep] CHECK CONSTRAINT [FK_tb_tau_doanhnghiep_tb_doanhnghiep]
GO
ALTER TABLE [dbo].[tb_tau_doanhnghiep]  WITH CHECK ADD  CONSTRAINT [FK_tb_tau_doanhnghiep_tb_thuyen] FOREIGN KEY([Tau])
REFERENCES [dbo].[tb_thuyen] ([MaTau])
GO
ALTER TABLE [dbo].[tb_tau_doanhnghiep] CHECK CONSTRAINT [FK_tb_tau_doanhnghiep_tb_thuyen]
GO
ALTER TABLE [dbo].[tb_thuyen]  WITH CHECK ADD  CONSTRAINT [FK_tb_thuyen_tb_coquan] FOREIGN KEY([CoQuanPheDuyet])
REFERENCES [dbo].[tb_coquan] ([MaCoQuan])
GO
ALTER TABLE [dbo].[tb_thuyen] CHECK CONSTRAINT [FK_tb_thuyen_tb_coquan]
GO
ALTER TABLE [dbo].[tb_thuyen]  WITH CHECK ADD  CONSTRAINT [FK_tb_thuyen_tb_loaitau] FOREIGN KEY([LoaiTau])
REFERENCES [dbo].[tb_loaitau] ([LoaiTau])
GO
ALTER TABLE [dbo].[tb_thuyen] CHECK CONSTRAINT [FK_tb_thuyen_tb_loaitau]
GO
ALTER TABLE [dbo].[tb_thuyen]  WITH CHECK ADD  CONSTRAINT [FK_tb_thuyen_tb_thuyenvien] FOREIGN KEY([ChuTau])
REFERENCES [dbo].[tb_thuyenvien] ([MaThuyenVien])
GO
ALTER TABLE [dbo].[tb_thuyen] CHECK CONSTRAINT [FK_tb_thuyen_tb_thuyenvien]
GO
ALTER TABLE [dbo].[tb_thuyenvien]  WITH CHECK ADD  CONSTRAINT [FK_tb_thuyenvien_tb_taikhoan] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[tb_taikhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[tb_thuyenvien] CHECK CONSTRAINT [FK_tb_thuyenvien_tb_taikhoan]
GO
USE [master]
GO
ALTER DATABASE [db_thongtinthuyenvien] SET  READ_WRITE 
GO
