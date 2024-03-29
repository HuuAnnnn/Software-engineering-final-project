USE [master]
GO
/****** Object:  Database [QuanLyCuaHangDungCuTheThao]    Script Date: 4/24/2023 3:11:15 PM ******/
CREATE DATABASE [QuanLyCuaHangDungCuTheThao]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyCuaHangDungCuTheThao', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyCuaHangDungCuTheThao.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyCuaHangDungCuTheThao_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyCuaHangDungCuTheThao_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyCuaHangDungCuTheThao].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET QUERY_STORE = OFF
GO
USE [QuanLyCuaHangDungCuTheThao]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[timesChangePassword] [int] NOT NULL,
	[role] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [varchar](50) NULL,
	[fullName] [varchar](255) NULL,
	[point] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[departmentId] [int] NULL,
	[departmentName] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [nvarchar](50) NOT NULL,
	[fullName] [nvarchar](100) NOT NULL,
	[salary] [int] NOT NULL,
	[birthday] [date] NULL,
	[sex] [nvarchar](10) NULL,
	[phone] [nvarchar](20) NULL,
	[address] [nvarchar](50) NULL,
	[avatar] [varbinary](max) NULL,
	[department] [int] NOT NULL,
	[isDeleted] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[productID] [nvarchar](50) NOT NULL,
	[productName] [nvarchar](50) NOT NULL,
	[quantityInWareHouse] [int] NOT NULL,
	[quantityInStore] [int] NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[photo] [varbinary](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipt]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[id] [varchar](50) NOT NULL,
	[dateCreate] [date] NULL,
	[total] [float] NULL,
	[employeeID] [nvarchar](50) NULL,
	[customerId] [nvarchar](50) NULL,
	[receiptState] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receiptLine]    Script Date: 4/24/2023 3:11:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receiptLine](
	[orderId] [varchar](50) NULL,
	[productId] [varchar](50) NULL,
	[quantity] [int] NULL,
	[total] [float] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[customer] ADD  DEFAULT ((0)) FOR [point]
GO
ALTER TABLE [dbo].[receipt] ADD  DEFAULT ('not pay') FOR [receiptState]
GO
USE [master]
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET  READ_WRITE 
GO
