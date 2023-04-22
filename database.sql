USE [master]
GO
/****** Object:  Database [QuanLyCuaHangDungCuTheThao]    Script Date: 4/21/2023 8:21:39 PM ******/
CREATE DATABASE [QuanLyCuaHangDungCuTheThao]
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
/****** Object:  Table [dbo].[Account]    Script Date: 4/21/2023 8:21:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[timesChangePassword] [int] NOT NULL,
	[role] [varchar] (20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/21/2023 8:21:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [nvarchar](50) NOT NULL,
	[fullName] [nvarchar](100) NOT NULL,
	[salary] [int] NOT NULL,
	[department] [int] NOT NULL,
	[isDeleted] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/21/2023 8:21:40 PM ******/
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
USE [master]
GO
ALTER DATABASE [QuanLyCuaHangDungCuTheThao] SET  READ_WRITE 
GO
use [QuanLyCuaHangDungCuTheThao]

insert into account values ('Test', '123456', 0, 'Staff');
update account set password = '8bb0cf6eb9b17d0f7d22b456f121257dc1254e1f01665370476383ea776df414'
where username = 'Test'

update account set timesChangePassword = 0
where username = 'Test'

select * from account

select * from employee

insert into employee values ('Test', N'Nguy?n H?u An', 100000, N'Thu ng�n', 0);