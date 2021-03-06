USE [master]
GO
/****** Object:  Database [L2S]    Script Date: 22/05/2019 11:29:20 ******/
CREATE DATABASE [L2S]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'L2S', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\L2S.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'L2S_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\L2S_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [L2S] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [L2S].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [L2S] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [L2S] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [L2S] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [L2S] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [L2S] SET ARITHABORT OFF 
GO
ALTER DATABASE [L2S] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [L2S] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [L2S] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [L2S] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [L2S] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [L2S] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [L2S] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [L2S] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [L2S] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [L2S] SET  DISABLE_BROKER 
GO
ALTER DATABASE [L2S] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [L2S] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [L2S] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [L2S] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [L2S] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [L2S] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [L2S] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [L2S] SET RECOVERY FULL 
GO
ALTER DATABASE [L2S] SET  MULTI_USER 
GO
ALTER DATABASE [L2S] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [L2S] SET DB_CHAINING OFF 
GO
ALTER DATABASE [L2S] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [L2S] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [L2S] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'L2S', N'ON'
GO
ALTER DATABASE [L2S] SET QUERY_STORE = OFF
GO

CREATE LOGIN [myuser] WITH PASSWORD=N'apassword', DEFAULT_DATABASE=[L2S], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

USE [L2S]
GO
/****** Object:  User [myuser]    Script Date: 22/05/2019 11:29:20 ******/
CREATE USER [myuser] FOR LOGIN [myuser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [myuser]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Street] [nchar](50) NOT NULL,
	[Number] [nchar](20) NOT NULL,
	[PostCode] [nchar](100) NOT NULL,
	[City] [nchar](40) NOT NULL,
	[CountryId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[InsertionDateTime] [datetime2](3) NOT NULL,
	[PersonId] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](30) NOT NULL,
	[LastName] [nchar](30) NOT NULL,
	[Email] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestTable1]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTable1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dummy] [nchar](10) NOT NULL,
	[Dummy2] [int] NOT NULL,
 CONSTRAINT [PK_TestTable1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestTable2]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTable2](
	[Id] [uniqueidentifier] NOT NULL,
	[Dummy1] [nchar](10) NOT NULL,
	[Dummy2] [int] NOT NULL,
 CONSTRAINT [PK_TestTable2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestTable3]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTable3](
	[TestTable3Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_TestTable3] PRIMARY KEY CLUSTERED 
(
	[TestTable3Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestTable4]    Script Date: 22/05/2019 11:29:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestTable4](
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_TestTable4] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[TestTable2] ADD  CONSTRAINT [DF_TestTable2_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Country_Address] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Country_Address]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Order_Item] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Order_Item]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Person_Order] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Person_Order]
GO
USE [master]
GO
ALTER DATABASE [L2S] SET  READ_WRITE 
GO


USE [L2S]
SET NUMERIC_ROUNDABORT OFF
GO
SET XACT_ABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
BEGIN TRANSACTION
ALTER TABLE [dbo].[Address] DROP CONSTRAINT [FK_Country_Address]
ALTER TABLE [dbo].[Address] DROP CONSTRAINT [FK_Person_Address]
ALTER TABLE [dbo].[Item] DROP CONSTRAINT [FK_Order_Item]
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [FK_Person_Order]
INSERT INTO [dbo].[Order] ([Id], [InsertionDateTime], [PersonId]) VALUES (N'7afc9364-bcbb-4943-8fd9-b79316905567', '20190516 20:12:38.950', 1)
INSERT INTO [dbo].[Item] ([Id], [Name], [OrderId]) VALUES (N'277e9d52-b5aa-4057-ad59-12d34a8382bd', N'Second product                                                                                      ', N'7afc9364-bcbb-4943-8fd9-b79316905567')
INSERT INTO [dbo].[Item] ([Id], [Name], [OrderId]) VALUES (N'ddad2620-ceff-4538-8c94-097795e46a88', N'Second product                                                                                      ', N'7afc9364-bcbb-4943-8fd9-b79316905567')
INSERT INTO [dbo].[Item] ([Id], [Name], [OrderId]) VALUES (N'fed6bbe6-207f-48f7-9eb0-cc5ffa2817de', N'First product                                                                                       ', N'7afc9364-bcbb-4943-8fd9-b79316905567')
SET IDENTITY_INSERT [dbo].[Person] ON
INSERT INTO [dbo].[Person] ([Id], [FirstName], [LastName], [Email]) VALUES (1, N'Gigi                          ', N'Bulan                         ', N'gigi@bulan.ro                                     ')
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Address] ON
INSERT INTO [dbo].[Address] ([Id], [Street], [Number], [PostCode], [City], [CountryId], [PersonId]) VALUES (1, N'Strada Muncii                                     ', N'69                  ', N'6000                                                                                                ', N'Kiel                                    ', 1, 1)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Country] ON
INSERT INTO [dbo].[Country] ([Id], [Name]) VALUES (1, N'Switzerland                                       ')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[TestTable1] ON
INSERT INTO [dbo].[TestTable1] ([Id], [Dummy], [Dummy2]) VALUES (1, N'DumText   ', 99)
SET IDENTITY_INSERT [dbo].[TestTable1] OFF
INSERT INTO [dbo].[TestTable2] ([Id], [Dummy1], [Dummy2]) VALUES (N'12dfc3ad-403a-4978-979f-677cc55da08c', N'Hippie    ', 88)
ALTER TABLE [dbo].[Address]
    ADD CONSTRAINT [FK_Country_Address] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id])
ALTER TABLE [dbo].[Address]
    ADD CONSTRAINT [FK_Person_Address] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
ALTER TABLE [dbo].[Item]
    ADD CONSTRAINT [FK_Order_Item] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id])
ALTER TABLE [dbo].[Order]
    ADD CONSTRAINT [FK_Person_Order] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
COMMIT TRANSACTION


