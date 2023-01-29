USE [master]
GO
/****** Object:  Database [EcommerceProjectDb2]    Script Date: 29.01.2023 18:09:09 ******/
CREATE DATABASE [EcommerceProjectDb2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EcommerceProjectDb2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EcommerceProjectDb2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EcommerceProjectDb2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EcommerceProjectDb2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EcommerceProjectDb2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EcommerceProjectDb2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EcommerceProjectDb2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET ARITHABORT OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EcommerceProjectDb2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EcommerceProjectDb2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EcommerceProjectDb2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EcommerceProjectDb2] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EcommerceProjectDb2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET RECOVERY FULL 
GO
ALTER DATABASE [EcommerceProjectDb2] SET  MULTI_USER 
GO
ALTER DATABASE [EcommerceProjectDb2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EcommerceProjectDb2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EcommerceProjectDb2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EcommerceProjectDb2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EcommerceProjectDb2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EcommerceProjectDb2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EcommerceProjectDb2', N'ON'
GO
ALTER DATABASE [EcommerceProjectDb2] SET QUERY_STORE = OFF
GO
USE [EcommerceProjectDb2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29.01.2023 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 29.01.2023 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 29.01.2023 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [nvarchar](450) NOT NULL,
	[ContactName] [nvarchar](max) NULL,
	[CompanytName] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 29.01.2023 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[UnitsInStock] [smallint] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 29.01.2023 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[SurName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Status] [tinyint] NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230123072434_Init', N'6.0.13')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230123072550_Init2', N'6.0.13')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'teknoloji')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Kıyafet')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Mobilya')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (1, 1, N'Telefon', 5, CAST(15000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (2, 1, N'Televizyon', 15, CAST(18000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [UnitsInStock], [UnitPrice]) VALUES (3, 1, N'Kulaklık', 155, CAST(100.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([Id], [Name], [SurName], [Email], [Password], [Phone], [Address], [Status], [UpdateDate], [CreateDate]) VALUES (2, N'Zilan', N'ömer', N'zo@gmail..com', N'123', N'5323403809', N'istanbul', 1, NULL, CAST(N'2023-01-23T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[User] ([Id], [Name], [SurName], [Email], [Password], [Phone], [Address], [Status], [UpdateDate], [CreateDate]) VALUES (3, N'string', N'string', N'string', N'string', N'string', N'string', 0, CAST(N'2023-01-29T12:59:56.8360000' AS DateTime2), CAST(N'2023-01-29T12:59:56.8360000' AS DateTime2))
GO
INSERT [dbo].[User] ([Id], [Name], [SurName], [Email], [Password], [Phone], [Address], [Status], [UpdateDate], [CreateDate]) VALUES (4, N'zilan2', N'ömer', N'zilan.zilan@zilan.com', N'zilan01', N'05468763016', N'İstanbul', 1, NULL, CAST(N'2023-01-29T16:16:18.2209079' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
USE [master]
GO
ALTER DATABASE [EcommerceProjectDb2] SET  READ_WRITE 
GO
