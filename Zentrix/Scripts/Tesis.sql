USE [master]
GO
/****** Object:  Database [BD]    Script Date: 24/10/2017 0:20:35 ******/
CREATE DATABASE [BD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BD.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD] SET RECOVERY FULL 
GO
ALTER DATABASE [BD] SET  MULTI_USER 
GO
ALTER DATABASE [BD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BD]
GO
/****** Object:  Table [dbo].[Indicador]    Script Date: 24/10/2017 0:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Indicador](
	[IDIndicador] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[objetivoEstrategico] [varchar](100) NULL,
	[target] [decimal](18, 2) NULL,
	[rojo] [decimal](18, 2) NULL,
	[amarillo] [decimal](18, 2) NULL,
	[verde] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[conseguido] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Indicador] PRIMARY KEY CLUSTERED 
(
	[IDIndicador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MasterPerspectivaIndicador]    Script Date: 24/10/2017 0:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterPerspectivaIndicador](
	[IDPerspectivaIndicador] [int] IDENTITY(1,1) NOT NULL,
	[IDIndicador] [int] NULL,
	[IDPerspectiva] [int] NULL,
 CONSTRAINT [PK_MasterPerspectivaIndicador] PRIMARY KEY CLUSTERED 
(
	[IDPerspectivaIndicador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Perspectiva]    Script Date: 24/10/2017 0:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perspectiva](
	[IDPerspectiva] [int] IDENTITY(1,1) NOT NULL,
	[Perspectiva] [varchar](100) NULL,
 CONSTRAINT [PK_Perspectiva] PRIMARY KEY CLUSTERED 
(
	[IDPerspectiva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Indicador] ON 

INSERT [dbo].[Indicador] ([IDIndicador], [nombre], [objetivoEstrategico], [target], [rojo], [amarillo], [verde], [fecha], [conseguido]) VALUES (1, N'Ventas', N'Mejorar rentabilidad', CAST(10000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), NULL, CAST(8000.00 AS Decimal(18, 2)))
INSERT [dbo].[Indicador] ([IDIndicador], [nombre], [objetivoEstrategico], [target], [rojo], [amarillo], [verde], [fecha], [conseguido]) VALUES (2, N'prueba', N'prueba', CAST(10000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), NULL, CAST(3400.00 AS Decimal(18, 2)))
INSERT [dbo].[Indicador] ([IDIndicador], [nombre], [objetivoEstrategico], [target], [rojo], [amarillo], [verde], [fecha], [conseguido]) VALUES (3, N'dfgdgdfg', N'dfgdfgdfgdfg', CAST(10000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), NULL, CAST(8000.00 AS Decimal(18, 2)))
INSERT [dbo].[Indicador] ([IDIndicador], [nombre], [objetivoEstrategico], [target], [rojo], [amarillo], [verde], [fecha], [conseguido]) VALUES (4, N'Prueba4', N'Bla bla bla bla', CAST(10000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), NULL, CAST(8000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Indicador] OFF
SET IDENTITY_INSERT [dbo].[MasterPerspectivaIndicador] ON 

INSERT [dbo].[MasterPerspectivaIndicador] ([IDPerspectivaIndicador], [IDIndicador], [IDPerspectiva]) VALUES (2, 3, 1)
INSERT [dbo].[MasterPerspectivaIndicador] ([IDPerspectivaIndicador], [IDIndicador], [IDPerspectiva]) VALUES (3, 4, 1)
SET IDENTITY_INSERT [dbo].[MasterPerspectivaIndicador] OFF
SET IDENTITY_INSERT [dbo].[Perspectiva] ON 

INSERT [dbo].[Perspectiva] ([IDPerspectiva], [Perspectiva]) VALUES (1, N'Financiera')
INSERT [dbo].[Perspectiva] ([IDPerspectiva], [Perspectiva]) VALUES (2, N'Interna')
INSERT [dbo].[Perspectiva] ([IDPerspectiva], [Perspectiva]) VALUES (3, N'Clientes')
INSERT [dbo].[Perspectiva] ([IDPerspectiva], [Perspectiva]) VALUES (4, N'Aprendizaje')
SET IDENTITY_INSERT [dbo].[Perspectiva] OFF
ALTER TABLE [dbo].[MasterPerspectivaIndicador]  WITH CHECK ADD  CONSTRAINT [FK_MasterPerspectivaIndicador_Indicador] FOREIGN KEY([IDIndicador])
REFERENCES [dbo].[Indicador] ([IDIndicador])
GO
ALTER TABLE [dbo].[MasterPerspectivaIndicador] CHECK CONSTRAINT [FK_MasterPerspectivaIndicador_Indicador]
GO
ALTER TABLE [dbo].[MasterPerspectivaIndicador]  WITH CHECK ADD  CONSTRAINT [FK_MasterPerspectivaIndicador_Perspectiva] FOREIGN KEY([IDPerspectiva])
REFERENCES [dbo].[Perspectiva] ([IDPerspectiva])
GO
ALTER TABLE [dbo].[MasterPerspectivaIndicador] CHECK CONSTRAINT [FK_MasterPerspectivaIndicador_Perspectiva]
GO
USE [master]
GO
ALTER DATABASE [BD] SET  READ_WRITE 
GO
