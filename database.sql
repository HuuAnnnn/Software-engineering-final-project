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
	[productId] [nvarchar](50) NOT NULL,
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

insert into employee values ('Test', N'Nguyễn Hữu An', 100000, 1, 0);

create table department (
	departmentId int,
	departmentName nvarchar(100)
);

insert into department values (1, 'Kinh Doanh');
insert into department values (2, 'Kho');
insert into department values (3, 'Thu ngân');

create table receipt (
	id varchar(50) primary key,
	dateCreate date,
	total float,
	employeeID nvarchar(50),
	customerId nvarchar(50),
	receiptState varchar(10) default ('not pay')
);

create table receiptLine (
	orderId varchar(50),
	productId varchar(50),
	quantity int,
	total float
);


create table customer (
	id varchar(50),
	fullName nvarchar(255),
	point int default 0
);

create table ImportReceipt (
	id varchar(50),
	dateCreated Date,
	Total float,
	StateAccept nvarchar(100),
	EmployeeID varchar(50)
);

create table ImportReceiptLine (
	importReceiptId varchar(50),
	productId varchar(50),
	quantity int,
	total float
);

insert into receipt values ('20230423001', '2023-04-23', 0, 'test', '0773996453', 'not pay');
insert into receipt values ('20230423002', '2023-04-23', 0, 'test', '0773996453', 'not pay');
select * from receipt
select * from product

select * from receiptLine

select * from receipt where receiptState = 'not paid' and dateCreate = '2023-04-23'
select * from product

delete receipt where id = '20230423004'
select * from receipt
select top 1 id from receipt where dateCreate = '2023-04-23' order by id desc

select * from account
select * from customer
select * from department

SELECT employee.*, department.departmentName FROM EMPLOYEE, DEPARTMENT WHERE EMPLOYEEID = 'Test'
update account set role = 'admin' where username = 'Test';
select * from account

select * from product